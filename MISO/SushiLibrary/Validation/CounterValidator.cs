﻿/*
Copyright (c) 2009, Serials Solutions
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
    * Neither the name of the <ORGANIZATION> nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace SushiLibrary.Validation
{
    public class CounterValidator : SushiValidator
    {
        public override bool Validate(SushiReport report)
        {
            base.Validate(report);

            if (report.CounterReports.Count < 1)
            {
                // no reports to validate, fail validation and quit
                _errorMessages.Add("No Counter Data found.");
                return false;
            }

            // for now just expect one counter report
            CounterReport counterReport = report.CounterReports[0];

            foreach (var reportItem in counterReport.ReportItems)
            {
                foreach (var key in reportItem.Metrics.Keys)
                {
                    CounterMetric metric = reportItem.Metrics[key];

                    if (!ValidationRule.CheckStartDay(metric.Start))
                    {
                        _isValid = false;
                        _errorMessages.Add(
                            string.Format(
                                "Report Item \"{0}\" has a metric start date that is not the first day of the month. The start date given was {1}.",
                                reportItem.Name, metric.Start.ToString("yyyy-M-d")));
                    }

                    if (!ValidationRule.CheckEndDay(metric.End))
                    {
                        _isValid = false;
                        _errorMessages.Add(
                            string.Format(
                                "Report Item \"{0}\" has a metric end date that is not the last day of the month. The end date given was {1}.",
                                reportItem.Name, metric.End.ToString("yyyy-M-d")));
                    }

                    switch (report.ReportType)
                    {
                        case CounterReportType.JR1:
                        case CounterReportType.JR2:
                        case CounterReportType.JR3:
                        case CounterReportType.JR4:
                        case CounterReportType.DB1:
                        case CounterReportType.DB2:
                        case CounterReportType.DB3:
                            if (!ValidationRule.CheckDuration(metric.Start, metric.End, 0))
                            {
                                _isValid = false;
                                _errorMessages.Add(
                                    string.Format(
                                        "Report Item \"{0}\" has a metric duration of more than 1 month. The given dates were from {1} to {2}.",
                                        reportItem.Name, metric.Start.ToString("yyyy-M-d"), metric.End.ToString("yyyy-M-d")));
                            }
                            break;
                    }
                }
            }



            return _isValid;
        }
    }
}

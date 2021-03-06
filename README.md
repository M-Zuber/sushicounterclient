#### Supported Platforms
- Windows 7 32 bit
- Windows 7 64 bit

#### Requirements

##### Microsoft .NET Framework 4.5.2

- [Web Installer](http://www.microsoft.com/en-us/download/details.aspx?id=42643)

- [Offline Installer](http://www.microsoft.com/en-us/download/details.aspx?id=42642)

####Description

The client will query multiple SUSHI servers for any number of libraries and will convert the XML report into a CSV, which can then be uploaded to 360 Counter.

It will ignore any data not already supported by 360 Counter including monthly usage data for PDF and HTML specific requests or federated search statistics. In addition, it will also ignore Year to Date totals since the SUSHI protocal doesn't return any YTD data.

The configuration file for SUSHI server information is in sushiconfig.csv
The first line is ignored and contains the header for what data is expected in each column.

The Library Code is internal to Serials Solutions but can be any arbitrary string. 
It is only used when you want to run reports for a specific library.
Otherwise, it will run through every line in sushiconfig.csv, fetch the reports that have a 'y', and convert them to Counter R2 CSVs.

Any errors encountered will be written to an error file in the same directory.

The syntax for the utility takes a start and end date in `yyyyMM` format and an optional list of library codes delimited by commas with no space.

Examples:
```
miso -d 200801 200805
miso -d 200812 200905 -l XER,ER1
```

There is also a validation mode to validate local Sushi-Counter XML files. 
For example, the following command will fetch all the reports for 2008 Jan to 2008 May and validate each response

`miso -v -d 200801 200805`

You can test the included sample JR1 file.

`miso -v JR1v3SampleData.xml`

If you wish to examine the actual XML returned by the server, you can save the file as xml without converting to csv.

`miso -x -d 200801 200805`

For more syntax details, use the following command

`miso -h`

****Building from source****

You will need Visual Studio 2013 to build the project.
A free version ([Community Edition](https://www.visualstudio.com/en-us/products/visual-studio-community-vs.aspx)) is available but is not tested.


It may also be possible to build for non-Windows platforms using Project Mono but this is not tested.

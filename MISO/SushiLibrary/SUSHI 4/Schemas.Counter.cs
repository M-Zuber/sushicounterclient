using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Schemas.Counter
{    
    /// <summary>
    /// <para>Can contain many Reports.</para>
    /// <para>COUNTER Reports. The "Reports" (plural) is not actually used in SUSHI. The COUNTER_SUSHI schema includes is own "Report" element which is of type c:Reports (see below). Which means the the SUSHI ReportResponse will include usually just one "Report" (singular) element</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Reports", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Reports", Namespace="http://www.niso.org/schemas/counter")]
    public partial class Reports
    {
        
        /// <summary>
        /// <para>An instance of a COUNTER Report.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Report", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<Report> Report { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Reports" /> class.</para>
        /// </summary>
        public Reports()
        {
            this.Report = new System.Collections.ObjectModel.Collection<Report>();
        }
    }
    
    /// <summary>
    /// <para>An individual COUNTER Report. (See comments in the XSD for attribute definitions).</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Report", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Report
    {
        
        /// <summary>
        /// <para>The content provider preparing the report.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Vendor", Namespace="http://www.niso.org/schemas/counter")]
        public Vendor Vendor { get; set; }
        
        /// <summary>
        /// <para>The organization for which the usage statistics are being reported.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Customer", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ReportCustomer> Customer { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Report" /> class.</para>
        /// </summary>
        public Report()
        {
            this.Customer = new System.Collections.ObjectModel.Collection<ReportCustomer>();
        }
        
        /// <summary>
        /// <para>Date/time the report was created.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Created", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="dateTime")]
        public System.DateTime Created { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Created property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedSpecified { get; set; }
        
        /// <summary>
        /// <para>An identifier  assigned by the application creating the  message for tracking purposes.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ID", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string ID { get; set; }
        
        /// <summary>
        /// <para>The version of the COUNTER report.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Version", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Version { get; set; }
        
        /// <summary>
        /// <para>The short name of the report as would be defined in the SUSHI request. See the reports registry at http://www.niso.org/workrooms/sushi/reports </para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Name", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// <para>The COUNTER report name, e.g. Journal Report 1. See the reports registry at http://www.niso.org/workrooms/sushi/reports</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("Title", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="string")]
        public string Title { get; set; }
    }
    
    /// <summary>
    /// <para>The Content Provider.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Vendor", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Vendor : Organization
    {
    }
    
    /// <summary>
    /// <para>Details for the Vendor or Customer.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Organization", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Customer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReportCustomer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Vendor))]
    public partial class Organization
    {
        
        /// <summary>
        /// <para>Name of the organization.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string Name { get; set; }
        
        /// <summary>
        /// <para>The ID by which this organization is known by the content provider. In the case of the customer, it is the CustomerID as used by the content provider.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ID { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Contact", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<Contact> Contact { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Contact collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContactSpecified
        {
            get
            {
                return (this.Contact.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Organization" /> class.</para>
        /// </summary>
        public Organization()
        {
            this.Contact = new System.Collections.ObjectModel.Collection<Contact>();
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("WebSiteUrl", Namespace="http://www.niso.org/schemas/counter", DataType="anyURI")]
        public string WebSiteUrl { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("LogoUrl", Namespace="http://www.niso.org/schemas/counter", DataType="anyURI")]
        public string LogoUrl { get; set; }
    }
    
    /// <summary>
    /// <para>Details of a person to contact.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Contact", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Contact
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Contact", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ContactProperty { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("E-mail", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string E_Mail { get; set; }
    }
    
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ReportCustomer", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReportCustomer : Customer
    {
        
        /// <summary>
        /// <para>The Journal, Book, Database, Platform, etc. being reported on.  Note that  one "ReportItems" contains usage stats for one item.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ReportItems", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ReportItem> ReportItems { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ReportCustomer" /> class.</para>
        /// </summary>
        public ReportCustomer()
        {
            this.ReportItems = new System.Collections.ObjectModel.Collection<ReportItem>();
        }
    }
    
    /// <summary>
    /// <para>Details about the customer whose data the report represents.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Customer", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReportCustomer))]
    public partial class Customer : Organization
    {
        
        /// <summary>
        /// <para>For Consortium Reports, identify the consortium the customer is part of (the one requestnig the report).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Consortium", Namespace="http://www.niso.org/schemas/counter")]
        public Consortium Consortium { get; set; }
        
        /// <summary>
        /// <para>Include any known standard identifiers which identify the Customer, e.g. MARC code.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InstitutionalIdentifier", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<Identifier> InstitutionalIdentifier { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the InstitutionalIdentifier collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstitutionalIdentifierSpecified
        {
            get
            {
                return (this.InstitutionalIdentifier.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Customer" /> class.</para>
        /// </summary>
        public Customer()
        {
            this.InstitutionalIdentifier = new System.Collections.ObjectModel.Collection<Identifier>();
        }
    }
    
    /// <summary>
    /// <para>Each report item represents usage for a title. Note: it may have been more appropriate if the element name "ReportItems" was not plural since there can be many "ReportItems" one would expect each one to be a "ReportItem" without the 's'. As it stands there will be many "ReportItems" elements.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Consortium", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Consortium
    {
        
        /// <summary>
        /// <para>If there is an abbreviation or code that identifies the consortium, include it here.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Code", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string Code { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("WellKnownName", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string WellKnownName { get; set; }
    }
    
    /// <summary>
    /// <para>Used by ItemIdentifiers and InstitutionIdentifiers.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Identifier", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Identifier
    {
        
        /// <summary>
        /// <para>Defines the internationally recognized identifier for items and (in the future) institutions e.g. ISSN, ISBN, DOI.  See: http://www.niso.org/workrooms/sushi/values/#item for the list of identifier types registered for use with COUNTER reports.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Type", Namespace="http://www.niso.org/schemas/counter")]
        public IdentifierType Type { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Value", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// <para>
    ///IdentifierType as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("IdentifierType", Namespace="http://www.niso.org/schemas/counter")]
    public enum IdentifierType
    {
        
        /// <summary>
        /// </summary>
        Online_ISSN,
        
        /// <summary>
        /// </summary>
        Print_ISSN,
        
        /// <summary>
        /// </summary>
        EISSN,
        
        /// <summary>
        /// </summary>
        ISSN,
        
        /// <summary>
        /// </summary>
        ISBN,
        
        /// <summary>
        /// </summary>
        Online_ISBN,
        
        /// <summary>
        /// </summary>
        Print_ISBN,
        
        /// <summary>
        /// </summary>
        DOI,
        
        /// <summary>
        /// </summary>
        Proprietary,
    }
    
    /// <summary>
    /// <para>The container for usage data and other information related to an item such as a journal, book, database, etc.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ReportItem", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ReportItem
    {
        
        /// <summary>
        /// <para>Well known item identifiers (ISSN, ISBN, etc.).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ParentItem", Namespace="http://www.niso.org/schemas/counter")]
        public ParentItem ParentItem { get; set; }
        
        /// <summary>
        /// <para>Well known item identifiers (ISSN, ISBN, etc.).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemIdentifier", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<Identifier> ItemIdentifier { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemIdentifier collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemIdentifierSpecified
        {
            get
            {
                return (this.ItemIdentifier.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ReportItem" /> class.</para>
        /// </summary>
        public ReportItem()
        {
            this.ItemIdentifier = new System.Collections.ObjectModel.Collection<Identifier>();
            this.ItemContributor = new System.Collections.ObjectModel.Collection<ItemContributor>();
            this.ItemDate = new System.Collections.ObjectModel.Collection<ItemDate>();
            this.ItemAttribute = new System.Collections.ObjectModel.Collection<ItemAttribute>();
            this.ItemPerformance = new System.Collections.ObjectModel.Collection<Metric>();
        }
        
        /// <summary>
        /// <para>Author, editor or other contributor of to the parent work if an article or other authored work.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemContributor", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemContributor> ItemContributor { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemContributor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemContributorSpecified
        {
            get
            {
                return (this.ItemContributor.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Date of publication or date item first accessed.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemDate", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemDate> ItemDate { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemDate collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemDateSpecified
        {
            get
            {
                return (this.ItemDate.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Well known attributes of an item (ArticleVersion, ArticleType).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemAttribute", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemAttribute> ItemAttribute { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemAttribute collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemAttributeSpecified
        {
            get
            {
                return (this.ItemAttribute.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>The platform is the name of the online host as determined by the service provider, e.g.,  EBSCOhost, ScienceDirect, etc.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemPlatform", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ItemPlatform { get; set; }
        
        /// <summary>
        /// <para>Name of the publisher of an item.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemPublisher", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ItemPublisher { get; set; }
        
        /// <summary>
        /// <para>Name for the item e.g. Journal Title,  Book Title, Database Name.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemName", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ItemName { get; set; }
        
        /// <summary>
        /// <para>Describes the nature of the item: e.g. Journal, Database, Platform, Books, Reference works item data type. See: http://www.niso.org/workrooms/sushi/values/#data for the list of registered values.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemDataType", Namespace="http://www.niso.org/schemas/counter")]
        public DataType ItemDataType { get; set; }
        
        /// <summary>
        /// <para>The set of statistics representing one category of usage (e.g. Searches) for the period of one month. Note: the Attribute PubYear is currently only used for Journal Report 5.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemPerformance", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<Metric> ItemPerformance { get; private set; }
    }
    
    /// <summary>
    /// <para>When usage is for articles or chapters, the ParentItem identifies the journal or book.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ParentItem", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ParentItem
    {
        
        /// <summary>
        /// <para>Well known item identifiers (ISSN, ISBN, etc.).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemIdentifier", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<Identifier> ItemIdentifier { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemIdentifier collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemIdentifierSpecified
        {
            get
            {
                return (this.ItemIdentifier.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ParentItem" /> class.</para>
        /// </summary>
        public ParentItem()
        {
            this.ItemIdentifier = new System.Collections.ObjectModel.Collection<Identifier>();
            this.ItemContributor = new System.Collections.ObjectModel.Collection<ItemContributor>();
            this.ItemDate = new System.Collections.ObjectModel.Collection<ItemDate>();
            this.ItemAttribute = new System.Collections.ObjectModel.Collection<ItemAttribute>();
        }
        
        /// <summary>
        /// <para>Author, editor or other contributor of to the parent work if an article or other authored work. </para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemContributor", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemContributor> ItemContributor { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemContributor collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemContributorSpecified
        {
            get
            {
                return (this.ItemContributor.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Date of publication or date item first accessed.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemDate", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemDate> ItemDate { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemDate collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemDateSpecified
        {
            get
            {
                return (this.ItemDate.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Well known attributes of an item (ArticleVersion, ArticleType).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemAttribute", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemAttribute> ItemAttribute { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemAttribute collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemAttributeSpecified
        {
            get
            {
                return (this.ItemAttribute.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Name of the publisher of an item.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemPublisher", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ItemPublisher { get; set; }
        
        /// <summary>
        /// <para>Name for the item e.g. Journal Title,  Book Title, Database Name.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemName", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ItemName { get; set; }
        
        /// <summary>
        /// <para>Describes the nature of the item: e.g. Journal, Database, Platform, Books, Reference works item data type. See: http://www.niso.org/workrooms/sushi/values/#data for the list of registered values.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemDataType", Namespace="http://www.niso.org/schemas/counter")]
        public DataType ItemDataType { get; set; }
    }
    
    /// <summary>
    /// <para>An author, editor or other contributor to a work.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ItemContributor", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ItemContributor
    {
        
        /// <summary>
        /// <para>Defines the type of contributor identifier, e.g. isni, orcid, name</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemContributorID", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<ItemContributorID> ItemContributorID { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemContributorID collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemContributorIDSpecified
        {
            get
            {
                return (this.ItemContributorID.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ItemContributor" /> class.</para>
        /// </summary>
        public ItemContributor()
        {
            this.ItemContributorID = new System.Collections.ObjectModel.Collection<ItemContributorID>();
            this.ItemContributorAffiliation = new System.Collections.ObjectModel.Collection<string>();
            this.ItemContributorRole = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// <para>Name of the contributor usually as lastname, firstname initials, e.g. Smith, Paul J. </para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemContributorName", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string ItemContributorName { get; set; }
        
        /// <summary>
        /// <para>Name of organization contributor was affilated with in the context of the contribution.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemContributorAffiliation", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public System.Collections.ObjectModel.Collection<string> ItemContributorAffiliation { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemContributorAffiliation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemContributorAffiliationSpecified
        {
            get
            {
                return (this.ItemContributorAffiliation.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Contributor's role in creation of item, e.g. Author, Editor, etc.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ItemContributorRole", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public System.Collections.ObjectModel.Collection<string> ItemContributorRole { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ItemContributorRole collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemContributorRoleSpecified
        {
            get
            {
                return (this.ItemContributorRole.Count != 0);
            }
        }
    }
    
    /// <summary>
    /// <para>An author, editor or other contributor to a work.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ItemContributorID", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ItemContributorID
    {
        
        /// <summary>
        /// <para>Defines the type of contributor identifier, e.g. isni, orcid, name</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Type", Namespace="http://www.niso.org/schemas/counter")]
        public ContributorIdentifierType Type { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Value", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// <para>
    ///Attribute as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ContributorIdentifierType", Namespace="http://www.niso.org/schemas/counter")]
    public enum ContributorIdentifierType
    {
        
        /// <summary>
        /// </summary>
        ISNI,
        
        /// <summary>
        /// </summary>
        ORCID,
        
        /// <summary>
        /// </summary>
        Name,
        
        /// <summary>
        /// </summary>
        Proprietary,
    }
    
    /// <summary>
    /// <para>Date of publication or date first accessed online.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ItemDate", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ItemDate
    {
        
        /// <summary>
        /// <para>Defines publication or first access date for the item  See: http://www.niso.org/workrooms/sushi/values/#item for the list of attribute types registered for use with COUNTER reports.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Type", Namespace="http://www.niso.org/schemas/counter")]
        public DateType Type { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Value", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// <para>
    ///Attribute as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("DateType", Namespace="http://www.niso.org/schemas/counter")]
    public enum DateType
    {
        
        /// <summary>
        /// </summary>
        PubDate,
        
        /// <summary>
        /// </summary>
        FirstAccessedOnline,
        
        /// <summary>
        /// </summary>
        Proprietary,
    }
    
    /// <summary>
    /// <para>Used to describe various attributes of an item, such as article version and article type.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("ItemAttribute", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ItemAttribute
    {
        
        /// <summary>
        /// <para>Defines the well-know attributes of an item, e.g. ArticleVersion and ArticleType for articles and QualificationName and QualificationLevel for thesis. .  See: http://www.niso.org/workrooms/sushi/values/#item for the list of attribute types registered for use with COUNTER reports.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Type", Namespace="http://www.niso.org/schemas/counter")]
        public AttributeType Type { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Value", Namespace="http://www.niso.org/schemas/counter", DataType="string")]
        public string Value { get; set; }
    }
    
    /// <summary>
    /// <para>
    ///Attribute as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("AttributeType", Namespace="http://www.niso.org/schemas/counter")]
    public enum AttributeType
    {
        
        /// <summary>
        /// </summary>
        ArticleVersion,
        
        /// <summary>
        /// </summary>
        ArticleType,
        
        /// <summary>
        /// </summary>
        QualificationName,
        
        /// <summary>
        /// </summary>
        QualificationLevel,
        
        /// <summary>
        /// </summary>
        Proprietary,
    }
    
    /// <summary>
    /// <para>
    ///DataType as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("DataType", Namespace="http://www.niso.org/schemas/counter")]
    public enum DataType
    {
        
        /// <summary>
        /// </summary>
        Journal,
        
        /// <summary>
        /// </summary>
        Database,
        
        /// <summary>
        /// </summary>
        Platform,
        
        /// <summary>
        /// </summary>
        Book,
        
        /// <summary>
        /// </summary>
        Collection,
        
        /// <summary>
        /// </summary>
        Multimedia,
    }
    
    /// <summary>
    /// <para>The actual usage details.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Metric", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Metric
    {
        
        /// <summary>
        /// <para>Defines the MONTH for the itemPerformance instance. </para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Period", Namespace="http://www.niso.org/schemas/counter")]
        public DateRange Period { get; set; }
        
        /// <summary>
        /// <para>E.G., Requests, Searches, Turnaways, Sessions. See http://www.niso.org/workrooms/sushi/values/#category for list of registered values.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Category", Namespace="http://www.niso.org/schemas/counter")]
        public Category Category { get; set; }
        
        /// <summary>
        /// <para>Actual performance measure.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Instance", Namespace="http://www.niso.org/schemas/counter")]
        public System.Collections.ObjectModel.Collection<PerformanceCounter> Instance { get; private set; }
        
        /// <summary>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Metric" /> class.</para>
        /// </summary>
        public Metric()
        {
            this.Instance = new System.Collections.ObjectModel.Collection<PerformanceCounter>();
        }
        
        /// <summary>
        /// <para>Year of publication. (This is currently ONLY used by Journal Report 5 which requires a breakdown of usage by year published; therefore, omit for all other reports)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("PubYr", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string PubYr { get; set; }
        
        /// <summary>
        /// <para>Year of publication when represented as a range of years -- beginning year in the range (This is currently ONLY used by Journal Report 5 which requires a breakdown of usage by year published; therefore, omit for all other reports)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("PubYrFrom", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string PubYrFrom { get; set; }
        
        /// <summary>
        /// <para>Year of publication when represented as a range of years -- ending year in the range. (This is currently ONLY used by Journal Report 5 which requires a breakdown of usage by year published; therefore, omit for all other reports)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("PubYrTo", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="gYear")]
        public string PubYrTo { get; set; }
    }
    
    /// <summary>
    /// <para>The time period (representing a month) for the the usage.</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("DateRange", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DateRange
    {
        
        /// <summary>
        /// <para>Use the first day of the month.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Begin", Namespace="http://www.niso.org/schemas/counter", DataType="date")]
        public System.DateTime Begin { get; set; }
        
        /// <summary>
        /// <para>Use the last day of the month.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("End", Namespace="http://www.niso.org/schemas/counter", DataType="date")]
        public System.DateTime End { get; set; }
    }
    
    /// <summary>
    /// <para>
    ///Category as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("Category", Namespace="http://www.niso.org/schemas/counter")]
    public enum Category
    {
        
        /// <summary>
        /// </summary>
        Requests,
        
        /// <summary>
        /// </summary>
        Searches,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("Access_denied")]
        Access_Denied,
    }
    
    /// <summary>
    /// <para>UNUSED</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("PerformanceCounter", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PerformanceCounter
    {
        
        /// <summary>
        /// <para>E.G.,  ft_html, ft_pdf, ft_total, other. See http://www.niso.org/workrooms/sushi/values/#MetricType for list of registered values.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("MetricType", Namespace="http://www.niso.org/schemas/counter")]
        public MetricType MetricType { get; set; }
        
        /// <summary>
        /// <para>Integer value for the perfomance counter type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Count", Namespace="http://www.niso.org/schemas/counter", DataType="nonNegativeInteger")]
        public string Count { get; set; }
    }
    
    /// <summary>
    /// <para>
    ///MetricType as defined at http://www.niso.org/workrooms/sushi/values/
    ///</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("MetricType", Namespace="http://www.niso.org/schemas/counter")]
    public enum MetricType
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_ps")]
        Ft_Ps,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_ps_mobile")]
        Ft_Ps_Mobile,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_pdf")]
        Ft_Pdf,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_pdf_mobile")]
        Ft_Pdf_Mobile,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_html")]
        Ft_Html,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_html_mobile")]
        Ft_Html_Mobile,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_epub")]
        Ft_Epub,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("ft_total")]
        Ft_Total,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("sectioned_html")]
        Sectioned_Html,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("toc")]
        Toc,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("abstract")]
        Abstract,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("reference")]
        Reference,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("data_set")]
        Data_Set,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("audio")]
        Audio,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("video")]
        Video,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("image")]
        Image,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("podcast")]
        Podcast,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("multimedia")]
        Multimedia,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("record_view")]
        Record_View,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("result_click")]
        Result_Click,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("search_reg")]
        Search_Reg,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("search_fed")]
        Search_Fed,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("turnaway")]
        Turnaway,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("no_license")]
        No_License,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("other")]
        Other,
    }
    
    /// <summary>
    /// <para>(UNUSED)This is included to allow reference to the customer's IP Addresses if used to define the "customer".</para>
    /// </summary>
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("IPAddress", Namespace="http://www.niso.org/schemas/counter")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IPAddress
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute(DataType="string")]
        public string Value { get; set; }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public IPAddressType Type { get; set; }
    }
    
    [System.SerializableAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "0.5.5559.28274")]
    [System.Xml.Serialization.XmlTypeAttribute("IPAddressType", Namespace="http://www.niso.org/schemas/counter")]
    public enum IPAddressType
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("single")]
        Single,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("range")]
        Range,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("wildcard")]
        Wildcard,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("subnet")]
        Subnet,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("cidr")]
        Cidr,
    }
}

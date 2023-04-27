namespace BilllingSystemPoc.Models
{
    public class Company
    {
        public List<Customer> Customers { get;set; }
        public List<Project> Projects { get;set; }
      
    }

    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }

        public List<Project> projects { get; set; }
    }

    public class Project
    {
        public int ProjectId { get; set; }
        public BillingMode BillingMode { get; set; }
        public string Description { get; set; }
        public List<MileStone> MileStones { get; set; }
        public List<InvoiceModel> InvoiceModel { get; set; }
        public Customer customer{ get; set; }
    }
    public class BillingMode
    {
        public int Id { get; set; }
        public bool HourBasisType { get; set; }
        public bool MileStonebasis { get; set; }

    }

    public class Invoices
    {
        public int Id { get; set; }
    }

    public class MileStone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BillingAmount { get; set; }
    }


    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public string InVoiceDescription { get; set; }
        public int InvoiceStatus { get; set; }
        //credit = 0 and debit =1
        public bool InvoiceType { get; set; }
        public int InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}

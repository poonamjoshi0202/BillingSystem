namespace BilllingSystemPoc.Models
{
    public class BillingInvoiceModel
    {
        public int InvoiceId { get; set; }
        public string InVoiceDescription { get; set; }
        public int InvoiceStatus { get; set; }
        public int InvoiceType { get; set; }
        public int InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}

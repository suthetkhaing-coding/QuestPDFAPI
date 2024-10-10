namespace QuestPDFAPI.Models;

public class PharmacyReportInfoModel
{
    public int Id { get; set; }
    public string CustomerName { get; set; }
    public DateTime TransactonDate { get; set; }
    public string CustomerId { get; set; }
    public double AmountDue { get; set; }
    public double AmountPaid { get; set; }
    public double OutstandingAmount { get; set; }
}

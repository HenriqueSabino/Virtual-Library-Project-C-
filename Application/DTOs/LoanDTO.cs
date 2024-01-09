public class LoanDTO
{
    public int LoanId { get; set; }
    public int BookId { get; set; }
    public int StudentId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public DateTime DueDate { get; set; }
    public string Status { get; set; }
}
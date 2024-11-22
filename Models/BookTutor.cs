namespace GibJohnTutoring.Models
{
    public class BookTutor
    {
        public int Id { get; set; }
        public string? TutorName { get; set; }
        public TimeOnly? Time { get; set; }
        public DateTime? Date { get; set; }
        public Boolean? @bool { get; set; }

    }
}

namespace WebApplication5.Data.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime RemindAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

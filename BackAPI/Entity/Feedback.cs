namespace BackAPI.Entity
{
    public class Feedback
    {
        public Feedback() { }
        public Guid FeedbackId { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public DateTime RatingTime { get; set; }
        public string Text { get; set; }
        public string Header { get; set; }
    }
}

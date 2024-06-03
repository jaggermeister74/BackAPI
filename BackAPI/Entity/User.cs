namespace BackAPI.Entity
{
    public class User
    {
        public User()
        {
            Orders = [];
            Feedbacks = [];
        }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}

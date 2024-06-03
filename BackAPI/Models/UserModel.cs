namespace BackAPI.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string Password { get; set; }
    }
}

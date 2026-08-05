namespace JwtAuthenticationApi.Models
{
    public class UserRole
    {

        // UserId = Foreing Key from User Table
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
    }
}

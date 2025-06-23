namespace PortfolioManager.Api.DTOs.User
{
    public class RegisterUserDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNo { get; set; }
    }
}

namespace ORDERFOOD.Domian.Request.User
{
    public class UpdateUserRequest
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Password { get; set; }
    }
}

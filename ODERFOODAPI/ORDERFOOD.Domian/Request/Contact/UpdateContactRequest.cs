namespace ORDERFOOD.Domian.Request.Contact
{
    public class UpdateContactRequest
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Evaluate { get; set; }
        public string Description { get; set; }
    }
}

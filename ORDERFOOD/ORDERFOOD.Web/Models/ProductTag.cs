namespace ORDERFOOD.Web.Models
{
    public class ProductTag
    {
        public int FoodId { get; set; }
        public int TagId { get; set; }
        public Food Food { get; set; }
        public Tag Tag { get; set; }
    }
}

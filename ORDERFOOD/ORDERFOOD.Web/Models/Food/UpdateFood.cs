namespace ORDERFOOD.Web.Models
{
    public class UpdateFood
    {
        public int FoodId { get; set; }
        public string ShortContent { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}

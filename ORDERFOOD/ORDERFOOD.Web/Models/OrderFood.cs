using System.Collections.Generic;

namespace ORDERFOOD.Web.Models
{
    public class OrderFood
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string CustomerName { get; set; }
        public int PhoneNumber { get; set; }

        public string Address { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Person { get; set; }
        public bool Isdeleted { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductTag> ProductTags { get; set; } = new List<ProductTag>();

    }
}

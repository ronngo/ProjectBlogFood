using System.Collections.Generic;

namespace ORDERFOOD.Web.Models
{
    public class Food
    {

        public int Id { get; set; }
        public string ShortContent { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }

        public bool Isdeleted { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<ProductTag> ProductTags { get; set; } = new List<ProductTag>();



    }
}



using System.Collections.Generic;

namespace ORDERFOOD.Web.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ProductTag> ProductTags { get; set; }
    }
}

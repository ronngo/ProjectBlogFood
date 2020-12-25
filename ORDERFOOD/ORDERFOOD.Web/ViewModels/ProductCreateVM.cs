using Microsoft.AspNetCore.Mvc.Rendering;
using ORDERFOOD.Web.Models;
using System.Collections.Generic;

namespace ORDERFOOD.Web.ViewModels
{
    public class ProductCreateVM
    {
        public Food Food { get; set; }
        public OrderFood OrderFood { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> TagSelectList { get; set; }
        public IEnumerable<int> SelectListTagIds { get; set; }

    }
}

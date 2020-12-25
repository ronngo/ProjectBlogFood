using ORDERFOOD.Web.Models;
using System.Collections.Generic;

namespace ORDERFOOD.Web.ViewModels
{
    public class HomeIndexVM
    {
        public List<Food> Foods { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ORDERFOOD.Web.Models
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Tên Thể Loại")]
        [Required(ErrorMessage = "Tên thể loại không được bỏ trống")]
        [MinLength(3, ErrorMessage = "Tên thể loại tối thiểu phải có 3 ký tự")]
        public string CategoryName { get; set; }

        [DisplayName("Mô tả thể loại")]
        public bool IsDeleted { get; set; }
        public List<Food> Foods { get; set; }
        public List<OrderFood> OrderFoods { get; set; }
    }
}

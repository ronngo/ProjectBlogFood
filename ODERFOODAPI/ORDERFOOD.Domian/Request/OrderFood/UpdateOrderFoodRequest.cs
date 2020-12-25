﻿namespace ORDERFOOD.Domian.Request.OrderFood
{
    public class UpdateOrderFoodRequest
    {
        public int OrderFoodId { get; set; }
        public string FoodName { get; set; }
        public string CustomerName { get; set; }
        public int PhoneNumber { get; set; }

        public string Address { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Person { get; set; }
    }
}

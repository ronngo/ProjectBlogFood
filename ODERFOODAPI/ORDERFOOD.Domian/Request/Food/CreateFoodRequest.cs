﻿namespace ORDERFOOD.Domian.Request.Food
{
    public class CreateFoodRequest
    {
        public string ShortContent { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}

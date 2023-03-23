﻿namespace WebApp.Models.Request.Shoping
{
    public class ProductRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }
    }
}
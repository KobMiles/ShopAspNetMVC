﻿namespace _20250118_ShopAspNetMvc.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Product>? Products { get; set; } = null!;
    }
}

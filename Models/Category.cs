using System.ComponentModel.DataAnnotations;
using Day5_NguyenKhacQuan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day5_NguyenKhacQuan.Models
{
    public class Category : Controller
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Category name is required.")]
        public string? CategoryName { get; set; }
        // Navigation property for related products
        public ICollection<Product>? Products { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Day5_NguyenKhacQuan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day5_NguyenKhacQuan.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Phai nhap ten san pham")]
        [StringLength(100)]
        public string? ProductName { get; set; }
        [Range(0.01, 100000, ErrorMessage = "Gia phai lon hon 0")]
        public decimal ProductPrice { get; set; }
        // Foreign key property
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        // Navigation property for related category
        public Category? Category { get; set; }

    }
}
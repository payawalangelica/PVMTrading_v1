﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace PVMTrading_v1.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Input the Name of the Product.")]
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Input the Serial Number of the Product.")]
        public int SerialNumber { get; set; }
        [Required(ErrorMessage = "Input the Model of the Product.")]
        public string Model { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public bool IsReturned { get; set; }

        [Required(ErrorMessage = "Input the Price of the Product.")]
        [DataType(DataType.Currency)]
        public double OriginalPrice { get; set; }
        //   public int LastChangeByEmployeeId { get; set; }
        [Required(ErrorMessage = "Input the Barcode of the Product.")]
        public int Barcode { get; set; }
        //   public int WarrantyId { get; set; }
        //   public int CreatedByEmployeeId { get; set; }

        public Brand Brand { get; set; }
        [Required(ErrorMessage = "Choose the Brand Name.")]
        public int BrandId { get; set; }
        
        public ProductCategory ProductCategory { get; set; }
        [Required(ErrorMessage = "Choose the Category of the Product.")]
        public int ProductCategoryId { get; set; }

        public ProductCondition ProductCondition { get; set; }
        [Required(ErrorMessage = "Choose the Condition of the Product.")]
        public int ProductConditionId { get; set; }

        public Branch Branch { get; set; }
        [Required(ErrorMessage = "Choose the Brach Name of the Product.")]
        public int BranchId { get; set; }

        [Required]
        public int Quantity { get; set; }
        //public blob Photo { get; set; }
    }
}
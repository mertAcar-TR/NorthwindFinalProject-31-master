﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    //DTO da join gibi işlemler yapılır.Açılımı Data Transformation Object
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string  CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}

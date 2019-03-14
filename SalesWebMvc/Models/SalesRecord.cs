﻿using SalesWebMvc.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
   public class SalesRecord
   {
      public int Id { get; set; }

      [DisplayFormat(DataFormatString = "{0:dd//MM/yyyy}")]
      public DateTime Date { get; set; }
      [DisplayFormat(DataFormatString = "{0:F2}")]
      public double Amount { get; set; }
      public SalesStatus Status { get; set; }
      public Seller Seller { get; set; }
      // public Department Department { get; set; }

      public SalesRecord() { }

      public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller seller)
      {
         Id = id;
         Date = date;
         Amount = amount;
         Status = status;
         Seller = seller;
      }
   }
}

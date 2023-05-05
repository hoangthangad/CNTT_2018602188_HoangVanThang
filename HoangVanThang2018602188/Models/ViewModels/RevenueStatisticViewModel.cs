using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoangVanThang2018602188.Models.ViewModels
{
    public class RevenueStatisticViewModel
    {
        public DateTime Date { get; set; }
        public decimal Benefit { get; set; }//lợi nhuân
        public decimal Revenues { get; set; }// tổng giá bán
    }
}
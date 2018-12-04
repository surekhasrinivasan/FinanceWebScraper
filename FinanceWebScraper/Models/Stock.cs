﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceWebScraper.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Change { get; set; }
        public decimal PercentChange { get; set; }
        public string Currency { get; set; }
        public DateTime MarketTime { get; set; }
        public decimal MarketCap { get; set; }
    }
}

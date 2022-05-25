using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CouncilWise
{
    internal class ReceiptItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        [JsonIgnore]
        public bool IncludesTax { get; set; }
        [JsonIgnore]
        public decimal TaxAmount { get;  set; }
        public decimal TotalIncTax { get; set; }
       
    }
}

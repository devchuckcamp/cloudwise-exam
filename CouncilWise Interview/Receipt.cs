using System;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        [JsonPropertyName("GST")]
        public decimal TaxTotal { get; set; }
    }
}

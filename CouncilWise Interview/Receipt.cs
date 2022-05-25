using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace CouncilWise
{
    internal class Receipt
    {
        public ICollection<ReceiptItem> Items { get; set; }
        public decimal Total { get; set; }
        public decimal TaxTotal { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace ConsoleApp14.Model
{
    public class ProductList
    {
        [JsonProperty("products")]
        public List<Product> Products { get; set; }
    }
}

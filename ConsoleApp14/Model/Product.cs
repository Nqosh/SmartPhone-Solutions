using Newtonsoft.Json;

namespace ConsoleApp14.Model
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("discountPercentage")]
        public decimal DiscountPercentage { get; set; }

        [JsonProperty("rating")]
        public decimal Rating { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }
}

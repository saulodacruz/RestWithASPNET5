using System;
using System.Text.Json.Serialization;

namespace RestWithASPNET.Data.VO
{
    public class BookVO
    {
        [JsonPropertyName("id-book")]
        public long Id { get; set; }

        public string Author { get; set; }

        public DateTime LaunchDate { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }
    }
}

using System.Net.Cache;

namespace Tesla.Models
{
    public class Bil
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Bil ()
        {

        }

        public Bil (string model, double price, string description)
        {
            Model = model;
            Price = price;
            Description = description;

        }

        public override string ToString()
        {
            return $"{{}}";
        }
    }
}

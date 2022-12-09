using System.Net.Cache;

namespace Tesla.Models
{
    public class Bil
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int CarAge { get; set; }
        public Bil ()
        {

        }

        public Bil (string model, double price, string description, int carage)
        {
            Model = model;
            Price = price;
            Description = description;
            CarAge = carage;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}

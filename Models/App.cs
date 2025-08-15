

using _15lab.extencions;
using _15lab.extensions;
using _15lab.Structs;

namespace _15lab.Models
{
    internal abstract class App
    {
        private static int _id = 0;
        private string _name;

        public int ID { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value.ToUpperWords(); }

        }
        public AppCategory Category { get; set; }
        public Double Price { get; set; }
        public AppRating rating { get; set; }

        public App (string _name, AppCategory category, double price, AppRating rating)
        {
           ID = ++_id;
            Name = _name;
            Category = category;
            Price = price;
            this.rating = rating;
        }
        public abstract void DisplayInfo();
    }


}

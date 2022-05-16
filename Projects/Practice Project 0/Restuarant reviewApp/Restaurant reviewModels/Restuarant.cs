using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_reviewModels
{
    public class Restuarant
    {
        public string Name { get; set; }
        public string Add { get; set; }
        public string Address { get; set; }
        private int _Rating;
        public int AverageRating
        {
            get
            {
                return _Rating;
            }
            set
            {
                if (value > 0)
                    _Rating = value;
                else
                    throw new Exception("You cannot have a rating lower than 0.");
            }
        }

        public void Restaurant()
        {
            Name = "Reema Deli";
            Address = "1370 Afton St, Houston77055";
            AverageRating = 0;

        }
    }
}
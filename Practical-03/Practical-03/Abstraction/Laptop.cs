using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_03.Abstraction
{
    internal class Laptop
    {
        private string brand;
        private string model;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        /// <summary>
        /// Print the details of laptop brand and model
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }

        /// <summary>
        /// This is private method, so it can not be access outside the class
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }


    }
}

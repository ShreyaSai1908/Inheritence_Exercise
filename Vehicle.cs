using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Inheritence_Exercise
{
    class Vehicle
    {

        public Vehicle()
        {
            Console.WriteLine("Constructor of Vehicle Class");
        }

        public void Drive()
        {
            Console.WriteLine("Drive method is in Vehicle Class");
        }

        private string vehicleName;
        private string modelName;
        private int modelYear;
        
        public string VehicleName
        {
            get
            {
                return vehicleName;
            }
            set
            {
                vehicleName = value;
            }
        }
        
        public string ModelName
        {
            get
            {
                return modelName;
            }
            set
            {
                modelName = value;
            }
        }

        public int ModelYear
        {
            get
            {
                return modelYear;
            }
            set
            {
                modelYear = value;
            }
        }      
        
    }
}

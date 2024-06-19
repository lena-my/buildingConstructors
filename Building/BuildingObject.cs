using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Building
{
    public class BuildingObject
    {
        private int NumberOfFloors; // output
        private int Heigth; // input
        private const int HEIGTH_FLOOR = 3; // standart floor heigth

        public BuildingObject(int heigth)
        {
            Heigth = heigth;
        }


        public int GetFloorMaxSize(int heigth) //get the maximum heigth 
        {
            GetFloorCount(heigth);
            int maxHeigth = NumberOfFloors * HEIGTH_FLOOR; // maximum heigth
            return maxHeigth;
        }

        public int GetFloorCount(int heigth) // get the maximum number of floors given a heigth
        {
            NumberOfFloors = heigth / HEIGTH_FLOOR; // maximum number of floors according to the given heigth
            return NumberOfFloors;
        }

        // getters and setters
        public int GetHeigth()
        {
            return Heigth;
        }

        public void SetHeigth(int heigth)
        {
            Heigth = heigth;
        }

        public int GetNumberOfFloors()
        {
            return NumberOfFloors;
        }

        public void SetNumberOfFloors(int numberOfFloors)
        {
            NumberOfFloors = numberOfFloors;
        }
    }
}
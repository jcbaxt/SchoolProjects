//Grading ID: N9350
//Course: 199-75
//Program 4
//Due April 23rd
//creates, stores, and displays package object information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class GroundPackage
    {
        private int oZip;        //zipcode of origin       00000-99999
        private int dZip;        //zipcode of destiniation 00000-99999
        private double length;   //length of package       greater than 1
        private double width;    //width of package        greater than 1
        private double height;   //height of package       greater than 1
        private double weight;   //weight of package       greater than 1
        


        //ground package constructor with 6 parameters 
        public GroundPackage(int originZip, int destZip, double length, double width, double height, double weight)
        {
            OriginZip = originZip;    //sets OriginZip
            DestinationZip = destZip; //sets DestinationZip
            Length = length;          //sets Length
            Width = width;            //sets Width
            Height = height;          //sets Height
            Weight = weight;          //sets Weight

        }
        public int OriginZip
        {
            //pre-condition: none
            //post-condition: origin zip has returned
            get
            {
                return oZip;
            }
            set
            {
                //pre-condition: 00000 < value <= 99999
                //post-condition: OriginZip set to specified value
                if (value <= 99999 && value > 00000)
                {
                    oZip = value;
                }
                else
                {
                    oZip = 40202; //invalid entries return 40202
                }
            }
        }
        public int DestinationZip
        {
            //pre-condition: none
            //post-condition: destination zip has returned
            get
            {
                return dZip;
            }
            set
            {
                //pre-condition: 00000 < value < 99999
                //post-condition: DestinationZip has been set to specified value
                if (value <= 99999 && value > 00000)
                {
                    dZip = value;
                }
                else
                {
                    dZip = 90210;//invalid entry returns 90210
                }
            }
        }
        public double Length
        {
            //precondition: none
            //postcondition: length returned
            get
            {
                return length;
            }
            set
            {
                //precondition: value > 0
                //postcondition: Lenght is set
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    length = 1.0;//invalid entry returns 1
                }
            }
        }
        public double Width
        {
            //precondition: none
            //postcondition: Width is returned
            get
            {
                return width;
            }
            set
            {
                //precondition: value > 0
                //postcondition: Width is set
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    width = 1.0;//invalid entry returns 1
                }
            }
        }
        public double Height
        {
            //precondition: none
            //postcondition: height is returned
            get
            {
                return height; 
            }
            set
            {
                //precondition: value > 0
                //postcondition: height is set 
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    height = 1.0;//invalid entry returns 1
                }
            }
        }
        public double Weight
        {
            //precondition: none
            //postcondition: weight is returned
            get
            {
                return weight;
            }
            set
            {
                //precondition: value > 0
                //postcondition: weight is set
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    weight = 1.0;//invalid entry returns 1
                }
            }
        }
        public int ZoneDistance
        {
            //precondition: none
            //postcondition: Zone distance is calculated and stored
            get
            {
                return Math.Abs(oZip / 10000 - (dZip / 10000));
            }
        }

        //pre-condition: none
        //post-condition: cost calculated and stored based object data 
        public double CalcCost() //method that calcualtes cost of shipping package
        {
            double cost; // calculated cost of shipping
            const double SIZE_FACTOR = .25;
            const double WEIGHT_FACTOR = .45;

            cost = SIZE_FACTOR * (Length * Width * Height) + (WEIGHT_FACTOR * (ZoneDistance + 1) * Weight);
            return cost;
        }
        //pre-condition: None
        //Post-condition: object data stored as string.
        public override string ToString()
        {
            string result;
            double cost; // stores cost data for use in string
            cost = CalcCost();

            result = $"Origin Zip: {OriginZip}" + Environment.NewLine + $"Destination Zip: {DestinationZip}" + Environment.NewLine + $"Length:{Length}" + Environment.NewLine + $"Width: {Width}" + Environment.NewLine + $"Height: {Height}" + Environment.NewLine + $"Weight: {Weight}" + Environment.NewLine + $"Zone Distance: {ZoneDistance}" + Environment.NewLine + $"Cost: {cost:C}" + Environment.NewLine + $"*********************" + Environment.NewLine;
              
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Program_4
{
    class Program
    {
        static public void Main(string[] args)
        {
            int[] zip = { 42431, 86423, 91245, 47832, 46328 };  //stores origin zip test data
            int[] zip2 = { 54126, 32145, 75236, 86523, 96521 }; //stores destination zip test data
            double[] length = { 5.5, 2, 6.9, 10, 9.8 };         //length test data
            double[] width = { 15.2, 14.1, 3.9, 5.9, 6.4 };     //width test data
            double[] height = { 8.6, 3.2, 4.6, 8.6, 3.5 };      //height test data
            double[] weight = { 23, 18, 6, 8, 4 };              //weight test data
            

            GroundPackage package1 = new GroundPackage(zip[0], zip2[0], length[0], width[0], height[0], weight[0]);//creating each object based on array data
            GroundPackage package2 = new GroundPackage(zip[1], zip2[1], length[1], width[1], height[1], weight[1]);
            GroundPackage package3 = new GroundPackage(zip[2], zip2[2], length[2], width[2], height[2], weight[2]);
            GroundPackage package4 = new GroundPackage(zip[3], zip2[3], length[3], width[3], height[3], weight[3]);
            GroundPackage package5 = new GroundPackage(zip[4], zip2[4], length[4], width[4], height[4], weight[4]);

            GroundPackage[] package = new GroundPackage[5]; //array for storing each object

            package[0] = package1; //stores each object into the array
            package[1] = package2;
            package[2] = package3;
            package[3] = package4;
            package[4] = package5;

            DisplayPackages();

            package1.Length = 20;
            package2.Weight = 80;
            package3.Height = 9.9;
            package4.Length = -5;               //invalid data to test validation rules
            package5.DestinationZip = 15151515; //invalid to test validation

            package[0] = package1;//stores each object into the array
            package[1] = package2;
            package[2] = package3;
            package[3] = package4;
            package[4] = package5;

            DisplayPackages();





            void DisplayPackages() //method for displaying all package data
            {
                for (int i = 0; i < 5; ++i)
                {
                    Console.Write(package[i]);
                }
            }
        }
        
    }
   
}

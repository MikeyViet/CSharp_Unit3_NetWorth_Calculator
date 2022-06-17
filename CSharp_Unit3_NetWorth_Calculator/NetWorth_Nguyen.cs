/***************************************************************************
 * Assignment#: 3
 * Name:        The Faces of C# 1
 * Date:        06/12/2022
 * Class:       COSC-1430 C#
 * Student:     Michael Nguyen
 * Professor:   Nicholas Osemeke
 * 
 * Description: The program will calculate a person's networth from user
 *              input. The program will prompt user to input Assets and 
 *              liabilites and store each of them in a separate list. The
 *              networth will be calculated by subtracting total liabilities
 *              from total assets. Network will be displayed on screen.
 ****************************************************************************/

using System;
using System.Linq;
using System.Collections.Generic;

namespace Networth
{
    class NetWorth_Nguyen
    {
        public class Liabilities
        {
            private string name;
            private decimal liability;
            static private decimal totalLiabilities;

            public string Name { get; set; }

            //we could also write below
            //public decimal Liability {get; set;} --- this is auto-implemented property
            public decimal Liability
            {
                get
                {
                    return liability;
                }
                set
                {
                    liability = value;
                }
            }

            public static decimal TotalLiabilities { get { return totalLiabilities; } }
            public static void sumLiability(decimal total_L)
            {
                totalLiabilities += total_L; 
            }
              


        }

        public class Assets
        {
            private string name;
            private decimal asset;
            static private decimal totalAssets;

            public string Name { get; set; }

            //we could also write below
            //public decimal Asset {get; set;} --- this is auto-implemented property
            public decimal Asset
            {
                get
                {
                    return asset; 
                }
                set
                {
                    asset = value;
                }
            }
        }

        static void Main(string[] args)
        {
            int countLiabilities = 0;

            //create list of objects for liabilities and assets
            List<Assets> assets = new List<Assets>();   
            List<Liabilities> liabilities = new List<Liabilities>();

            Console.Write("Please enter the number of liabilities: ");
            countLiabilities = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < countLiabilities; i++)
            {

                liabilities.Add(new Liabilities());
            }

            for (int i = 0; i < countLiabilities; i++)
            {
                Console.Write($"Please enter name of Liability #{i+1}: ");
                liabilities[i].Name = Console.ReadLine();
            }

            for (int i = 0; i < countLiabilities; i++)
            {
                Console.WriteLine($"Name of Liability #{i + 1} is {liabilities[i].Name} "); 
            }


        }
    }
}

/*
 * 
 *         {
            //variable definitions
            int maxAssets = 0;
            int maxLiabilities = 0;
            int age = 0;
            double salary = 0;
            double assetsInput = 0;
            double liabilitiesInput = 0;
            double totalAssets = 0;
            double totalLiabilities = 0;
            double targetNetWorth = 0;
            
            //create lists for assets and liabilities
            List<double> assets = new List<double>();
            List<double> liabilities = new List<double>();

            //prompt for user input
            Console.Write("Please enter your salary: ");    //get salary for target networth
            salary = double.Parse(Console.ReadLine());

            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            targetNetWorth = age * salary * .10;    //formula for target networth

            Console.Write("Please enter the number of assets you have: ");
            maxAssets = int.Parse(Console.ReadLine());

            for (int i = 0; i < maxAssets; i++)
            {
                Console.Write($"Please enter in asset #{i + 1}: ");
                assetsInput = double.Parse(Console.ReadLine());
                assets.Add(assetsInput);    //add asset to list
                totalAssets += assetsInput;
            }

            Console.Write("Please enter the number of liabilites you have: ");
            maxLiabilities = int.Parse(Console.ReadLine());

            for(int i = 0; i < maxLiabilities; i++)
            {
                Console.Write($"Please enter in liability #{i + 1}: ");
                liabilitiesInput = double.Parse(Console.ReadLine());
                liabilities.Add(liabilitiesInput); //add liability to list
                totalLiabilities += liabilitiesInput;
            }

            //sort list in descending order
            assets.Sort();
            assets.Reverse();

            liabilities.Sort();
            liabilities.Reverse();


            Console.WriteLine("\n");

            Console.WriteLine("You have the following assets: ");
            for(int i = 0; i < maxAssets; i++)
            {
                Console.WriteLine($"${assets[i]}");
            }
            Console.WriteLine($"Your total Assets is ${totalAssets}.");

            Console.WriteLine("\n");

            Console.WriteLine("You have the following liabilities: ");
            for (int i = 0; i < maxLiabilities; i++)
            {
                Console.WriteLine($"${liabilities[i]}");
            }
            Console.WriteLine($"Your total Liabilites is ${totalLiabilities}.");

            Console.WriteLine("\n");

            Console.WriteLine($"Your target Net Worth is Salary:${salary} * {age} * 0.10 = ${targetNetWorth}.");
            Console.WriteLine($"Your Networth is: ${totalAssets - totalLiabilities}.");

            Console.WriteLine("\n");

            Console.WriteLine($"You are ${targetNetWorth - (totalAssets - totalLiabilities)} from reaching your target NetWorth of ${targetNetWorth}!");
        }
 */
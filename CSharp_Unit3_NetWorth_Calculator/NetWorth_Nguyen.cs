﻿/***************************************************************************
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

        static void Main(string[] args)
        {
            //variable definitions
            int maxAssets = 0;
            int maxLiabilities = 0;
            double assetsInput = 0;
            double liabilitiesInput = 0;
            double totalAssets = 0;
            double totalLiabilities = 0;
            
            //create lists for assets and liabilities
            List<double> assets = new List<double>();
            List<double> liabilities = new List<double>();

            //prompt for user input
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


            Console.WriteLine("\n");

            for(int i = 0; i < maxAssets; i++)
            {
                Console.WriteLine(assets[i]);
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Your Networth is: {totalAssets - totalLiabilities}.");

            Console.WriteLine("Hello, World!");
        }
    }
}


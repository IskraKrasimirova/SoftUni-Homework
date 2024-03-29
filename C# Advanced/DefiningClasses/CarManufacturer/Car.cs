﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity 
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption 
        { 
            get { return fuelConsumption; }
            set { fuelConsumption = value; } 
        }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.fuelConsumption = 10;
        }

        public Car(string make,string model, int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year,double fuelQuantity,double fuelConsumption)
            :this(make,model,year)
        {
            this.FuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }


        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine, Tire[] tires)
            :this(make,model,year,fuelQuantity,fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public  void Drive(double distance)
        {
            if (distance*FuelConsumption/100 > FuelQuantity)
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= distance * FuelConsumption / 100;
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            //sb.AppendLine($"Fuel: {this.FuelQuantity}L");
            sb.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            sb.AppendLine($"FuelQuantity: {this.FuelQuantity}");

            //return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";   

            return sb.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    class Vegetable
    {
        public Vegetable()
        {
        }

        public Vegetable(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;

        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }



        public double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return Name + " (" + Weight + "oz) :" + Quantity;
        }
    }
}

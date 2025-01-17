﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, colour, mileage;
            
            year = yearInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            Car newCar = new Car(year, make, colour, mileage);
            cars.Add(newCar);

            //for (int i = 0; i < cars.Count; i++)
            //{
            //    outputLabel.Text += $"{cars[i].year}\n{cars[i].make}\n{cars[i].colour}\n{cars[i].mileage}";
            //}

            DisplayCars();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    if (cars[i].make == makeInput.Text)
            //    {
            //        cars.RemoveAt[i];
            //    }
            //}

            foreach (Car c in cars)
            {
                if (c.make == makeInput.Text)
                {
                    cars.Remove(c);
                    break;
                }
            }
            
            DisplayCars();
        }

        private void DisplayCars()
        {
            outputLabel.Text = "";
            
            foreach (Car c in cars)
            {
                outputLabel.Text += $"{c.year} {c.make} {c.colour} {c.mileage}\n";
            }
        }
    }
}

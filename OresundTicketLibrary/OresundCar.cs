﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundTicketLibrary
{
    public class OresundCar : Car
    {
        public OresundCar() : base()
        {

        }

        public OresundCar(string licenseplate, DateTime date) : base(licenseplate, date)
        {

        }

        public override double Price()
        {
            double price = 410;

            if (Brobizz)
            {
                price = 161;
                return price;
            }

            return price;
        }

        public override string VehicleType()
        {
            string type = "Oresund car";
            return type;
        }


    }
}

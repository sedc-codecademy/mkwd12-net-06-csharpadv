﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager9000.Domain.Models
{
    public class Car : BaseEntity
    {
        public string Model { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public DateTime LicensePlateExpieryDate { get; set; }
        public List<Driver> AsignedDrivers { get; set; }  = new List<Driver>();


        public Car(string model, string licensePlate, DateTime licensePlateExpieryDate, List<Driver> asignedDrivers)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpieryDate = licensePlateExpieryDate;
            AsignedDrivers = asignedDrivers;
        }

        public override string GetInfo()
        {
            string drivers = string.Empty;
            foreach (Driver driver in AsignedDrivers)
            {
                drivers += $"{driver.Id}.) {driver.FirstName} {driver.LastName} \n";
            }
            return $"Car {Model} with plates {LicensePlate} that expire on {LicensePlateExpieryDate} is driven by: \n{drivers}";
        }
    }
}

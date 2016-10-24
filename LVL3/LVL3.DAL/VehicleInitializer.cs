﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LVL3.Model;

namespace LVL3.DAL
{
    public class VehicleInitializer : DropCreateDatabaseIfModelChanges<VehicleContext>
    {
        protected override void Seed(VehicleContext context)
        {
            var vehicleMakeList = new List<VehicleMake>
            {
                new VehicleMake {Name = "Audi", Abrv = "-" },
                new VehicleMake {Name = "Ferrari", Abrv = "-" }
            };

            var VehicleModelList = new List<VehicleModel>
            {
                new VehicleModel {Name = "A4", VehicleMakeId = 1, Abrv = "-" }
            };

            foreach (var make in vehicleMakeList)
            {
                context.VehicleMakes.Add(make);
            }

            foreach(var model in VehicleModelList)
            {
                context.VehicleModels.Add(model);
            }

            context.SaveChanges();
            base.Seed(context);
        }

    }
}

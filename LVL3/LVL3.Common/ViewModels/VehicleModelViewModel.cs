﻿using LVL3.Common.IViewModels;
using LVL3.Model;
using System;

namespace LVL3.Common.ViewModels
{
    public class VehicleModelViewModel : IVehicleModelViewModel
    {
        public Guid VehicleModelId { get; set; }
        public Guid VehicleMakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }
    }
}

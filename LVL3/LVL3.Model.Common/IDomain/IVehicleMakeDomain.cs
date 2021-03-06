﻿using System;
using System.Collections.Generic;

namespace LVL3.Model.Common.IDomain
{
    public interface IVehicleMakeDomain
    {
        Guid VehicleMakeId { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
        ICollection<IVehicleModelDomain> VehicleModel { get; set; }
    }
}

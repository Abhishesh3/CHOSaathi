using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewJssyDischargeInfoModel
{
    public string AsmanCode { get; set; } = null!;

    public string? DischargeTime { get; set; }

    public string? FoodService { get; set; }

    public string? FoodServiceDays { get; set; }

    public string? Btrans { get; set; }

    public string? BloodTransUnitts { get; set; }

    public string MotherAliveDischarge { get; set; } = null!;

    public string BabyKitProvide { get; set; } = null!;

    public string MotherCottageWard { get; set; } = null!;

    public string? BgName { get; set; }

    public string? DischargeTypeDate { get; set; }

    public string? DischargeTypeTime { get; set; }

    public string? VehicleName { get; set; }

    public string? PrivateVehNumber { get; set; }

    public string? PrivateVehOwner { get; set; }

    public double? PrivateVehKm { get; set; }
}

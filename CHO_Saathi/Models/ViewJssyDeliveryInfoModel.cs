using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class ViewJssyDeliveryInfoModel
{
    public string? TimeOfDelivery { get; set; }

    public string? DeliveryTime { get; set; }

    public string? TypeOfDelivery { get; set; }

    public string BirthDefectsItems { get; set; } = null!;

    public string? BirthDefectsItemDatas { get; set; }

    public string WeightOfBabyGm { get; set; } = null!;

    public string? PpiucdInserted { get; set; }

    public string DelAborConName { get; set; } = null!;

    public string? NoOfBirth { get; set; }

    public string? Sexofbaby { get; set; }

    public string? BirthType { get; set; }

    public DateTime? BreastFeedInitiatedTime { get; set; }

    public string? LastDeliveryDate { get; set; }

    public string? MothComp { get; set; }

    public string? BgName { get; set; }

    public string? Babyname { get; set; }
}

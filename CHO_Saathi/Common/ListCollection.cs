using CHO_Saathi.Models;
using System;
using System.Collections.Generic;

namespace DonorDashboard.Models;

public class Return
{
    public bool Status { get; set; }
}

public class ReturnToken
{
    public string? Token { get; set; }
}

public class GraphGroup
{
    public string? Label { get; set; }
    public int? Value { get; set; }
}


/*----------------gaurav sir start-------------------*/
public class GraphAttributemodel
{
    public int Value { get; set; }
    public string? label { get; set; }
}

public class StackedBarDataset
{
    public string? Label { get; set; }
    public List<double>? Data { get; set; }
    public string? BackgroundColor { get; set; }
    public string? BorderColor { get; set; }
    public string? TypeAxis { get; set; }
}

public class StackedBarChartViewModel
{
    public List<string>? Labels { get; set; }
    public List<StackedBarDataset>? Datasets { get; set; }
}

public class TableAlias
{
    public string? TableName { get; set; }
    public string? AliasName { get; set; }
}

public class GraphTableColumnList
{
    public string? ColumnName { get; set; }
    public string? ColumnDatatype { get; set; }
    public string? ColumnIcon { get; set; }
}
/*------------------------------------------------------*/
//public class ListCollection
//{
//    public List<MstformQuestion>? surveyformquestion { set; get; }
//    public List<Mstcommon>? surveymstcommon { set; get; }
//}

public class UserRights
{
    public int RoleId { get; set; }
    public int MenuID { get; set; }
    public string? MenuName { get; set; }
    public bool Permission { get; set; }
}

public class MenuCollection
{
    public List<MstMenu> MstMenu { get; set; }
    public List<RoleMenu> RoleMenu { get; set; }
}


public class UserInfo
{
    public int changeTypeId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    public IFormFile? ProfilePicture { get; set; }
}

public class ExistingIndicator
{
    public int templateId { get; set; }
    public string? IndiType { get; set; }
    public string? template { get; set; }
}
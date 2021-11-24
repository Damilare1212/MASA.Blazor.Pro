﻿namespace MASA.Blazor.Pro.Demo._1_Apps.ECommerce.Order.ViewModel;

public class AddressType
{
    public string Label { get; set; }
    public string Value { get; set; }

    public AddressType(string label, string value)
    {
        Label = label;
        Value = value;
    }
}

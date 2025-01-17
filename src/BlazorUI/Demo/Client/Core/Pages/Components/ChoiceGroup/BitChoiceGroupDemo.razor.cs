﻿using Bit.BlazorUI.Demo.Client.Core.Pages.Components.ComponentDemoBase;

namespace Bit.BlazorUI.Demo.Client.Core.Pages.Components.ChoiceGroup;

public partial class BitChoiceGroupDemo
{
    private readonly List<ComponentParameter> componentParameters = new()
    {
        new()
        {
            Name = "AriaLabelledBy",
            Type = "string",
            DefaultValue = "string.Empty",
            Description = "Id of an element to use as the aria label for the ChoiceGroup."
        },
        new()
        {
            Name = "AriaLabelField",
            Type = "string",
            DefaultValue = "AriaLabel",
            Description = "The name of the field from the model that will be enable item."
        },
        new()
        {
            Name = "AriaLabelFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            DefaultValue = "null",
            Description = "The name of the field from the model that will be enable item."
        },
        new()
        {
            Name = "ChildContent",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "The content of the ChoiceGroup, a list of BitChoiceGroupOption components."
        },
        new()
        {
            Name = "DefaultValue",
            Type = "string?",
            DefaultValue = "null",
            Description = "Default selected Value for ChoiceGroup."
        },
        new()
        {
            Name = "Items",
            Type = "IEnumerable<TItem>",
            DefaultValue = "new List<TItem>()",
            Description = "Sets the data source that populates the items of the list."
        },
        new()
        {
            Name = "ItemTemplate",
            Type = "RenderFragment<TItem>?",
            DefaultValue = "null",
            Description = "Used to customize the label for the Item content."
        },
        new()
        {
            Name = "ItemLabelTemplate",
            Type = "RenderFragment<TItem>?",
            Description = "Used to customize the label for the Item Label content."
        },
        new()
        {
            Name = "IsRequired",
            Type = "bool",
            DefaultValue = "false",
            Description = "If true, selecting an option is mandatory in the ChoiceGroup."
        },
        new()
        {
            Name = "IsEnabledField",
            Type = "string",
            DefaultValue = "IsEnabled",
            Description = "The name of the field from the model that will be enable item."
        },
        new()
        {
            Name = "IsEnabledFieldSelector",
            Type = "Expression<Func<TItem, bool>>?",
            DefaultValue = "null",
            Description = "The field from the model that will be enable item."
        },
        new()
        {
            Name = "IdField",
            Type = "string",
            DefaultValue = "Id",
            Description = "The name of the field from the model that will be the id."
        },
        new()
        {
            Name = "IdFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            DefaultValue = "null",
            Description = "The name of the field from the model that will be the id."
        },
        new()
        {
            Name = "IconNameField",
            Type = "string",
            DefaultValue = "IconName",
            Description = "The field from the model that will be the name of the icon."
        },
        new()
        {
            Name = "IconNameFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            DefaultValue = "null",
            Description = "The field selector from the model that will be the icon name."
        },
        new()
        {
            Name = "ImageSrcField",
            Type = "string",
            DefaultValue = "ImageSrc",
            Description = "The field from the model that will be the image src."
        },
        new()
        {
            Name = "ImageSrcFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            DefaultValue = "null",
            Description = "The field from the model that will be the image src."
        },
        new()
        {
            Name = "ImageAltField",
            Type = "string",
            DefaultValue = "ImageSrc",
            Description = "The field from the model that will be the image alternate text."
        },
        new()
        {
            Name = "ImageAltFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            DefaultValue = "null",
            Description = "The field from the model that will be the image alternate text."
        },
        new()
        {
            Name = "ImageSizeField",
            Type = "string",
            DefaultValue = "ImageSize",
            Description = "The name of the field from the model that will be the image alternate text."
        },
        new()
        {
            Name = "ImageSizeFieldSelector",
            Type = "Expression<Func<TItem, Size>>?",
            DefaultValue = "null",
            Description = "The name of the field from the model that will be the image alternate text."
        },
        new()
        {
            Name = "IsRtl",
            Type = "bool",
            DefaultValue = "false",
            Description = "Change direction to RTL."
        },
        new()
        {
            Name = "Label",
            Type = "string?",
            DefaultValue = "null",
            Description = "The label for the ChoiceGroup."
        },
        new()
        {
            Name = "LabelTemplate",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "Custom RenderFragment for the label of the ChoiceGroup."
        },
        new()
        {
            Name = "LayoutFlow",
            Type = "BitLayoutFlow?",
            DefaultValue = "null",
            Description = "The render flow of the items in the ChoiceGroup, Horizontal or Vertical."
        },
        new()
        {
            Name = "Name",
            Type = "string",
            DefaultValue = "Guid.NewGuid().ToString()",
            Description = "Name of the ChoiceGroup, this name is used to group each item into the same logical component."
        },
        new()
        {
            Name = "OnClick",
            Type = "EventCallback<MouseEventArgs>",
            Description = "Callback for when the option clicked.",
        },
        new()
        {
            Name = "OnChange",
            Type = "EventCallback<MouseEventArgs>",
            Description = "Callback for when the option has been changed.",
        },
        new()
        {
            Name = "SelectedImageSrcField",
            Type = "string",
            DefaultValue = "SelectedImageSrc",
            Description = "The field from the model that will be the selected image src."
        },
        new()
        {
            Name = "SelectedImageSrcFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            Description = "The field from the model that will be the selected image src."
        },
        new()
        {
            Name = "TextField",
            Type = "string",
            DefaultValue = "Text",
            Description = "The name of the field from the model that will be shown to the user."
        },
        new()
        {
            Name = "TextFieldSelector",
            Type = "Expression<Func<TItem, string>>?",
            Description = "The name of the field from the model that will be shown to the user."
        },
        new()
        {
            Name = "ValueField",
            Type = "string",
            DefaultValue = "Text",
            Description = "The field from the model that will be the underlying value."
        },
        new()
        {
            Name = "ValueFieldSelector",
            Type = "Expression<Func<TItem, TValue>>?",
            DefaultValue = "null",
            Description = "The field from the model that will be the underlying value."
        },
    };
    private readonly List<ComponentSubClass> componentSubClasses = new()
    {
        new()
        {
            Id = "choice-group-item",
            Title = "BitChoiceGroupItem",
            Parameters = new()
            {
               new()
               {
                   Name = "IconName",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "The icon to show as Option content.",
               },
               new()
               {
                   Name = "ImageSrc",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "The image address to show as Option content.",
               },
               new()
               {
                   Name = "ImageAlt",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Provides alternative information for the Option image.",
               },
               new()
               {
                   Name = "ImageSize",
                   Type = "Size?",
                   DefaultValue = "null",
                   Description = "Provides Height and Width for the Option image.",
               },
               new()
               {
                   Name = "Id",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Set attribute of Id for the GroupOption Option input.",
               },
               new()
               {
                   Name = "SelectedImageSrc",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Provides a new image for the selected Option in the Image-GroupOption.",
               },
               new()
               {
                   Name = "Text",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Text to show as content of GroupOption Option.",
               },
               new()
               {
                   Name = "Value",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "This value is returned when GroupOption Option is Clicked.",
               }
            }
        },
        new()
        {
            Id = "choice-group-option",
            Title = "BitChoiceGroupOption",
            Parameters = new()
            {
               new()
               {
                   Name = "IconName",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "The icon to show as Option content.",
               },
               new()
               {
                   Name = "ImageSrc",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "The image address to show as Option content.",
               },
               new()
               {
                   Name = "ImageAlt",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Provides alternative information for the Option image.",
               },
               new()
               {
                   Name = "ImageSize",
                   Type = "Size?",
                   DefaultValue = "null",
                   Description = "Provides Height and Width for the Option image.",
               },
               new()
               {
                   Name = "Id",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Set attribute of Id for the GroupOption Option input.",
               },
               new()
               {
                   Name = "SelectedImageSrc",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Provides a new image for the selected Option in the Image-GroupOption.",
               },
               new()
               {
                   Name = "Text",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Text to show as content of GroupOption Option.",
               },
               new()
               {
                   Name = "Value",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "This value is returned when GroupOption Option is Clicked.",
               }
            }
        }
    };



    private string ChoiceGroupOneWayValue = "A";
    private string ChoiceGroupTwoWayValue = "A";
    private string ChoiceGroupWithOptionTemplateValue = "Day";
    private string ChoiceGroupWithOptionLabelTemplateValue = "Day";
    private string ChoiceGroupLayoutFlowWithOptionTemplateValue = "Day";
    private string ChoiceGroupRtlLayoutFlowWithOptionTemplateValue = "Day";
    public ChoiceGroupValidationModel ValidationModel = new();
    public string SuccessMessage;

    private readonly List<BitChoiceGroupItem<string>> ChoiceGroupBasicItems = new()
    {
        new() { Text = "Item A", Value = "A" },
        new() { Text = "Item B", Value = "B" },
        new() { Text = "Item C", Value = "C" },
        new() { Text = "Item D", Value = "D" }
    };
    private readonly List<BitChoiceGroupItem<string>> ChoiceGroupDisabledItems = new()
    {
        new() { Text = "Item A", Value = "A" },
        new() { Text = "Item B", Value = "B" },
        new() { Text = "Item C", Value = "C", IsEnabled = false },
        new() { Text = "Item D", Value = "D" }
    };
    private readonly List<BitChoiceGroupItem<string>> ChoiceGroupImageItems = new()
    {
        new()
        {
            Text = "Bar",
            Value = "Bar",
            ImageSrc= "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png",
            SelectedImageSrc = "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png",
            ImageAlt = "alt for Bar image",
            ImageSize = new System.Drawing.Size(32, 32)
        },
        new()
        {
            Text = "Pie",
            Value = "Pie",
            ImageSrc= "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png",
            SelectedImageSrc = "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png",
            ImageAlt = "alt for Pie image",
            ImageSize = new System.Drawing.Size(32, 32)
        }
    };
    private readonly List<BitChoiceGroupItem<string>> ChoiceGroupIconItems = new()
    {
        new() { Text = "Day", Value = "Day", IconName = BitIconName.CalendarDay },
        new() { Text = "Week", Value = "Week", IconName = BitIconName.CalendarWeek },
        new() { Text = "Month", Value = "Month", IconName = BitIconName.Calendar, IsEnabled = false }
    };
    private readonly List<BitChoiceGroupItem<string>> ChoiceGroupItemsTemplate = new()
    {
        new() { Text = "Day", Value = "Day", IconName = BitIconName.CalendarDay },
        new() { Text = "Week", Value = "Week", IconName = BitIconName.CalendarWeek },
        new() { Text = "Month", Value = "Month", IconName = BitIconName.Calendar }
    };

    private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
    {
        new() { Name = "Custom A", ItemValue = "A" },
        new() { Name = "Custom B", ItemValue = "B" },
        new() { Name = "Custom C", ItemValue = "C" },
        new() { Name = "Custom D", ItemValue = "D" }
    };
    private readonly List<ChoiceModel> CustomChoiceGroupDisabledItems = new()
    {
        new() { Name = "Custom A", ItemValue = "A" },
        new() { Name = "Custom B", ItemValue = "B" },
        new() { Name = "Custom C", ItemValue = "C", IsEnabled = false },
        new() { Name = "Custom D", ItemValue = "D" }
    };
    private readonly List<ChoiceModel> CustomChoiceGroupImageItems = new()
    {
        new()
        {
            Name = "Bar",
            ItemValue = "Bar",
            ImageAddress = "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png",
            SelectedImageAddress = "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png",
            ImageDescription = "alt for Bar image",
            ImageSize = new System.Drawing.Size(32, 32)
        },
        new()
        {
            Name = "Pie",
            ItemValue = "Pie",
            ImageAddress= "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png",
            SelectedImageAddress = "https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png",
            ImageDescription = "alt for Pie image",
            ImageSize = new System.Drawing.Size(32, 32)
        }
    };
    private readonly List<ChoiceModel> CustomChoiceGroupIconItems = new()
    {
        new() { Name = "Day", ItemValue = "Day", IconName = BitIconName.CalendarDay },
        new() { Name = "Week", ItemValue = "Week", IconName = BitIconName.CalendarWeek },
        new() { Name = "Month", ItemValue = "Month", IconName = BitIconName.Calendar, IsEnabled = false }
    };
    private readonly List<ChoiceModel> CustomChoiceGroupItemsTemplate = new()
    {
        new() { Name = "Day", ItemValue = "Day", IconName = BitIconName.CalendarDay },
        new() { Name = "Week", ItemValue = "Week", IconName = BitIconName.CalendarWeek },
        new() { Name = "Month", ItemValue = "Month", IconName = BitIconName.Calendar }
    };

    private void HandleValidSubmit()
    {
        SuccessMessage = "Form Submitted Successfully!";
    }

    private void HandleInvalidSubmit()
    {
        SuccessMessage = string.Empty;
    }


    private readonly string example1BitChoiceGroupItemHtmlCode = @"
<BitChoiceGroup Label=""Pick one"" Items=""ChoiceGroupBasicItems"" DefaultValue=""@(""A"")"" />";
    private readonly string example1BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};";

    private readonly string example2BitChoiceGroupItemHtmlCode = @"
<BitChoiceGroup Label=""Disabled ChoiceGroup""
                Items=""ChoiceGroupBasicItems""
                IsEnabled=""false""
                DefaultValue=""@(""A"")"" />

<BitChoiceGroup Label=""ChoiceGroup with Disabled Option""
                Items=""ChoiceGroupDisabledItems""
                DefaultValue=""@(""A"")"" />";
    private readonly string example2BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupDisabledItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"", IsEnabled = false },
    new() { Text = ""Item D"", Value = ""D"" }
};";

    private readonly string example3BitChoiceGroupItemHtmlCode = @"
<BitChoiceGroup Label=""Pick one image"" Items=""ChoiceGroupImageItems"" DefaultValue=""@(""Bar"")"" />
<BitChoiceGroup Label=""Pick one icon"" Items=""ChoiceGroupIconItems"" DefaultValue=""@(""Day"")"" />";
    private readonly string example3BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupImageItems<string> = new()
{
    new BitChoiceGroupItem()
    {
        Text = ""Bar"",
        Value = ""Bar"",
        ImageSrc= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png"",
        SelectedImageSrc = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png"",
        ImageAlt = ""alt for Bar image"",
        ImageSize = new Size(32, 32)
    },
    new BitChoiceGroupItem()
    {
        Text = ""Pie"",
        Value = ""Pie"",
        ImageSrc= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png"",
        SelectedImageSrc = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png"",
        ImageAlt = ""alt for Pie image"",
        ImageSize = new Size(32, 32)
    }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupIconItems<string> = new()
{
    new() { Text = ""Day"", Value = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Text = ""Week"", Value = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Text = ""Month"", Value = ""Month"", IconName = BitIconName.Calendar, IsEnabled = false }
};";

    private readonly string example4BitChoiceGroupItemHtmlCode = @"
<style>
    .custom-label {
        font-weight: bold;
        color: $Red20;
    }
</style>

<BitChoiceGroup Items=""ChoiceGroupBasicItems"" DefaultValue=""@(""A"")"">
    <LabelTemplate>
        <div class=""custom-label"">
            Custom label <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
</BitChoiceGroup>";
    private readonly string example4BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};";

    private readonly string example5BitChoiceGroupItemHtmlCode = @"
<style>
    .custom-option {
        display: flex;
        align-items: center;
        gap: rem(10px);
        cursor: pointer;
    }

    .custom-option .option-pointer {
        width: rem(20px);
        height: rem(20px);
        border: 1px solid;
        border-radius: rem(10px);
    }

    .custom-option:hover .option-pointer {
        border-top: rem(5px) solid #C66;
        border-bottom: rem(5px) solid #6C6;
        border-left: rem(5px) solid #66C;
        border-right: rem(5px) solid #CC6;
    }

    .custom-option.selected-option {
        color: #C66;
    }

    .custom-option.selected-option .option-pointer {
        border-top: rem(10px) solid #C66;
        border-bottom: rem(10px) solid #6C6;
        border-left: rem(10px) solid #66C;
        border-right: rem(10px) solid #CC6;
    }
</style>

<BitChoiceGroup Label=""Option Template""
                Items=""ChoiceGroupItemsTemplate""
                @bind-Value=""ChoiceGroupWithOptionTemplateValue"">
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupWithOptionTemplateValue == option.Value ? ""selected-option"" : string.Empty)"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Label Template""
                Items=""ChoiceGroupItemsTemplate""
                @bind-Value=""ChoiceGroupWithOptionLabelTemplateValue"">
    <ItemLabelTemplate Context=""option"">
        <div style=""margin-left: 27px;"" class=""custom-option @(ChoiceGroupWithOptionLabelTemplateValue == option.Value ? ""selected-option"" : string.Empty)"">
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemLabelTemplate>
</BitChoiceGroup>";
    private readonly string example5BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupItemsTemplate<string> = new()
{
    new() { Text = ""Day"", Value = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Text = ""Week"", Value = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Text = ""Month"", Value = ""Month"", IconName = BitIconName.Calendar }
};

private string ChoiceGroupWithOptionTemplateValue = ""Day"";
private string ChoiceGroupWithOptionLabelTemplateValue = ""Day"";";

    private readonly string example6BitChoiceGroupItemHtmlCode = @"
<BitChoiceGroup Label=""One-way""
                Items=""ChoiceGroupBasicItems""
                Value=""@ChoiceGroupOneWayValue"" />
<BitTextField @bind-Value=""ChoiceGroupOneWayValue"" />

<BitChoiceGroup Label=""Two-way""
                Items=""ChoiceGroupBasicItems""
                @bind-Value=""ChoiceGroupTwoWayValue"" />
<BitTextField @bind-Value=""ChoiceGroupTwoWayValue"" />";
    private readonly string example6BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};

private string ChoiceGroupOneWayValue = ""A"";
private string ChoiceGroupTwoWayValue = ""A"";";

    private readonly string example7BitChoiceGroupItemHtmlCode = @"
<BitChoiceGroup Label=""Basic"" Items=""ChoiceGroupBasicItems"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" />
<BitChoiceGroup Label=""Disabled"" Items=""ChoiceGroupBasicItems"" IsEnabled=""false"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" />
<BitChoiceGroup Label=""Image"" Items=""ChoiceGroupImageItems"" DefaultValue=""@(""Bar"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" />
<BitChoiceGroup Label=""Icon"" Items=""ChoiceGroupIconItems"" DefaultValue=""@(""Day"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" />
<BitChoiceGroup Items=""ChoiceGroupBasicItems"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"">
    <LabelTemplate>
        <div class=""custom-label"">
            Label Template <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
</BitChoiceGroup>
<BitChoiceGroup Label=""Option Template"" @bind-Value=""@ChoiceGroupLayoutFlowWithOptionTemplateValue""
                Items=""ChoiceGroupItemsTemplate""
                LayoutFlow=""BitLayoutFlow.Horizontal"">
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupLayoutFlowWithOptionTemplateValue == option.Value ? ""selected-option"" : """")"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>";
    private readonly string example7BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupImageItems<string> = new()
{
    new BitChoiceGroupItem()
    {
        Text = ""Bar"",
        Value = ""Bar"",
        ImageSrc= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png"",
        SelectedImageSrc = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png"",
        ImageAlt = ""alt for Bar image"",
        ImageSize = new Size(32, 32)
    },
    new BitChoiceGroupItem()
    {
        Text = ""Pie"",
        Value = ""Pie"",
        ImageSrc= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png"",
        SelectedImageSrc = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png"",
        ImageAlt = ""alt for Pie image"",
        ImageSize = new Size(32, 32)
    }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupIconItems<string> = new()
{
    new() { Text = ""Day"", Value = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Text = ""Week"", Value = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Text = ""Month"", Value = ""Month"", IconName = BitIconName.Calendar, IsEnabled = false }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupItemsTemplate<string> = new()
{
    new() { Text = ""Day"", Value = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Text = ""Week"", Value = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Text = ""Month"", Value = ""Month"", IconName = BitIconName.Calendar }
};

private string ChoiceGroupLayoutFlowWithOptionTemplateValue = ""Day"";";

    private readonly string example8BitChoiceGroupItemHtmlCode = @"
<BitChoiceGroup Label=""Basic"" Items=""ChoiceGroupBasicItems"" DefaultValue=""@(""A"")"" IsRtl=""true"" />
<BitChoiceGroup Label=""Disabled"" Items=""ChoiceGroupBasicItems"" IsEnabled=""false"" DefaultValue=""@(""A"")"" IsRtl=""true"" />
<BitChoiceGroup Label=""Image"" Items=""ChoiceGroupImageItems"" DefaultValue=""@(""Bar"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" IsRtl=""true"" />
<BitChoiceGroup Label=""Icon"" Items=""ChoiceGroupIconItems"" DefaultValue=""@(""Day"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" IsRtl=""true"" />
<BitChoiceGroup Items=""ChoiceGroupBasicItems"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" IsRtl=""true"">
    <LabelTemplate>
        <div class=""custom-label"">
            Label Template <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
</BitChoiceGroup>
<BitChoiceGroup Label=""Option Template"" @bind-Value=""@ChoiceGroupRtlLayoutFlowWithOptionTemplateValue""
                Items=""ChoiceGroupItemsTemplate""
                LayoutFlow=""BitLayoutFlow.Horizontal""
                IsRtl=""true"">
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupRtlLayoutFlowWithOptionTemplateValue == option.Value ? ""selected-option"" : """")"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>";
    private readonly string example8BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupImageItems<string> = new()
{
    new BitChoiceGroupItem()
    {
        Text = ""Bar"",
        Value = ""Bar"",
        ImageSrc= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png"",
        SelectedImageSrc = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png"",
        ImageAlt = ""alt for Bar image"",
        ImageSize = new Size(32, 32)
    },
    new BitChoiceGroupItem()
    {
        Text = ""Pie"",
        Value = ""Pie"",
        ImageSrc= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png"",
        SelectedImageSrc = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png"",
        ImageAlt = ""alt for Pie image"",
        ImageSize = new Size(32, 32)
    }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupIconItems<string> = new()
{
    new() { Text = ""Day"", Value = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Text = ""Week"", Value = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Text = ""Month"", Value = ""Month"", IconName = BitIconName.Calendar, IsEnabled = false }
};

private readonly List<BitChoiceGroupItem> ChoiceGroupItemsTemplate<string> = new()
{
    new() { Text = ""Day"", Value = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Text = ""Week"", Value = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Text = ""Month"", Value = ""Month"", IconName = BitIconName.Calendar }
};

private string ChoiceGroupRtlLayoutFlowWithOptionTemplateValue = ""Day"";";

    private readonly string example9BitChoiceGroupItemHtmlCode = @"
@if (string.IsNullOrEmpty(SuccessMessage))
{
    <EditForm Model=""@ValidationModel"" OnValidSubmit=""@HandleValidSubmit"" OnInvalidSubmit=""@HandleInvalidSubmit"">
        <DataAnnotationsValidator />
        <div class=""validation-summary"">
            <ValidationSummary />
        </div>
        <div>
            <BitChoiceGroup Items=""ChoiceGroupBasicItems"" @bind-Value=""ValidationModel.Value"" />
            <ValidationMessage For=""@(() => ValidationModel.Value)"" />
        </div>
        <BitButton Style=""margin-top: 10px;"" ButtonType=""BitButtonType.Submit"">Submit</BitButton>
    </EditForm>
}
else
{
    <BitMessageBar MessageBarType=""BitMessageBarType.Success"" IsMultiline=""false"">
        @SuccessMessage
    </BitMessageBar>
}
<br />
<BitButton ButtonStyle=""BitButtonStyle.Standard"" OnClick=""() => { ValidationModel = new(); SuccessMessage=string.Empty; }"">Reset</BitButton>";
    private readonly string example9BitChoiceGroupItemCSharpCode = @"
private readonly List<BitChoiceGroupItem> ChoiceGroupBasicItems<string> = new()
{
    new() { Text = ""Item A"", Value = ""A"" },
    new() { Text = ""Item B"", Value = ""B"" },
    new() { Text = ""Item C"", Value = ""C"" },
    new() { Text = ""Item D"", Value = ""D"" }
};

public class ChoiceGroupValidationModel
{
    [Required(ErrorMessage = ""Pick one"")]
    public string Value { get; set; }
}

public ChoiceGroupValidationModel ValidationModel = new();
public string SuccessMessage;

private void HandleValidSubmit()
{
    SuccessMessage = ""Form Submitted Successfully!"";
}

private void HandleInvalidSubmit()
{
    SuccessMessage = string.Empty;
}";


    private readonly string example1CustomItemHtmlCode = @"
<BitChoiceGroup Label=""Pick one""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")"" />";
    private readonly string example1CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};";

    private readonly string example2CustomItemHtmlCode = @"
<BitChoiceGroup Label=""Disabled ChoiceGroup""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IsEnabled=""false""
                DefaultValue=""@(""A"")"" />

<BitChoiceGroup Label=""ChoiceGroup with Disabled Option""
                Items=""CustomChoiceGroupDisabledItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")"" />";
    private readonly string example2CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};
private readonly List<ChoiceModel> CustomChoiceGroupDisabledItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"", IsEnabled = false },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};";

    private readonly string example3CustomItemHtmlCode = @"
<BitChoiceGroup Label=""Pick one image""
                Items=""CustomChoiceGroupImageItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                ImageSrcField=""@nameof(ChoiceModel.ImageAddress)""
                ImageAltField=""@nameof(ChoiceModel.ImageDescription)""
                ImageSizeField=""@nameof(ChoiceModel.ImageSize)""
                SelectedImageSrcField=""@nameof(ChoiceModel.SelectedImageAddress)""
                DefaultValue=""@(""Bar"")"" />

<BitChoiceGroup Label=""Pick one icon""
                Items=""CustomChoiceGroupIconItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                DefaultValue=""@(""Day"")"" />";
    private readonly string example3CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupImageItems = new()
{
    new()
    {
        Name = ""Bar"",
        ItemValue = ""Bar"",
        ImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png"",
        SelectedImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png"",
        ImageDescription = ""alt for Bar image"",
        ImageSize = new Size(32, 32)
    },
    new()
    {
        Name = ""Pie"",
        ItemValue = ""Pie"",
        ImageAddress= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png"",
        SelectedImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png"",
        ImageDescription = ""alt for Pie image"",
        ImageSize = new Size(32, 32)
    }
};

private readonly List<ChoiceModel> CustomChoiceGroupIconItems = new()
{
    new() { Name = ""Day"", ItemValue = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Name = ""Week"", ItemValue = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Name = ""Month"", ItemValue = ""Month"", IconName = BitIconName.Calendar, IsEnabled = false }
};";

    private readonly string example4CustomItemHtmlCode = @"
<style>
    .custom-label {
        font-weight: bold;
        color: $Red20;
    }
</style>

<BitChoiceGroup Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")"">
    <LabelTemplate>
        <div class=""custom-label"">
            Custom label <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
</BitChoiceGroup>";
    private readonly string example4CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};";

    private readonly string example5CustomItemHtmlCode = @"
<style>
    .custom-option {
        display: flex;
        align-items: center;
        gap: rem(10px);
        cursor: pointer;
    }

    .custom-option .option-pointer {
        width: rem(20px);
        height: rem(20px);
        border: 1px solid;
        border-radius: rem(10px);
    }

    .custom-option:hover .option-pointer {
        border-top: rem(5px) solid #C66;
        border-bottom: rem(5px) solid #6C6;
        border-left: rem(5px) solid #66C;
        border-right: rem(5px) solid #CC6;
    }

    .custom-option.selected-option {
        color: #C66;
    }

    .custom-option.selected-option .option-pointer {
        border-top: rem(10px) solid #C66;
        border-bottom: rem(10px) solid #6C6;
        border-left: rem(10px) solid #66C;
        border-right: rem(10px) solid #CC6;
    }
</style>

<BitChoiceGroup Label=""Option Template""
                Items=""CustomChoiceGroupItemsTemplate""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                @bind-Value=""ChoiceGroupWithOptionTemplateValue"">
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupWithOptionTemplateValue == option.ItemValue ? ""selected-option"" : string.Empty)"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Name</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Label Template""
                Items=""CustomChoiceGroupItemsTemplate""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                @bind-Value=""ChoiceGroupWithOptionLabelTemplateValue"">
    <ItemLabelTemplate Context=""option"">
        <div style=""margin-left: 27px;"" class=""custom-option @(ChoiceGroupWithOptionLabelTemplateValue == option.ItemValue ? ""selected-option"" : string.Empty)"">
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Name</span>
        </div>
    </ItemLabelTemplate>
</BitChoiceGroup>";
    private readonly string example5CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupItemsTemplate = new()
{
    new() { Name = ""Day"", ItemValue = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Name = ""Week"", ItemValue = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Name = ""Month"", ItemValue = ""Month"", IconName = BitIconName.Calendar }
};

private string ChoiceGroupWithOptionTemplateValue = ""Day"";
private string ChoiceGroupWithOptionLabelTemplateValue = ""Day"";";

    private readonly string example6CustomItemHtmlCode = @"
<BitChoiceGroup Label=""One-way""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                Value=""@ChoiceGroupOneWayValue"" />
<BitTextField @bind-Value=""ChoiceGroupOneWayValue"" />

<BitChoiceGroup Label=""Two-way""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                @bind-Value=""ChoiceGroupTwoWayValue"" />
<BitTextField @bind-Value=""ChoiceGroupTwoWayValue"" />";
    private readonly string example6CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};

private string ChoiceGroupOneWayValue = ""A"";
private string ChoiceGroupTwoWayValue = ""A"";";

    private readonly string example7CustomItemHtmlCode = @"
<BitChoiceGroup Label=""Basic""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")""
                LayoutFlow=""BitLayoutFlow.Horizontal"" />

<BitChoiceGroup Label=""Disabled""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IsEnabled=""false"" DefaultValue=""@(""A"")""
                LayoutFlow=""BitLayoutFlow.Horizontal"" />

<BitChoiceGroup Label=""Image""
                Items=""CustomChoiceGroupImageItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                ImageSrcField=""@nameof(ChoiceModel.ImageAddress)""
                ImageAltField=""@nameof(ChoiceModel.ImageDescription)""
                ImageSizeField=""@nameof(ChoiceModel.ImageSize)""
                SelectedImageSrcField=""@nameof(ChoiceModel.SelectedImageAddress)""
                DefaultValue=""@(""Bar"")""
                LayoutFlow=""BitLayoutFlow.Horizontal"" />

<BitChoiceGroup Label=""Icon""
                Items=""CustomChoiceGroupIconItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                DefaultValue=""@(""Day"")""
                LayoutFlow=""BitLayoutFlow.Horizontal"" />

<BitChoiceGroup Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")""
                LayoutFlow=""BitLayoutFlow.Horizontal"">
    <LabelTemplate>
        <div class=""custom-label"">
            Label Template <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Template""
                @bind-Value=""@ChoiceGroupLayoutFlowWithOptionTemplateValue""
                Items=""CustomChoiceGroupItemsTemplate""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                LayoutFlow=""BitLayoutFlow.Horizontal"">
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupLayoutFlowWithOptionTemplateValue == option.ItemValue ? ""selected-option"" : """")"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Name</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>";
    private readonly string example7CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};

private readonly List<ChoiceModel> CustomChoiceGroupImageItems = new()
{
    new()
    {
        Name = ""Bar"",
        ItemValue = ""Bar"",
        ImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png"",
        SelectedImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png"",
        ImageDescription = ""alt for Bar image"",
        ImageSize = new Size(32, 32)
    },
    new()
    {
        Name = ""Pie"",
        ItemValue = ""Pie"",
        ImageAddress= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png"",
        SelectedImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png"",
        ImageDescription = ""alt for Pie image"",
        ImageSize = new Size(32, 32)
    }
};

private readonly List<ChoiceModel> CustomChoiceGroupIconItems = new()
{
    new() { Name = ""Day"", ItemValue = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Name = ""Week"", ItemValue = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Name = ""Month"", ItemValue = ""Month"", IconName = BitIconName.Calendar, IsEnabled = false }
};

private readonly List<ChoiceModel> CustomChoiceGroupItemsTemplate = new()
{
    new() { Name = ""Day"", ItemValue = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Name = ""Week"", ItemValue = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Name = ""Month"", ItemValue = ""Month"", IconName = BitIconName.Calendar }
};

private string ChoiceGroupLayoutFlowWithOptionTemplateValue = ""Day"";";

    private readonly string example8CustomItemHtmlCode = @"
<BitChoiceGroup Label=""Basic""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")""
                IsRtl=""true"" />

<BitChoiceGroup Label=""Disabled""
                Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IsEnabled=""false""
                DefaultValue=""@(""A"")""
                IsRtl=""true"" />

<BitChoiceGroup Label=""Image""
                Items=""CustomChoiceGroupImageItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                ImageSrcField=""@nameof(ChoiceModel.ImageAddress)""
                ImageAltField=""@nameof(ChoiceModel.ImageDescription)""
                ImageSizeField=""@nameof(ChoiceModel.ImageSize)""
                SelectedImageSrcField=""@nameof(ChoiceModel.SelectedImageAddress)""
                DefaultValue=""@(""Bar"")""
                LayoutFlow=""BitLayoutFlow.Horizontal""
                IsRtl=""true"" />

<BitChoiceGroup Label=""Icon""
                Items=""CustomChoiceGroupIconItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                DefaultValue=""@(""Day"")""
                LayoutFlow=""BitLayoutFlow.Horizontal""
                IsRtl=""true"" />

<BitChoiceGroup Items=""CustomChoiceGroupBasicItems""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                DefaultValue=""@(""A"")""
                LayoutFlow=""BitLayoutFlow.Horizontal""
                IsRtl=""true"">
    <LabelTemplate>
        <div class=""custom-label"">
            Label Template <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Template"" @bind-Value=""@ChoiceGroupRtlLayoutFlowWithOptionTemplateValue""
                Items=""CustomChoiceGroupItemsTemplate""
                TextField=""@nameof(ChoiceModel.Name)""
                ValueField=""@nameof(ChoiceModel.ItemValue)""
                IconNameField=""@nameof(ChoiceModel.IconName)""
                LayoutFlow=""BitLayoutFlow.Horizontal""
                IsRtl=""true"">
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupRtlLayoutFlowWithOptionTemplateValue == option.ItemValue ? ""selected-option"" : """")"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Name</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>";
    private readonly string example8CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};

private readonly List<ChoiceModel> CustomChoiceGroupImageItems = new()
{
    new()
    {
        Name = ""Bar"",
        ItemValue = ""Bar"",
        ImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png"",
        SelectedImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png"",
        ImageDescription = ""alt for Bar image"",
        ImageSize = new Size(32, 32)
    },
    new()
    {
        Name = ""Pie"",
        ItemValue = ""Pie"",
        ImageAddress= ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png"",
        SelectedImageAddress = ""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png"",
        ImageDescription = ""alt for Pie image"",
        ImageSize = new Size(32, 32)
    }
};

private readonly List<ChoiceModel> CustomChoiceGroupIconItems = new()
{
    new() { Name = ""Day"", ItemValue = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Name = ""Week"", ItemValue = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Name = ""Month"", ItemValue = ""Month"", IconName = BitIconName.Calendar, IsEnabled = false }
};

private readonly List<ChoiceModel> CustomChoiceGroupItemsTemplate = new()
{
    new() { Name = ""Day"", ItemValue = ""Day"", IconName = BitIconName.CalendarDay },
    new() { Name = ""Week"", ItemValue = ""Week"", IconName = BitIconName.CalendarWeek },
    new() { Name = ""Month"", ItemValue = ""Month"", IconName = BitIconName.Calendar }
};

private string ChoiceGroupRtlLayoutFlowWithOptionTemplateValue = ""Day"";";

    private readonly string example9CustomItemHtmlCode = @"
@if (string.IsNullOrEmpty(SuccessMessage))
{
    <EditForm Model=""@ValidationModel"" OnValidSubmit=""@HandleValidSubmit"" OnInvalidSubmit=""@HandleInvalidSubmit"">
        <DataAnnotationsValidator />
        <div class=""validation-summary"">
            <ValidationSummary />
        </div>
        <div>
            <BitChoiceGroup Items=""CustomChoiceGroupBasicItems""
                        TextField=""@nameof(ChoiceModel.Name)""
                        ValueField=""@nameof(ChoiceModel.ItemValue)""
                        @bind-Value=""ValidationModel.Value"" />
            <ValidationMessage For=""@(() => ValidationModel.Value)"" />
        </div>
        <BitButton Style=""margin-top: 10px;"" ButtonType=""BitButtonType.Submit"">Submit</BitButton>
    </EditForm>
}
else
{
    <BitMessageBar MessageBarType=""BitMessageBarType.Success"" IsMultiline=""false"">
        @SuccessMessage
    </BitMessageBar>
}
<br />
<BitButton ButtonStyle=""BitButtonStyle.Standard"" OnClick=""() => { ValidationModel = new(); SuccessMessage=string.Empty; }"">Reset</BitButton>";
    private readonly string example9CustomItemCSharpCode = @"
public class ChoiceModel
{
    public string Name { get; set; }
    public string ItemValue { get; set; }
    public string ImageAddress { get; set; }
    public string ImageDescription { get; set; }
    public Size? ImageSize { get; set; }
    public string SelectedImageAddress { get; set; }
    public string? IconName { get; set; }
    public bool IsEnabled { get; set; } = true;
}

private readonly List<ChoiceModel> CustomChoiceGroupBasicItems = new()
{
    new() { Name = ""Custom A"", ItemValue = ""A"" },
    new() { Name = ""Custom B"", ItemValue = ""B"" },
    new() { Name = ""Custom C"", ItemValue = ""C"" },
    new() { Name = ""Custom D"", ItemValue = ""D"" }
};

public class ChoiceGroupValidationModel
{
    [Required(ErrorMessage = ""Pick one"")]
    public string Value { get; set; }
}

public ChoiceGroupValidationModel ValidationModel = new();
public string SuccessMessage;

private void HandleValidSubmit()
{
    SuccessMessage = ""Form Submitted Successfully!"";
}

private void HandleInvalidSubmit()
{
    SuccessMessage = string.Empty;
}";


    private readonly string example1BitChoiceGroupOptionHtmlCode = @"
<BitChoiceGroup TItem=""BitChoiceGroupOption<string>"" TValue=""string"" Label=""Pick one"" DefaultValue=""@(""A"")"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>";

    private readonly string example2BitChoiceGroupOptionHtmlCode = @"
<BitChoiceGroup TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                Label=""Disabled ChoiceGroup""
                IsEnabled=""false""
                DefaultValue=""@(""A"")"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""ChoiceGroup with Disabled Option""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                DefaultValue=""@(""A"")"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" IsEnabled=""false"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>";

    private readonly string example3BitChoiceGroupOptionHtmlCode = @"
<BitChoiceGroup Label=""Pick one image""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                DefaultValue=""@(""Bar"")"">
    <BitChoiceGroupOption Text=""Bar""
                          Value=""@(""Bar"")""
                          ImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png""
                          SelectedImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png""
                          ImageAlt=""Alt for Bar image""
                          ImageSize=""@(new Size(32, 32))"" />
    <BitChoiceGroupOption Text=""Pie""
                          Value=""@(""Pie"")""
                          ImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png""
                          SelectedImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png""
                          ImageAlt=""Alt for Pie image""
                          ImageSize=""@(new Size(32, 32))"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Pick one icon""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                DefaultValue=""@(""Day"")"">
    <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
    <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
    <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" IsEnabled=""false"" />
</BitChoiceGroup>";

    private readonly string example4BitChoiceGroupOptionHtmlCode = @"
<style>
    .custom-label {
        font-weight: bold;
        color: $Red20;
    }
</style>

<BitChoiceGroup TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""A"")"">
    <LabelTemplate>
        <div class=""custom-label"">
            Custom label <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
    <ChildContent>
        <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
        <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
        <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
        <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
    </ChildContent>
</BitChoiceGroup>";

    private readonly string example5BitChoiceGroupOptionHtmlCode = @"
<style>
    .custom-option {
        display: flex;
        align-items: center;
        gap: rem(10px);
        cursor: pointer;
    }

    .custom-option .option-pointer {
        width: rem(20px);
        height: rem(20px);
        border: 1px solid;
        border-radius: rem(10px);
    }

    .custom-option:hover .option-pointer {
        border-top: rem(5px) solid #C66;
        border-bottom: rem(5px) solid #6C6;
        border-left: rem(5px) solid #66C;
        border-right: rem(5px) solid #CC6;
    }

    .custom-option.selected-option {
        color: #C66;
    }

    .custom-option.selected-option .option-pointer {
        border-top: rem(10px) solid #C66;
        border-bottom: rem(10px) solid #6C6;
        border-left: rem(10px) solid #66C;
        border-right: rem(10px) solid #CC6;
    }
</style>

<BitChoiceGroup Label=""Option Template""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                @bind-Value=""ChoiceGroupWithOptionTemplateValue"">
    <ChildContent>
        <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
        <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
        <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" />
    </ChildContent>
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupWithOptionTemplateValue == option.Value ? ""selected-option"" : string.Empty)"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Label Template""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                @bind-Value=""ChoiceGroupWithOptionLabelTemplateValue"">
    <ChildContent>
        <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
        <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
        <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" />
    </ChildContent>
    <ItemLabelTemplate Context=""option"">
        <div style=""margin-left: 27px;"" class=""custom-option @(ChoiceGroupWithOptionLabelTemplateValue == option.Value ? ""selected-option"" : string.Empty)"">
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemLabelTemplate>
</BitChoiceGroup>";
    private readonly string example5BitChoiceGroupOptionCSharpCode = @"
private string ChoiceGroupWithOptionTemplateValue = ""Day"";
private string ChoiceGroupWithOptionLabelTemplateValue = ""Day"";";

    private readonly string example6BitChoiceGroupOptionHtmlCode = @"
<BitChoiceGroup TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                Label=""One-way""
                Value=""@ChoiceGroupOneWayValue"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>
<BitTextField @bind-Value=""ChoiceGroupOneWayValue"" />
    
<BitChoiceGroup TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                Label=""Two-way""
                @bind-Value=""ChoiceGroupTwoWayValue"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>
<BitTextField @bind-Value=""ChoiceGroupTwoWayValue"" />";
    private readonly string example6BitChoiceGroupOptionCSharpCode = @"
private string ChoiceGroupOneWayValue = ""A"";
private string ChoiceGroupTwoWayValue = ""A"";";

    private readonly string example7BitChoiceGroupOptionHtmlCode = @"
<BitChoiceGroup Label=""Basic"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Disabled"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" IsEnabled=""false"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Image"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""Bar"")"" LayoutFlow=""BitLayoutFlow.Horizontal"">
    <BitChoiceGroupOption Text=""Bar""
                            Value=""@(""Bar"")""
                            ImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png""
                            SelectedImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png""
                            ImageAlt=""Alt for Bar image""
                            ImageSize=""@(new Size(32, 32))"" />
    <BitChoiceGroupOption Text=""Pie""
                            Value=""@(""Pie"")""
                            ImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png""
                            SelectedImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png""
                            ImageAlt=""Alt for Pie image""
                            ImageSize=""@(new Size(32, 32))"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Icon"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""Day"")"" LayoutFlow=""BitLayoutFlow.Horizontal"">
    <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
    <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
    <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" IsEnabled=""false"" />
</BitChoiceGroup>

<BitChoiceGroup TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"">
    <LabelTemplate>
        <div class=""custom-label"">
            Label Template <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
    <ChildContent>
        <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
        <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
        <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
        <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
    </ChildContent>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Template"" @bind-Value=""@ChoiceGroupLayoutFlowWithOptionTemplateValue""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                LayoutFlow=""BitLayoutFlow.Horizontal"">
    <ChildContent>
        <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
        <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
        <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" />
    </ChildContent>
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupLayoutFlowWithOptionTemplateValue == option.Value?.ToString() ? ""selected-option"" : """")"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>";
    private readonly string example7BitChoiceGroupOptionCSharpCode = @"
private string ChoiceGroupLayoutFlowWithOptionTemplateValue = ""Day"";";

    private readonly string example8BitChoiceGroupOptionHtmlCode = @"
<BitChoiceGroup Label=""Basic"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""A"")"" IsRtl=""true"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Disabled"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" IsEnabled=""false"" DefaultValue=""@(""A"")"" IsRtl=""true"">
    <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
    <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
    <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
    <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Image"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""Bar"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" IsRtl=""true"">
    <BitChoiceGroupOption Text=""Bar""
                            Value=""@(""Bar"")""
                            ImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-unselected.png""
                            SelectedImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-bar-selected.png""
                            ImageAlt=""Alt for Bar image""
                            ImageSize=""@(new Size(32, 32))"" />
    <BitChoiceGroupOption Text=""Pie""
                            Value=""@(""Pie"")""
                            ImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-unselected.png""
                            SelectedImageSrc=""https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/choicegroup-pie-selected.png""
                            ImageAlt=""Alt for Pie image""
                            ImageSize=""@(new Size(32, 32))"" />
</BitChoiceGroup>

<BitChoiceGroup Label=""Icon"" TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""Day"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" IsRtl=""true"">
    <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
    <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
    <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" IsEnabled=""false"" />
</BitChoiceGroup>

<BitChoiceGroup TItem=""BitChoiceGroupOption<string>"" TValue=""string"" DefaultValue=""@(""A"")"" LayoutFlow=""BitLayoutFlow.Horizontal"" IsRtl=""true"">
    <LabelTemplate>
        <div class=""custom-label"">
            Label Template <BitIcon IconName=""@BitIconName.Filter"" />
        </div>
    </LabelTemplate>
    <ChildContent>
        <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
        <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
        <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
        <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
    </ChildContent>
</BitChoiceGroup>

<BitChoiceGroup Label=""Option Template"" @bind-Value=""@ChoiceGroupRtlLayoutFlowWithOptionTemplateValue""
                TItem=""BitChoiceGroupOption<string>""
                TValue=""string""
                LayoutFlow=""BitLayoutFlow.Horizontal""
                IsRtl=""true"">
    <ChildContent>
        <BitChoiceGroupOption Text=""Day"" Value=""@(""Day"")"" IconName=""@BitIconName.CalendarDay"" />
        <BitChoiceGroupOption Text=""Week"" Value=""@(""Week"")"" IconName=""@BitIconName.CalendarWeek"" />
        <BitChoiceGroupOption Text=""Month"" Value=""@(""Month"")"" IconName=""@BitIconName.Calendar"" />
    </ChildContent>
    <ItemTemplate Context=""option"">
        <div class=""custom-option @(ChoiceGroupRtlLayoutFlowWithOptionTemplateValue == option.Value?.ToString() ? ""selected-option"" : """")"">
            <div class=""option-pointer""></div>
            <BitIcon IconName=""@option.IconName.Value"" />
            <span>@option.Text</span>
        </div>
    </ItemTemplate>
</BitChoiceGroup>";
    private readonly string example8BitChoiceGroupOptionCSharpCode = @"
private string ChoiceGroupRtlLayoutFlowWithOptionTemplateValue = ""Day"";";

    private readonly string example9BitChoiceGroupOptionHtmlCode = @"
@if (string.IsNullOrEmpty(SuccessMessage))
{
    <EditForm Model=""@ValidationModel"" OnValidSubmit=""@HandleValidSubmit"" OnInvalidSubmit=""@HandleInvalidSubmit"">
        <DataAnnotationsValidator />
        <div class=""validation-summary"">
            <ValidationSummary />
        </div>
        <div>
            <BitChoiceGroup TItem=""BitChoiceGroupOption<string>"" TValue=""string"" @bind-Value=""ValidationModel.Value"">
                <BitChoiceGroupOption Text=""Option A"" Value=""@(""A"")"" />
                <BitChoiceGroupOption Text=""Option B"" Value=""@(""B"")"" />
                <BitChoiceGroupOption Text=""Option C"" Value=""@(""C"")"" />
                <BitChoiceGroupOption Text=""Option D"" Value=""@(""D"")"" />
            </BitChoiceGroup>
            <ValidationMessage For=""@(() => ValidationModel.Value)"" />
        </div>
        <BitButton Style=""margin-top: 10px;"" ButtonType=""BitButtonType.Submit"">Submit</BitButton>
    </EditForm>
}
else
{
    <BitMessageBar MessageBarType=""BitMessageBarType.Success"" IsMultiline=""false"">
        @SuccessMessage
    </BitMessageBar>
}
<br />
<BitButton ButtonStyle=""BitButtonStyle.Standard"" OnClick=""() => { ValidationModel = new(); SuccessMessage=string.Empty; }"">Reset</BitButton>";
    private readonly string example9BitChoiceGroupOptionCSharpCode = @"
public class ChoiceGroupValidationModel
{
    [Required(ErrorMessage = ""Pick one"")]
    public string Value { get; set; }
}

public ChoiceGroupValidationModel ValidationModel = new();
public string SuccessMessage;

private void HandleValidSubmit()
{
    SuccessMessage = ""Form Submitted Successfully!"";
}

private void HandleInvalidSubmit()
{
    SuccessMessage = string.Empty;
}";
}

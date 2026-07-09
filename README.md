# How to Implement Conditional Masking in .NET MAUI SfMaskedEntry

The `Mask` property can be updated dynamically to implement conditional masking based on user input or application requirements.

To apply different mask patterns conditionally, update the `Mask` property at runtime according to the desired logic:

* Different mask patterns can be assigned based on user selections or input values.
* The control automatically enforces the currently assigned mask pattern.
* Input validation is applied according to the active mask.

This approach enables dynamic input handling while ensuring that users enter data in the correct format for each scenario.

### Benefits of Using Conditional Masking

* Supports dynamic input requirements.
* Improves data accuracy by applying context-specific validation.
* Provides a flexible user experience.
* Reduces input errors by enforcing appropriate formats.
* Simplifies handling of multiple input patterns within a single form.

## Example Scenario

Consider an input field where the mask pattern changes based on the selected document type.

**MainPage.xaml**
```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
             x:Class="MaskedEntrySample.MainPage">
    
    <VerticalStackLayout WidthRequest="350" Padding="50" Spacing="40">
        <Picker x:Name="phoneTypePicker" SelectedIndexChanged="OnPhoneTypeChanged">
            <Picker.Items>
                <x:String>US Number</x:String>
                <x:String>International Number</x:String>
            </Picker.Items>
        </Picker>
        <editors:SfMaskedEntry x:Name="maskedEntry"
                       WidthRequest="250"
                       MaskType="Simple"
                       Placeholder="Enter phone number" />
    </VerticalStackLayout>
</ContentPage>
```
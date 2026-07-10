using Microsoft.Maui.Platform;

namespace MaskedEntrySample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnCountryChanged(object sender, EventArgs e)
    {
        maskedEntry.Value = string.Empty;
        if (countryPicker.SelectedIndex == 0)
        {
            // US Date Format: MM/DD/YYYY
            maskedEntry.Mask = "00/00/0000";
            maskedEntry.Placeholder = "MM/DD/YYYY";
        }
        else if (countryPicker.SelectedIndex == 1)
        {
            // UK Date Format: DD/MM/YYYY
            maskedEntry.Mask = "00/00/0000";
            maskedEntry.Placeholder = "DD/MM/YYYY";
        }
        else
        {
            // Japan Date Format: YYYY/MM/DD
            maskedEntry.Mask = "0000/00/00";
            maskedEntry.Placeholder = "YYYY/MM/DD";
        }
    }
}
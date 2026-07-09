namespace MaskedEntrySample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnPhoneTypeChanged(object sender, EventArgs e)
    {
        if (phoneTypePicker.SelectedIndex == 0)
        {
            maskedEntry.Mask = "(000) 000-0000";
            maskedEntry.Value = "408 9876543";
        }
        else
        {
            maskedEntry.Mask = "+00 000 000 0000";
            maskedEntry.Value = "129876541234";
        }
    }
}
namespace MaskedEntrySample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnPhoneTypeChanged(object sender, EventArgs e)
    {
        maskedEntry.Value = string.Empty;
        if (phoneTypePicker.SelectedIndex == 0)
        {
            maskedEntry.Mask = "(000) 000-0000";
        }
        else
        {
            maskedEntry.Mask = "00000 00000";
        }
    }
}
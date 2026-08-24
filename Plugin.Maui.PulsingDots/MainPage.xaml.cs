namespace Plugin.Maui.PulsingDots;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnToggleClicked(object? sender, EventArgs e)
    {
        BasicDots.IsRunning = !BasicDots.IsRunning;
        ToggleButton.Text = BasicDots.IsRunning ? "Stop" : "Start";
    }

    private async void OnSimulateRefreshClicked(object? sender, EventArgs e)
    {
        ChipLabelStack.IsVisible = false;
        ChipDots.IsVisible = true;
        ChipDots.IsRunning = true;

        await Task.Delay(1500);

        ChipDots.IsRunning = false;
        ChipDots.IsVisible = false;
        ChipLabelStack.IsVisible = true;
        ChipLabel.Text = $"Refreshed {DateTime.Now:T}";
    }
}

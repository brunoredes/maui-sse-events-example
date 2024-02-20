using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
namespace SSE.Views;

public partial class TrafficLightView : ContentPage
{
    public TrafficLightView()
    {
        InitializeComponent();
        Toaster();
    }

    private async void Toaster()
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        string text = "This is a Toast";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 14;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show(cancellationTokenSource.Token);
    }
}
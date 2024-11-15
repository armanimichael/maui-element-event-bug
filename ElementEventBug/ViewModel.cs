using CommunityToolkit.Mvvm.Input;

namespace ElementEventBug;

public partial class ViewModel
{
    [RelayCommand]
    public async Task ClickParent()
    {
        await Application.Current!.MainPage!.DisplayAlert("Parent", "Parent tapped", "OK");
    }

    [RelayCommand]
    public async Task ClickChild()
    {
        await Task.Delay(10000);
    }
}
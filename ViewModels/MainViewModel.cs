﻿using Microsoft.UI.Xaml.Media;
using static NeoBox.Views.MainPage;

namespace NeoBox.ViewModels;
public partial class MainViewModel : ObservableObject, ITitleBarAutoSuggestBoxAware
{
    public IJsonNavigationViewService JsonNavigationViewService;
    public MainViewModel(IJsonNavigationViewService jsonNavigationViewService, IThemeService themeService)
    {
        JsonNavigationViewService = jsonNavigationViewService;
        themeService.Initialize(App.currentWindow);
        themeService.ConfigBackdrop();
        themeService.ConfigElementTheme();
        themeService.ConfigBackdropFallBackColorForWindow10(
            Application.Current.Resources["ApplicationPageBackgroundThemeBrush"] as Brush);
    }

    public void OnAutoSuggestBoxTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
    {
    }

    public void OnAutoSuggestBoxQuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
    {
    }
}

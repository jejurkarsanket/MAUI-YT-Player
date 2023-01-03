using Microsoft.Maui.Controls;

namespace TubePlayer.ViewControls.Common;

public partial class LoadingIndicator : VerticalStackLayout
{
	// Control for showing loading screen.
	//Bindable Properties

	public static readonly BindableProperty IsBusyProperty = BindableProperty.Create(
		"IsBusy",
		typeof(bool),
		typeof(LoadingIndicator),
		false,
		BindingMode.OneWay,
		null,
		SetIsBusy);

	public bool IsBusy
	{
		get => (bool)this.GetValue(IsBusyProperty);
		set => this.SetValue(IsBusyProperty, value);
	}

	private static void SetIsBusy(BindableObject bindable, object oldvalue, object newValue)
	{
		LoadingIndicator control = bindable as LoadingIndicator;

		control.IsVisible = (bool)newValue;
		control.actIndicator.IsRunning = (bool)newValue;
	}
	
	public LoadingIndicator()
	{
		InitializeComponent();
	}
}
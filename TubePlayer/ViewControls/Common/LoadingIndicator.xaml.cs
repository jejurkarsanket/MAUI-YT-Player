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

	public static readonly BindableProperty LoadingTextProprty = BindableProperty.Create(
		"Loadingtext",
		 typeof(string),
		 typeof(LoadingIndicator),
		 string.Empty,
		 BindingMode.OneWay,
		 null,
         SetLoadingText);

	public string LoadingText
	{
		get => (string)this.GetValue(LoadingTextProprty);
		set => this.SetValue(LoadingTextProprty, value);
	}

	private static void SetLoadingText(BindableObject bindable, object oldValue, object newValue) =>
		(bindable as LoadingIndicator).lblLoadingText.Text = (string)newValue;
	
	public LoadingIndicator()
	{
		InitializeComponent();
	}
}
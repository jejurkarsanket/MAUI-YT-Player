namespace TubePlayer.ViewControls.Common;

public partial class ErrorIndicator : VerticalStackLayout
{
	public static BindableProperty IsErrorProperty = BindableProperty.Create(
		"IsError",
		typeof(bool),
		typeof(ErrorIndicator),
		false,
		BindingMode.OneWay,
		null,
		SetIsError
		);

	public bool IsError
	{ get => (bool)this.GetValue(IsErrorProperty) ;
	  set => this.SetValue(IsErrorProperty, value); 
	}

	private static void SetIsError(BindableObject bindable, object oldValue, object newValue) =>
		(bindable as ErrorIndicator).IsVisible = (bool)newValue;

	public static readonly BindableProperty ErrorTextProperty = BindableProperty.Create(
		"ErrorText",
		typeof(string),
		typeof(ErrorIndicator),
		string.Empty,
		BindingMode.OneWay,
		null,
		SetErrorText);

	public string ErrorText
	{
		get => (string)this.GetValue(ErrorTextProperty);
		set => this.SetValue(ErrorTextProperty, value);
	}

	private static void SetErrorText(BindableObject bindable, object oldValue, object newValue) =>
		(bindable as ErrorIndicator).lblErrorText.Text = (string) newValue;
	public ErrorIndicator()
	{
		InitializeComponent();
	}
}
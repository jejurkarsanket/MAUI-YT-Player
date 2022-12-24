namespace TubePlayer.ViewControls.Common;

//Inherit from Vertical Stack Layout
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

	//Control for Setting whether Error is occured or not.
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

	//Control for setting Error Text
	private static void SetErrorText(BindableObject bindable, object oldValue, object newValue) =>
		(bindable as ErrorIndicator).lblErrorText.Text = (string)newValue;

	public static readonly BindableProperty ErrorImageProperty = BindableProperty.Create(
		"Errorimage",
		typeof(ImageSource),
		typeof(ErrorIndicator),
		null,
		BindingMode.OneWay,
		null,SetErrorImage);

	public ImageSource ErrorImage
	{
		get => (ImageSource)this.GetValue(ErrorImageProperty);
		set => this.SetValue(ErrorImageProperty, value);
	}
	
	//Control for setting Error Image
	private static void SetErrorImage(BindableObject bindable, object oldValue, object newValue) =>
		(bindable as ErrorIndicator).imgErrror.Source = (ImageSource)newValue;

	public ErrorIndicator()
	{
		InitializeComponent();
	}
}
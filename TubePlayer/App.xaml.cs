﻿// This File contains Major App configurations during loading time. App can decide window orientattion/ Dimensions based on device type at Runtime.
#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

namespace TubePlayer;

public partial class App : Application
{
	const int WindowWidth = 540;
	const int WindowHeight = 1000;
	public App()
	{
		InitializeComponent();

		//Enable Version Tracking
		VersionTracking.Track();

		Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow),(handler, view) =>
		{
#if WINDOWS
			var mauiWindow = handler.VirtualView;
			var nativeWindow = handler.PlatformView;
			nativeWindow.Activate();
			IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
			WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
			AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
			appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
#endif
		});

		MainPage = new NavigationPage(new StartPage());
	}
}

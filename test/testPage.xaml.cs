﻿using Xamarin.Forms;
using System;

namespace test
{
	public partial class testPage : ContentPage
	{

		Label label;
		int clickTotal = 0;


		public testPage()
		{

			Label header = new Label
			{
				Text = "Button",
				Font = Font.BoldSystemFontOfSize(50),
				HorizontalOptions = LayoutOptions.Center
			};

			Button button = new Button
			{
				Text = "Click Me!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += OnButtonClicked;

			label = new Label
			{
				Text = "0 Button Clicked",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			//Accomodate iphone status bar
			this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

			//Build the Page
			this.Content = new StackLayout
			{
				Children =
				{
					header,
					button,
					label
				}
			};

			//InitializeComponent();

		}
		void OnButtonClicked(object sender, EventArgs e)
		{
			clickTotal += 1;
			label.Text = String.Format("{0} button click{1}",
									   clickTotal, clickTotal == 1 ? "" : "s");

		}
	}


}

using System;
using System.Collections.Generic;

using Xamarin.Forms;
using ContextActionXamarin.ViewModels;

namespace ContextActionXamarin.Views
{
	public partial class ContentActionView : ContentPage
	{
		public ContentActionView ()
		{
			InitializeComponent ();
			this.BindingContext = new FoodViewModel();
		}

		public void OnItemSelected(object sender, ItemTappedEventArgs args)
		{
			Navigation.PushModalAsync (new StackLabelView ());
		}
	}
}


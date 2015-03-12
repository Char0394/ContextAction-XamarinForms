using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ContextActionXamarin.Views
{
	public partial class TabbedView : TabbedPage
	{
		public TabbedView ()
		{
			InitializeComponent ();

			this.Children.Add (new ContentActionView { Title="Context Action", BackgroundColor = Color.Black});
			this.Children.Add (new StackLabelView { Title="StackLabel", BackgroundColor = Color.Black});
		}
	}
}


using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ContextActionXamarin.Views
{
	public partial class StackLabelView : ContentPage
	{
		public List<string> listkeywords;
		public StackLabelView ()
		{
			InitializeComponent ();
			listkeywords = new List<string> ();
			listkeywords.Add ("Word is too long");
			listkeywords.Add ("Long Word test example");
			listkeywords.Add ("Test");
			listkeywords.Add ("Forms");
			listkeywords.Add ("Xamarin");
			listkeywords.Add ("Cut");
			SetKeyWords ();
		}

		public void SetKeyWords()
		{
			foreach (string item in listkeywords) {
				Label label = new Label () {

					TextColor = Color.FromHex ("6ABF5A"),
					Text = item,
					HorizontalOptions = LayoutOptions.FillAndExpand,
				};

				var tgr = new TapGestureRecognizer ();
				tgr.Tapped += (s, e) => OnLabelClicked ();
				label.GestureRecognizers.Add (tgr);

				//Adding the label to the StackLayout
				KeyWordsStackLayout.Children.Add (label);

			}
		}
		private void OnLabelClicked()
		{



		}

	}
}


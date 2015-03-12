using System;
using ContextActionXamarin.Model;
using System.Collections.ObjectModel;

namespace ContextActionXamarin.ViewModels
{
	public class FoodViewModel
	{
		public ObservableCollection<Food> Foods { get; set; }

		public FoodViewModel ()
		{

			Foods = new ObservableCollection<Food>();
			Foods.Add(new Food
				{
					Name = "Hamburguer",
					Image = "https://cdn2.iconfinder.com/data/icons/tasty-bites-icon-set/512/hambruger.png"
				});

			Foods.Add(new Food
				{
					Name = "Salad",
					Image = "http://icons.iconarchive.com/icons/aha-soft/desktop-buffet/256/Salad-icon.png"
				});

			Foods.Add(new Food
				{
					Name = "Salad",
					Image = "http://icons.iconarchive.com/icons/aha-soft/desktop-buffet/256/Salad-icon.png"
				});


		}
	}
}


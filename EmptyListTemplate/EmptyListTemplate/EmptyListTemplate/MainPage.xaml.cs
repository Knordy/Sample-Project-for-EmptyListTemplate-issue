using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace EmptyListTemplate
{
   public partial class MainPage : ContentPage
   {
      public MainPage()
      {
         InitializeComponent();
      }

      private void Button_Clicked(object sender, EventArgs e)
      {
         ObservableCollection<Person> people = (ObservableCollection<Person>)this.BindingContext;

         Int32 count = people.Count + 1;

         people.Add(new Person(String.Format("Person {0}", count), new DateTime(1975, 1, 15), Color.Aqua));
      }
   }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EmptyListTemplate
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage page = new EmptyListTemplate.MainPage();
         page.BindingContext = People;

         MainPage = page;
      }

      private ObservableCollection<Person> _people = new ObservableCollection<Person>();
      public ObservableCollection<Person> People
      {
         get { return _people; }
         //set { SetProperty(ref _people, value, TitlePropertyName); } (XLabs SetProperty) setting this property will break certain bindings
      }

      protected override void OnStart()
      {
         // Handle when your app starts
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }
   }
}

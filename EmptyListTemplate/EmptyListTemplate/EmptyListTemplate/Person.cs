using System;
using Xamarin.Forms;

namespace EmptyListTemplate
{
   public class Person
   {
      public Person(string name, DateTime birthday, Color favoriteColor)
      {
         this.Name = name;
         this.Birthday = birthday;
         this.FavoriteColor = favoriteColor;
      }

      public string Name { private set; get; }

      public DateTime Birthday { private set; get; }

      public Color FavoriteColor { private set; get; }
   };
}

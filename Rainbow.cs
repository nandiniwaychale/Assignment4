//program in asp.net to create a webform application with a form and 2 listboxes(1stcolorsUppercase and 1stcolorsLowercase ) placed horizontally.
//add a class rainbow that has an array of string representing the 7 colors in the rainbow.
//Implement the IEnumerable interface on the rainbow class and yield return the colors using a for loop.
//In the load event of the form, create an instance of rainbow class. create a reference of type IEnumerator and 
//assign it an enumerator by calling the rainbow objects GetEnumerator() method.Add the current item to 1stColorsUppercase 
//listbox by converting the item to an uppercase string within a while loop that uses the enumerator



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment4
{
    public class Rainbow : IEnumerable<string>
    {
        private string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < colors.Length; i++)
            {
                yield return colors[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
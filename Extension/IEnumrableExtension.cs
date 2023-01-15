using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.Extension
{
    public static class IEnumrableExtension
    {
        public static IEnumerable<SelectListItem> ToSelectListItems<T>(this IEnumerable<T> items)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            SelectListItem item = new SelectListItem { Text = "----Select----", Value = "0" };
            listItems.Add(item);

            foreach (var i in items)
            {
                item = new SelectListItem
                {
                    //Text = i.GetType().GetProperty("Name").GetValue(i, null).ToString(),
                    //Value = i.GetType().GetProperty("Id").GetValue(i, null).ToString()

                    //instead we can use 

                    //1st way
                    //Text = ReflectionExtension.getPropertyValue(i, "Name"),
                    //Value = ReflectionExtension.getPropertyValue(i, "Id")

                    //2nd way
                    Text = i.getPropertyValue("Name"),
                    Value = i.getPropertyValue("Id")
                };
                listItems.Add(item);
            }

            return listItems;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeZilla.Models.ViewModel
{
    public class ModelViewModel
    {
        public Model Model { get; set; }
        public IEnumerable<Make> Makes { get; set; }

        //public IEnumerable<SelectListItem> selectListItems(IEnumerable<Make> items)
        //{
        //    List<SelectListItem> listItems = new List<SelectListItem>();

        //    SelectListItem item = new SelectListItem { Text = "----Select----", Value = "0" };
        //    listItems.Add(item);

        //    foreach (Make i in items)
        //    {
        //        item = new SelectListItem
        //        {
        //            Text = i.Name,
        //            Value = i.Id.ToString()
        //        };
        //        listItems.Add(item);
        //    }

        //    return listItems;
        //}
    }
}

using RefugeeCamp.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
            
            this IEnumerable<Level> levels)

        {

            return levels.OrderBy(l => l.LevelName).Select(l => new SelectListItem
            {
                Text = l.LevelName,
                Value = l.LevelId.ToString()

            });
        }
    }
}
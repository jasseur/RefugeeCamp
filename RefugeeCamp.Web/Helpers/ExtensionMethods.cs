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

        // gotta use this one for the students and the courses
        public static IEnumerable<SelectListItem> ToSelectListItems(
            
            this IEnumerable<Level> levels)

        {

            return levels.OrderBy(l => l.LevelName).Select(l => new SelectListItem
            {
                Text = l.LevelName,
                Value = l.LevelId.ToString()
            } );




        }


        // gotta use both (this one and the one above) for the classrooms

        public static IEnumerable<SelectListItem> ToSelectListItems1(

            this IEnumerable<Teacher> teachers)

        {

            return teachers.OrderBy(l => l.LastName).Select(l => new SelectListItem
            {
                Text = l.LastName,
                Value = l.LastName.ToString()
            });




        }
    }
}
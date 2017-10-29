using RefugeeCamp.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RefugeeCamp.Web.Models
{
    public class ClassroomModel : Classsroom
    {
        //gotta use'em for the binding
        public IEnumerable<SelectListItem> MTeacher { get; set; }
        public IEnumerable<SelectListItem> MLevel { get; set; }
    }
}
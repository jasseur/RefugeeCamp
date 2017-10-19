﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RefugeeCamp.Domaine.Entity
{
    public class Teacher : Staff
    {
       
       public String Notes { get; set; }
       public SpecialityType TeachingField { get; set; }

        public virtual ICollection<Classsroom> Classsrooms { get; set; }
    }

    public enum SpecialityType { Mathematics, Sciences, English, LocalLanguage, ComputerScience, Litterature, Physics   }

}

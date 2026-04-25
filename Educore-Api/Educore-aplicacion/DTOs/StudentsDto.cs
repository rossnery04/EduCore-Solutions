using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
   public class StudentsDto
    {
        public int Id { get; set; }//primary key 
        public string Name { get; set; }
        public int  resgistration_number { get; set; }
        public bool status { get; set; }

        //relaciones>

        public virtual ICollection<ResgistrationsDto> Resgistrations { get; set; }
    }
}

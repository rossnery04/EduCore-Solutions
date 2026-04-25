using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Domain_educore.Entidades
{
 public class WorkshopDto
  {
        public int Id { get; set; } // primary key 
        public string Name { get; set; }
        public int Maximum_Capacity { get; set; } 
        public float price { get; set; }

        public int category_id { get; set; } //foreing key

        public int intructor_id { get; set; } //foreing key


        //relations

        public virtual CategoryDto Category { get; set; }
        public virtual CategoryDto Categorys { get; set; }
        public virtual ICollection<ResgistrationsDto> Resgistrations { get; set; }
    }
}

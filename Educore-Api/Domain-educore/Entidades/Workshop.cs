using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Domain_educore.Entidades
{
 public class Workshop
  {
        public int Id { get; set; } // primary key 
        public string Name { get; set; }
        public int Maximum_Capacity { get; set; } 
        public float price { get; set; }

        public int category_id { get; set; } //foreing key

        public int intructor_id { get; set; } //foreing key


        //relations

        public virtual Category Category { get; set; }
        public virtual Category Categorys { get; set; }
        public virtual ICollection<Resgistrations> Resgistrations { get; set; }
    }
}

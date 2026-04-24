using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
   public class instructors
    {
        public int id { get; set; } //primary key

        public string name { get; set; }

        public int specialty { get; set; }
        public int Email{ get; set; }
        public int Number  { get; set; }

        //relations
        public virtual ICollection<Workshop> Workshops { get; set; }


    }

}

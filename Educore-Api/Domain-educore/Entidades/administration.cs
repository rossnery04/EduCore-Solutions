using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
    public class administration
    {
        public int id {  get; set; }//primary key
        public string name { get; set; } 

        public string position { get; set; }
        public int salary { get; set; }
        public string address { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
   public class Resgistrations
    {
        public int id { get; set; } //primary key 
        public int students_id { get; set; } //foreing key
        public int workshop_id { get; set; } //foreing key
        public string registrations_date { get; set; }

        //relations>

        public virtual Students Students { get; set; }
        public virtual Workshop Workshop { get; set; }

        public virtual ICollection<attedance> Attedances { get; set; }
        public virtual ICollection<payment> payments { get; set; }
    }
}


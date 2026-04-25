using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
    public class attedanceDto
    {
        public int id { get; set; }
        public int registrations_id { get; set; }//foreing key
        public int date { get; set; }//foreing key

        //relations

        public virtual ResgistrationsDto Resgistrations { get; set; }

    }
}

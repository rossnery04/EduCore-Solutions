using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
    public class paymentDto
    {
        public int id { get; set; }//primary key
        public int registrions_id { get; set; }//fk

        public int amount  { get; set; }
        public int paymentDate { get; set; }

        //relacion

        public virtual ResgistrationsDto Resgistrations { get; set; }
    }
}

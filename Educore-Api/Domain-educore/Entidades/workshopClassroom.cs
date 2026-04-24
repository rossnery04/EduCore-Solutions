using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
    public class workshopClassroom
    {
        public int id { get; set; } //primary key

        public int workshop_id { get; set; }//fk
        public int classroom_id { get; set; }//fk
    }
}

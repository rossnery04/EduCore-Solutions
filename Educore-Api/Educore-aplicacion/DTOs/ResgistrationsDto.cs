using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
   public class ResgistrationsDto
    {
        public int id { get; set; } //primary key 
        public int students_id { get; set; } //foreing key
        public int workshop_id { get; set; } //foreing key
        public string registrations_date { get; set; }

        //relations>

        public virtual StudentsDto Students { get; set; }
        public virtual WorkshopDto Workshop { get; set; }

        public virtual ICollection<attedanceDto> Attedances { get; set; }
        public virtual ICollection<paymentDto> payments { get; set; }
    }
}


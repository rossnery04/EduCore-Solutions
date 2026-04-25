using System;
using System.Collections.Generic;
using System.Text;

namespace Domain_educore.Entidades
{
    public class CategoryDto
    {
        public int Id { get; set; }// primary key 
        public  string Name { get; set; }

        public  string Description { get; set; }

        //relations

        public virtual ICollection<WorkshopDto> Workshops { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Emr.Domain.Drags.Models
{
    //Копипастим все поля из Drug и так же добавляет в Mapper
    public class DragModel
    {
        public Guid DragGuid { get; set; }

        public string NameDrug { get; set; }

        public string Description { get; set; }

        public DragModel()
        {
            
        }
    }
}

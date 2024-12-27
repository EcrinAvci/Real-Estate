using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Villa.Dto.Dtos.QuestDtos
{
    public class CreateQuestDto
    {
      
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}

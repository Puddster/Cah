using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cah.Models
{
    public class AnswerCard
    {
        public int AnswerCardId { get; set; }
        public string Text { get; set; }
        public Statistics Statistics { get; set; }
    }
}

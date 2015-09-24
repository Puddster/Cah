using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cah.Models
{
    public class QuestionCard
    {
        public int QuestionCardId { get; set; }
        public string Text { get; set; }
        public int NumberOfAnswers { get; set; }
        public Statistics Statistics { get; set; }
    }
}

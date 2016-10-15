using AnswerIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsnwerIt.Models
{
    public class PlayModel
    {
        string question { get; set; }
        IList<string> answers { get; set; }
    }
}

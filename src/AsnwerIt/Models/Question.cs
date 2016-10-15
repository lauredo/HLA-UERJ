using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace AnswerIt.Models
{
    public class Question
    {
        public Question()
        {
            Answers = new List<Answer>();
        }
        [JsonProperty("question")]
        public string Text { get; set; }
        [JsonProperty("answers")]
        public ICollection Answers { get; set; }
    }
}
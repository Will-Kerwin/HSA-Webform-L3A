using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HSA.Shared.Models.Assesment
{
    public class AssesmentQuestions
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        [JsonPropertyName("A")]
        public string OptionA { get; set; }
        [JsonPropertyName("B")]
        public string OptionB { get; set; }
        [JsonPropertyName("C")]
        public string OptionC { get; set; }
        [JsonPropertyName("D")]
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }
        public int Sequence { get; set; }
        [JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }
    }
}

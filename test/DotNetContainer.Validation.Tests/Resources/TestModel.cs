using System.ComponentModel.DataAnnotations;

namespace DotNetContainer.Validation.Tests.Resources
{
    public class TestModel
    {
        [Required]
        public string Content { get; set; }

        [RegularExpression("^TestRegex$")]
        public string TestRegexContent { get; set; }
    }
}
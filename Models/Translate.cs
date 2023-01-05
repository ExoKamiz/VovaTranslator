using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace VovaTranslator.Models
{
    public class Translate
    {
      
            public int Id { get; set; }
            [Required(ErrorMessage = "Validate_Required")]
            public string Name { get; set; } = string.Empty;
            [Required(ErrorMessage = "Validate_Required")]
            public string Sex { get; set; } = string.Empty;
        
    }
}

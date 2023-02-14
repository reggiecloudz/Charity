using System.ComponentModel.DataAnnotations;

namespace Charity.Web.Models
{
    public class TextEditorModel
    {
        [DataType(DataType.Text)]
        public string Content { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace FluentValidationIssue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
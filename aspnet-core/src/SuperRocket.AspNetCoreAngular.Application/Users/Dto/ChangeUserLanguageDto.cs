using System.ComponentModel.DataAnnotations;

namespace SuperRocket.AspNetCoreAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
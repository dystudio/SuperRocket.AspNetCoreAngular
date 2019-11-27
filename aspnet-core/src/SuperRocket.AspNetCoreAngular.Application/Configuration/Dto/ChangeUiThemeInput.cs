using System.ComponentModel.DataAnnotations;

namespace SuperRocket.AspNetCoreAngular.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}

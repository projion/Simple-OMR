using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Simple_OMR.ViewModels
{
    public class CreateRoleViewModel
    {
        [Microsoft.Build.Framework.Required]
        [Display(Name = "Role")]
        public String RoleName { get; set; }
    }
}

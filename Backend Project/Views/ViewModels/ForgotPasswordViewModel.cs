using System.ComponentModel.DataAnnotations;

namespace Backend_Project.Views.ViewModels;

public class ForgotPasswordViewModel
{
    [Required, DataType(DataType.EmailAddress)]
    public string Email { get; set; }
}

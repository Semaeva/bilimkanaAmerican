﻿using System.ComponentModel.DataAnnotations;

namespace BilimkanaAmerican.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }


        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }
        public string? OldPassword { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

using static CarRentingSystem.Data.DataConstants.User;

namespace CarRentingSystem.Data.Models
{
    public class User : IdentityUser
    {
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; }


    }
}

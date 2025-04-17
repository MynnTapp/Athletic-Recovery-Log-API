using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AthleticRecoveryAPI.Models
{
    public class User : IdentityUser
    {
        public required string FirstName { get; set; }
        public required string LastName {get; set;}
        public DateTime DateCreated {get; set;}

        public required ICollection<RecoveryLog> RecoveryLogs {get; set;}

    }
}
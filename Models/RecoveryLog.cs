

using System.ComponentModel.DataAnnotations;

namespace AthleticRecoveryAPI.Models

{
    public class RecoveryLog
    {
        [Key]

        public int Id {get; set;}
        public required string UserId {get; set;}
        public DateTime Date {get; set;}
        public required string ActivityType {get; set;}

        public int DurationMinutes {get; set;}

        public required string Recoverytype {get; set;}

        public required string Notes {get; set;}

        public int PercievedRecoveryScore {get; set;}

        public required User User {get; set;}

    }
}
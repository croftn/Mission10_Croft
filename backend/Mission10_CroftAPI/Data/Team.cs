using System.ComponentModel.DataAnnotations;

namespace Mission10_CroftAPI.Data
{
    //Class to create team object
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        public string? TeamName { get; set; } = null!;
        public int? CaptainID { get; set; }
    }
}

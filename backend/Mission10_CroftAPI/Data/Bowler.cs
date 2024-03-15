﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_CroftAPI.Data
{
    //Class to create bowler object
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }
        //Foreign key to tie to Team table
        [Required]
        [ForeignKey("TeamID")]
        public int? TeamID { get; set; }
        public Team? Team { get; set; }
    }

}
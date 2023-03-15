﻿using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        public int GameId { get; set; }
        public Game Game { get; set; } = null!;

        public int PlayerId { get; set; }
        public Player Player { get; set; } = null!;

        [Required]
        public int ScoredGoals { get; set; }

        [Required]
        public int Assists { get; set; }

        [Required]
        public int MinutesPlayed { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTracker
{
    public class MediaItem
    {
        public string NameTitle { get; set; }
        public int ReleaseYear { get; set; }
        public enum StatusEnum
        {
            Watched,
            Planed,
            InProgress,
            OnHold,
            Dropped
        }
        public StatusEnum Status { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public List<string> Director { get; set; } = new List<string>();
        public List<string> Genre { get; set; } = new List<string>();

        public MediaItem(string nameTitle, int releaseYear, StatusEnum status, double score, string description, List<string> director, List<string> genre)
        {
            NameTitle = nameTitle;
            ReleaseYear = releaseYear;
            Status = status;
            Score = score;
            Description = description;
            Director = director;
            Genre = genre;
        }
    }

    public class Movie : MediaItem
    {
        public double Duration { get; set; }

        public Movie(string nameTitle, int releaseYear, StatusEnum status, double score, string description, List<string> director, List<string> genre, double duration)
            : base(nameTitle, releaseYear, status, score, description, director, genre)
        {
            Duration = duration;
        }
    }

    public class Series : MediaItem
    {
        public int Seasons { get; set; }
        public int Episodes { get; set; }

        public Series(string nameTitle, int releaseYear, StatusEnum status, double score, string description, List<string> director, List<string> genre, int seasons, int episodes)
            : base(nameTitle, releaseYear, status, score, description, director, genre)
        {
            Seasons = seasons;
            Episodes = episodes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediaTracker
{
    public class MediaItem : IRateble
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
        public double Score { get; private set; }
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

        public virtual string GetInfo()
        {
            return $"Названия Фильмеца: {NameTitle}, Year: {ReleaseYear}, Status: {Status}, Score: {Score}, Description: {Description}, Director: {string.Join(", ", Director)}, Genre: {string.Join(", ", Genre)}";
        }
         public void Rate(double score)
            {
                const int rateMax = 10;
            if (score < 0 || score > rateMax)
                {
                    throw new ArgumentOutOfRangeException(nameof(score), "Оценка должна быть от 0 до 10!!!");
                }
                Score = score;
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

        public override string GetInfo()
        {
            return base.GetInfo() + $", Duration: {Duration} minutes\n";
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

        public override string GetInfo()
        {
            return base.GetInfo() + $", Seasons: {Seasons}, Episodes: {Episodes}\n";
        }
    }
}

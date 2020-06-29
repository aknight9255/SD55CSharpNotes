﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror =1,
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller,
        Romance
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public int StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent() { }
        public StreamingContent(string title,string description,string maturityRating, int starRating,bool isFamilyFriendly,GenreType typeOfGenre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            IsFamilyFriendly = isFamilyFriendly;
            TypeOfGenre = typeOfGenre;
        }
    }
}

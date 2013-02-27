using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotnetMovies.Models
{
    public class Movie
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string releaseYear;

        public string ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }
        private string poster;

        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }
        private string directors;

        public string Directors
        {
            get { return directors; }
            set { directors = value; }
        }
        private string actors;

        public string Actors
        {
            get { return actors; }
            set { actors = value; }
        }
        private string synopsis;

        public string Synopsis
        {
            get { return synopsis; }
            set { synopsis = value; }
        }
        private int rate;

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public Movie(int id, string title, string releaseYear, string poster, string directors, string actors, string synopsis, int rate)
        {
            this.id = id;
            this.title = title;
            this.releaseYear = releaseYear;
            this.poster = poster;
            this.directors = directors;
            this.actors = actors;
            this.synopsis = synopsis;
            this.rate = rate;
        }
    }
}
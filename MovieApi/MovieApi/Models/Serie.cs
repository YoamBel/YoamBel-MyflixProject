using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApi.Models
{
    public class Serie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
        public int Average { get; set; }
        public string TextDescription { get; set; }
        public string Categorie { get; set; }
        public int NbSeason { get; set; }
        public int NbEpisode { get; set; }
        public string Genre { get; set; }
        public string Link { get; set; }

        public Serie()
        {

        }

        public Serie(int v1, string v2, byte[] v3, int v4, string v5, string v6, int v7, int v8, string v9, string v10)
        {
            ID = v1;
            Title = v2;
            Picture = v3;
            Average = v4;
            TextDescription = v5;
            Categorie = v6;
            NbSeason = v7;
            NbEpisode = v8;
            Genre = v9;
            Link = v10;
        }
    }
}
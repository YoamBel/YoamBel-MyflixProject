using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApi.Models
{
    public class Anime
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
        public int Average { get; set; }
        public string TextDescription { get; set; }
        public string Categorie { get; set; }
        public string Genre { get; set; }
        public string Link { get; set; }

        public Anime()
        {

        }

        public Anime(int v1, string v2, byte[] v3, int v4, string v5, string v6, string v7, string v8)
        {
            ID = v1;
            Title = v2;
            Picture = v3;
            Average = v4;
            TextDescription = v5;
            Categorie = v6;
            Genre = v7;
            Link = v8;
        }
    }
}
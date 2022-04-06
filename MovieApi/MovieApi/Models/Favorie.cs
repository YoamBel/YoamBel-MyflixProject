using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApi.Models
{
    public class Favorie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
        public string Link { get; set; }

        public Favorie()
        {

        }

        public Favorie(int v1, string v2,byte[]v3,string v4)
        {
            ID = v1;
            Title = v2;
            Picture = v3;
            Link = v4;
        }
    }
}
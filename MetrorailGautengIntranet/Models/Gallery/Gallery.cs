using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetrorailGautengIntranet.Models.Gallery
{
    public class Gallery
    {
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public List<Photo> photos { get; set; }

        public Gallery()
        {
            Title = string.Empty;
            FileName = string.Empty;
            Description = string.Empty;
            photos = new List<Photo>();
        }

        public Gallery(string title, string fileName, string description)
        {
            Title = title;
            FileName = fileName;
            Description = description;
            photos = new List<Photo>();
        }

        public Gallery(string[] stringArr)
            : this(stringArr[0], stringArr[1], stringArr[2])
        {
            
        }
    }
}
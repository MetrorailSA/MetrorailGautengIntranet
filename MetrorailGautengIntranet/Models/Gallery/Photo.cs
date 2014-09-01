using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MetrorailGautengIntranet.Models.Gallery
{
    public class Photo
    {
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }

        public Photo(string title, string fileName, string description)
        {
            Title = title;
            FileName = fileName;
            Description = description;
        }

        public Photo(string[] stringArr)
            : this(stringArr[0], stringArr[1], stringArr[2])
        {
            
        }

    }


}
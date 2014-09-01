using MetrorailGautengIntranet.Models.Gallery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetrorailGautengIntranet.Controllers
{
    public class GalleryController : Controller
    {
        Gallery photoGallery1;
        Gallery photoGallery2;
        Gallery photoGallery3;

        public ActionResult Index()
        {
            List<Gallery> galleries = new List<Gallery>();
            photoGallery1 = ReadPhotoGallery(1);
            if (photoGallery1.Title != string.Empty)
                galleries.Add(photoGallery1);
            photoGallery2 = ReadPhotoGallery(2);
            if (photoGallery2.Title != string.Empty)
                galleries.Add(photoGallery2);
            photoGallery3 = ReadPhotoGallery(3);
            if (photoGallery3.Title != string.Empty)
                galleries.Add(photoGallery3);
            return View(galleries);
        }

        public ActionResult Gallery1()
        {
            photoGallery1 = ReadPhotoGallery(1);
            return View(photoGallery1);
        }

        public ActionResult Gallery2()
        {
            photoGallery2 = ReadPhotoGallery(2);
            return View(photoGallery2);
        }

        public ActionResult Gallery3()
        {
            photoGallery3 = ReadPhotoGallery(3);
            return View(photoGallery3);
        }

        private Gallery ReadPhotoGallery(int i)
        {
            Gallery photoGallery = new Gallery();
 	       
            try
            {
                string folderName = HttpContext.Server.MapPath("~/Content/Images/Gallery/Gallery" + i);
                string fileName = folderName + Path.DirectorySeparatorChar + "gallery.csv";
                
                var reader = new StreamReader(System.IO.File.OpenRead(fileName));
                
                // Read first line: Gallery/Album name and image

                var line = reader.ReadLine();
                string[] values = line.Split(';');
                photoGallery = new Gallery(values);

                // Read rest of the lines: pictures

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    values = line.Split(';');
                    Photo photo = new Photo(values[0], HttpUtility.UrlPathEncode(values[1]), values[2]);
                    photoGallery.photos.Add(photo);
                }
                reader.Close();
                
            }
            catch (Exception)
            {
                //No gallery exists. Return empty gallery
            }

            return photoGallery;
        }
	}
}
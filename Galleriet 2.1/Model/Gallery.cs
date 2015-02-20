using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Galleriet_2._1.BOL
{
    public class Gallery
    {
        private static readonly Regex ApprovedExtensions;
        private static string PhysicalUploadedImagesPath; //= "~/Martin 2.1 Galleri/Galleriet 2.1/Galleri";        
        private static readonly Regex SanitizePath;
        private static string PhysicalUploadThumbImagePath;

        static Gallery()
        {
            ApprovedExtensions = new Regex(@"^.*\.(gif|jpg|png)$");
            PhysicalUploadedImagesPath = Path.Combine(AppDomain.CurrentDomain.GetData("APPBASE").ToString(), "Galleri");
            PhysicalUploadThumbImagePath = Path.Combine(AppDomain.CurrentDomain.GetData("APPBASE").ToString(), "Galleri", "Gallerithumbnails");
            var invalidChars = new string(Path.GetInvalidFileNameChars());
            SanitizePath = new Regex(string.Format("[{0}]", Regex.Escape(invalidChars)));    
        }
        public IEnumerable<string> GetImageNames()
        {
            var directory = new DirectoryInfo(PhysicalUploadThumbImagePath);
            FileInfo[] fileinfo = directory.GetFiles();
            var imageList = fileinfo.Select(image => image.Name).Where(filename => ApprovedExtensions.IsMatch(filename)).ToList();

            return imageList.AsReadOnly();
        }
        public static bool ImageExists(string name)
        {
            return File.Exists(Path.Combine(PhysicalUploadedImagesPath,name));
        }
        private static bool IsValidImage(Image Image)
        {
            return Image.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid
                || Image.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid
                || Image.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid;
        }

        public static string SaveImage(Stream stream, string fileName)
        {
            var Image = System.Drawing.Image.FromStream(stream);
            if(IsValidImage(Image))
            {
                var Thumbnail = Image.GetThumbnailImage(60, 45, null, System.IntPtr.Zero); //Storleken tumnagel
                string newFileName = Path.GetFileNameWithoutExtension(fileName);
                int i = 2;

                while(ImageExists(newFileName + Path.GetExtension(fileName))) //Om en fil med namnet redan existerar
                {
                    newFileName = Path.GetFileNameWithoutExtension(fileName);
                    newFileName = newFileName + i;
                    i++;
                }
                fileName = newFileName + Path.GetExtension(fileName);

                Image.Save(Path.Combine(PhysicalUploadedImagesPath, fileName));

                Thumbnail.Save(Path.Combine(PhysicalUploadedImagesPath, "Gallerithumbnails", fileName));
                //Sökvägen för att spara bilden + tumnageln
                return fileName;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
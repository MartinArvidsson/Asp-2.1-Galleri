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
        private static Regex ApprovedExtensions;
        private static string PhysicalUploadedImagesPath;
        private static Regex SanitizePath;

        private Gallery()
        {

        }

        IEnumerable<string> GetImageNames()
        {

        }

        private static bool ImageExists(string name)
        {

        }

        private static bool IsValidImage(Image Image)
        {

        }

        private static string SaveImage(Stream stream, string FileName)
        {

        }
    }
}
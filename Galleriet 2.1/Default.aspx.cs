using Galleriet_2._1.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galleriet_2._1
{
    public partial class Default : System.Web.UI.Page
    {
        private Gallery gallery
        {
            get
            {
                return Session["Gallery"] as Gallery ?? (Gallery)(Session["secretnumber"] = new Gallery()); 
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e) //FileContent + FileName till SaveImages
        {
            Gallery.SaveImage(FileUploader.FileContent , FileUploader.FileName);
        }

        public IEnumerable<System.String> Thumbnailrepeater_GetData()
        {
            return gallery.GetImageNames();
        }
    }
}
//okay, så. Varje gång man klickar uppload ska följande hända : Bilden laddas ut och SavePicture i Gallery.cs körs
//, Efter det skapas en ny Hyperlink i repeatern med den sista platsen (Senast tillagda bilden)

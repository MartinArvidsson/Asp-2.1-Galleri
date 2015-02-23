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
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = Request.QueryString["name"];
            if(path != null)
            {
                MainPicture.ImageUrl = "~/Galleri/" + path;
                MainPicture.Visible = true;
            }

            if (Session["uploaded"] as string != null)
            {
                MessagePlaceholder.Visible = true;
                Session["uploaded"] = null;
            }
        }

        protected void SendButton_Click(object sender, EventArgs e) //FileContent + FileName till SaveImages
        {
            Session["uploaded"] = Gallery.SaveImage(FileUploader.FileContent, FileUploader.FileName);

            Response.Redirect("http://localhost:1370/Default.aspx?name=" + Session["uploaded"] as string);
        }

        public IEnumerable<string> Thumbnailrepeater_GetData()
        {
            return Gallery.GetImageNames();
        }
    }
}
//okay, så. Varje gång man klickar uppload ska följande hända : Bilden laddas ut och SavePicture i Gallery.cs körs
//, Efter det skapas en ny Hyperlink i repeatern med den sista platsen (Senast tillagda bilden)

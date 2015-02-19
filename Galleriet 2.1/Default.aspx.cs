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

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            //okay, så. Varje gång man klickar uppload ska följande hända : Bilden laddas ut och SavePicture i Gallery.cs körs
            //, Efter det skapas en ny Hyperlink i repeatern med den sista platsen (Senast tillagda bilden
        }

        public System.Collections.IEnumerable Thumbnailrepeater_GetData()
        {
            return null;
        }
    }
}
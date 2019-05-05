using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmrutamClinic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HtmlWebViewSource VideoSource { get; set; }

        public HomePage ()
        {
            InitializeComponent();
            VideoSource = new HtmlWebViewSource();
            VideoSource.Html = @"<html><body>  <div style=' position: relative; padding-bottom: 56.25%; padding-top: 25px;'> <iframe width='560' height='315' src='https://www.youtube.com/embed/2Nwe82Cxsu4' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe></div> </body></html>";
        }

        private void BtnPhone_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:+919039123200"));
        }

        private void BtnWhatsApp_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://api.whatsapp.com/send?phone=919039123200"));
        }
    }
}
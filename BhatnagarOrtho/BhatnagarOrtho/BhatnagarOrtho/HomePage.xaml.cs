using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BhatnagarOrtho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage ()
        {
            InitializeComponent();
        }

        private void BtnPhone_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:+919993844645"));
        }

        private void BtnWhatsApp_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://api.whatsapp.com/send?phone=919993844645"));
        }
    }
}
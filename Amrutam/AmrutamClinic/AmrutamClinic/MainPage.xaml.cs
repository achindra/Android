using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmrutamClinic
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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

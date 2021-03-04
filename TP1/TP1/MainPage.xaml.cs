using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP1
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        private void HandleClick(object sender, EventArgs e)
        {
            i++;
            Share.Text = i.ToString();
        }
    }
}

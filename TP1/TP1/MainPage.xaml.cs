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
        int j = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            j++;
            Views.Text = j.ToString();
        }
        private void AddSharing(object sender, EventArgs e)
        {
            i++;
            Shares.Text = i.ToString();
        }
    }
}

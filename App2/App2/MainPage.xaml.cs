using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        int sayac = 0;
        private void onClick(object sender, EventArgs e)
        {
            sayac++;

            label1.Text = entry1.Text;
            buton1.Text = "Degisti";


            Button btn = (Button)sender;
            if (sayac % 2 == 1)
            {
                btn.BackgroundColor = Color.Yellow;
                BackgroundColor = Color.Blue;
                label1.TextColor = Color.Red;

            }
            else
            {
                btn.BackgroundColor = Color.Purple;
                BackgroundColor = Color.White;
                buton1.Text += "R";
            }
        }
    }
}

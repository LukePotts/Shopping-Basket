using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA
{
    public partial class ShoppingBasketSplashScreen : Form
    {        
        public ShoppingBasketSplashScreen()
        {
            InitializeComponent();
            SplashTimer.Interval = 1;
            SplashTimer.Start();
            SplashProgress.Maximum = 300;
        }
        BasketForm NewBasket = new BasketForm();

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if (SplashProgress.Value == SplashProgress.Maximum)
            {                
                NewBasket.Show();
                SplashTimer.Stop();
                this.Hide();
            }
            else
            {
                SplashProgress.Increment(1);
            }
            
        }
    }
}

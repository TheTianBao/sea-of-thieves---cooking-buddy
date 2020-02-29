using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sea_of_thieves___cooking_buddy
{
    
    public partial class FRMcookingbuddy : Form
    {
        public FRMcookingbuddy()
            
        {
            InitializeComponent();
        }
        

        #region "CMD"
        private void CMDcookFish_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            CMDcookFish.Enabled = false;
            CMDcookFishAbort.Enabled = true;
            LBLbasicFishStatus.ForeColor = Color.Green;
            TIMERbasicFish.Start();
        }

        private void CMDcookMeat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            CMDcookMeat.Enabled = false;
            CMDcookMeatAbort.Enabled = true;
            LBLbMeatStatus.ForeColor = Color.Green;
            TIMERbasicMeat.Start();
        }

        private void CMDcookTFish_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            CMDcookTFish.Enabled = false;
            CMDcookTFishAbort.Enabled = true;
            LBLtFischStatus.ForeColor = Color.Green;
            TIMERtrophyFish.Start();
        }

        private void CMDcookMMeat_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            CMDcookMMeat.Enabled = false;
            CMDcookMMeatAbort.Enabled = true;
            LBLmMeatStatus.ForeColor = Color.Green;
            TIMERmonsterMeat.Start();
        }


        //Abort Timer
        private void CMDcookFishAbort_Click(object sender, EventArgs e)
        {
            CMDcookFish.Enabled = true;
            CMDcookFishAbort.Enabled = false;
            LBLbasicFishStatus.ForeColor = Color.Red;
            TIMERbasicFish.Stop();
        }

        private void CMDcookMeatAbort_Click(object sender, EventArgs e)
        {
            CMDcookMeat.Enabled = true;
            CMDcookMeatAbort.Enabled = false;
            LBLbMeatStatus.ForeColor = Color.Red;
            TIMERbasicMeat.Stop();
        }

        private void CMDcookTFishAbort_Click(object sender, EventArgs e)
        {
            CMDcookTFish.Enabled = true;
            CMDcookTFishAbort.Enabled = false;
            LBLtFischStatus.ForeColor = Color.Red;
            TIMERtrophyFish.Stop();
        }

        private void CMDcookMMeatAbort_Click(object sender, EventArgs e)
        {
            CMDcookMMeat.Enabled = true;
            CMDcookMMeatAbort.Enabled = false;
            LBLmMeatStatus.ForeColor = Color.Red;
            TIMERmonsterMeat.Stop();
        }
        #endregion
        #region "Timer End"
        private void TIMERbasicFish_Tick(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            CMDcookFish.Enabled = true;
            CMDcookFishAbort.Enabled = false;
            TIMERbasicFish.Stop();
            LBLbasicFishStatus.ForeColor = Color.Red;
            //MessageBox.Show("The basic fish is finished.");
            System.IO.Stream SoundFile = Properties.Resources.Frying_pan_wav;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }
        private void TIMERbasicMeat_Tick(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            CMDcookMeat.Enabled = true;
            CMDcookMeatAbort.Enabled = false;
            TIMERbasicMeat.Stop();
            LBLbMeatStatus.ForeColor = Color.Red;
            //MessageBox.Show("The basic meat is finished.");
            System.IO.Stream SoundFile = Properties.Resources.Frying_pan_wav;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }

        private void TIMERtrophyFish_Tick(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            CMDcookTFish.Enabled = true;
            CMDcookTFishAbort.Enabled = false;
            TIMERtrophyFish.Stop();
            LBLtFischStatus.ForeColor = Color.Red;
            //MessageBox.Show("The trophy fish is finished.");
            System.IO.Stream SoundFile = Properties.Resources.Frying_pan_wav;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }

        private void TIMERmonsterMeat_Tick(object sender, EventArgs e)
        {
           //this.WindowState = FormWindowState.Normal;
            CMDcookMeat.Enabled = true;
            CMDcookMeatAbort.Enabled = false;
            TIMERmonsterMeat.Stop();
            LBLmMeatStatus.ForeColor = Color.Red;
            //MessageBox.Show("The monster meat is finished.");
            System.IO.Stream SoundFile = Properties.Resources.Frying_pan_wav;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }


        #endregion

        private void FRMcookingbuddy_Load(object sender, EventArgs e)
        {
            System.IO.Stream SoundFile = Properties.Resources.Frying_pan_wav;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(SoundFile);
            player.Play();
        }

        #region "CMS"
        private void button1_Click(object sender, EventArgs e)
        {
            CMS.Show(Control.MousePosition);
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TheTianBao/sea-of-thieves---cooking-buddy");
        }

        private void PayPal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/pools/c/8mS9cVkDz9");
        }

        private void Reddit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.reddit.com/r/Seaofthieves/");
        }

        private void Wiki_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://seaofthieves.fandom.com/wiki/Sea_of_Thieves_Wiki");
        }

        #endregion

        private void FRMcookingbuddy_KeyPress(object sender, KeyPressEventArgs e)
        {
            String Keypressed;

            Keypressed = e.KeyChar.ToString();

           
            if (Keypressed == "1")
            {
                CMDcookFish.PerformClick();
            }
            if (Keypressed == "2")
            {
                CMDcookMeat.PerformClick();
            }
            if (Keypressed == "3")
            {
                CMDcookTFish.PerformClick();
            }
            if (Keypressed == "4")
            {
                CMDcookMMeat.PerformClick();
            }


        }
    }
    }

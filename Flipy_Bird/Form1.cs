             using System;    
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flipy_Bird
{
    public partial class Form1 : Form
    {
        int boruhizi = 8;
        int gravity = 5;
        int scor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gametimerEvents(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            Boru_alt.Left -= boruhizi;
            Boru_üst.Left-=boruhizi;
            score.Text = "skor=" + scor;
            if (Boru_alt.Left<-150)
            {
                Boru_alt.Left = 800;
                scor++;
            }

            if (Boru_alt.Left<-180)
            {
                Boru_üst.Left = 950;
                scor++;
            }
            if (flappybird.Bounds.IntersectsWith(Boru_alt.Bounds) || flappybird.Bounds.IntersectsWith(Boru_üst.Bounds) || flappybird.Bounds.IntersectsWith(zemin.Bounds))
            { 
                endgame();
            }
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space) 
            {
                gravity = 15;
            }
        }

        private void endgame() 
        {
        
            gametimer.Stop();
            score.Text = "Game over !!!!";
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }

		
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using foreign = foreignlibary.Class1;


namespace _8Ball_Anwendung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hit_Click(object sender, EventArgs e)
        {
            //Inizialisierung von Variablen aus der GUI
            bool hit = true;
            int count = Int32.Parse(lb_count.Text);
            int hitBalls = Int32.Parse(touchedBalls.Text);
            string[] sinkedBallsS = elmBalls.Text.Split(',');
            int ansage = 0;//Int32.Parse(cb_ansage.SelectedItem.ToString());
            int[] sinkedBalls = new int[sinkedBallsS.Length];
            for (int i = 0; i < sinkedBalls.Length; i++)
            {
                sinkedBalls[i] = Int32.Parse(sinkedBallsS[i]);
            }

            //Kein Ball getroffen?
            if(hitBalls == 0 && sinkedBalls.Length == 0)
            {
                hit = false;
            }
            
            //Erster Stoss?
            if (count == 0)
            {
                Console.WriteLine(foreign.firstHit(count, hit, sinkedBalls));
                lb_count.Text = "1";
                lb_ansage.Visible = true;
                cb_ansage.Visible = true;
            }
            else
            {
                foreign.setAnsage(ansage);
                Console.WriteLine(foreign.stoss(hitBalls, sinkedBalls));
                lb_count.Text = count + 1 + "";

            }
           
        }
    }
}

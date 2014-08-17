using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubsan_X4
{
    public partial class Form1 : Form
    {

        int B = 50;
        int M = 75;
        int A = 100;


        public Form1()
        {
            InitializeComponent();
            

        }

 


        public void N(string X) {
            int a = Convert.ToInt32(X);

            
            if ((a < B)||(a==B)) {
                pcN.Image = Properties.Resources.N_NEGRA;
                
            }
            if (((a > B)&&(a<M))||(a==M)) {
                pcN.Image = Properties.Resources.N_AZUL;
              
            }
            if (((a >M) && (a < A) )|| (a ==A)){
                pcN.Image = Properties.Resources.N_ROJA;
                
            }
            pcN.Refresh();

        }

        public void S(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcS.Image = Properties.Resources.S_NEGRA;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcS.Image = Properties.Resources.S_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcS.Image = Properties.Resources.S_ROJA;

            }
            pcS.Refresh();
        }

        public void E(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcE.Image = Properties.Resources.E_NEGRO;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcE.Image = Properties.Resources.E_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcE.Image = Properties.Resources.E_ROJA;

            }
            pcE.Refresh();
        }

        public void O(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcO.Image = Properties.Resources.O_NEGRA;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcO.Image = Properties.Resources.O_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcO.Image = Properties.Resources.O_ROJA;

            }
            pcO.Refresh();
        }


        public void MOTORES() {
            int N=(Convert.ToInt32(txtN.Text)),S=(Convert.ToInt32(txtS.Text)),O=(Convert.ToInt32(txtO.Text)),E=(Convert.ToInt32(txtE.Text));

            /* Invertida */
            lblNO.Text = ((S + E) / 2).ToString();
            lblNE.Text = ((S + O) / 2).ToString();
            lblSO.Text = ((N + E) / 2).ToString();
            lblSE.Text = ((N + O) / 2).ToString();
        
            /* Encender Motores */
            NO(lblNO.Text);
            NE(lblNE.Text);
            SO(lblSO.Text);
            SE(lblSE.Text);

        }

        private void m2h_Scroll(object sender, EventArgs e)
        {
            m2H();
        }

        private void m1h_Scroll(object sender, EventArgs e)
        {
            m1H();
        }

        public void m1H()
        {
            int a = (Convert.ToInt32(m1h.Value.ToString()));
            int na = 100 - a;
            txtE.Text = (m1h.Value.ToString());
            txtO.Text = (na.ToString());
            O(txtO.Text); E(txtE.Text);
            MOTORES();

        }

        public void m2H()
        {

            int a = (Convert.ToInt32(m2h.Value.ToString()));
            int na = 100 - a;
            txtN.Text = (m2h.Value.ToString());
            txtS.Text = (na.ToString());
            N(txtN.Text); S(txtS.Text);
            MOTORES();

        }


     /* Motores */

        public void NO(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcNO.Image = Properties.Resources.No_NEGRA;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcNO.Image = Properties.Resources.No_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcNO.Image = Properties.Resources.No_ROJA;

            }
            pcNO.Refresh();
        }

        public void NE(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcNE.Image = Properties.Resources.Ne_NEGRO;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcNE.Image = Properties.Resources.Ne_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcNE.Image = Properties.Resources.Ne_ROJA;

            }
            pcNE.Refresh();
        }



        public void SO(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcSO.Image = Properties.Resources.So_NEGRO;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcSO.Image = Properties.Resources.So_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcSO.Image = Properties.Resources.So_ROJA;

            }
            pcSO.Refresh();
        }

        public void SE(string X)
        {
            int a = Convert.ToInt32(X);


            if ((a < B) || (a == B))
            {
                pcSE.Image = Properties.Resources.Se_NEGRA;

            }
            if (((a > B) && (a < M)) || (a == M))
            {
                pcSE.Image = Properties.Resources.Se_AZUL;

            }
            if (((a > M) && (a < A)) || (a == A))
            {
                pcSE.Image = Properties.Resources.Se_ROJA;

            }
            pcSE.Refresh();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

     

        private void TXTcontrol_KeyDown(object sender, KeyEventArgs e)
        {
            TXTcontrol.Text = "";

                  if (e.KeyCode == Keys.W)
                  {
                      try {
                          m2h.TabIndex = (m2h.Value)++;
                          m2H();
                      }
                      catch (Exception es)
                      {
                      }
                     
                  }

                  if (e.KeyCode == Keys.S)
                  {
                      try {
                          m2h.TabIndex = (m2h.Value)--;
                          m2H();
                      }
                      catch (Exception es)
                      {
                      }
                     
                  }

                  if (e.KeyCode == Keys.D)
                  {
                      
                      try {
                          m1h.TabIndex = (m1h.Value)++;
                          m1H();
                      }
                      catch (Exception es) {  
                      }
                  }

                  if (e.KeyCode == Keys.A)
                  {
                      try {
                          m1h.TabIndex = (m1h.Value)--;
                          m1H();
                      }
                      catch (Exception es)
                      {
                      }
                      
                  }




                  if (e.KeyCode == Keys.R)
                  {
                    
                          m1h.Value = 50;
                          
                          m2h.Value = 50;
                          
                      m1H();    
                      m2H();
                          

                  }


            

        }

        private void TXTcontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void TXTcontrol_TextChanged(object sender, EventArgs e)
        {
            TXTcontrol.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.TXTcontrol.Select();
                m1h.Enabled = false;
                m2h.Enabled = false;
                pnl_Controles.Visible = true;
            }
            else {

                this.TXTNADA.Select();
                m1h.Enabled = true;
                m2h.Enabled = true;
                pnl_Controles.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TXTNADA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m1h.Value = 50;

            m2h.Value = 50;

            m1H();
            m2H();
        }




    }
}

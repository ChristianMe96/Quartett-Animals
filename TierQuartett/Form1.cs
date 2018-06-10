using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TierQuartett
{
    public partial class Form1 : Form
    {
        Functionality functionality = new Functionality();
        string player1;
        string player2;
        int maxCards = 2;
        int currentPlayer;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if(!string.IsNullOrWhiteSpace(tbxNamePl1.Text) && !string.IsNullOrWhiteSpace(tbxNamePl2.Text))
            {
                Random rand = new Random();

                int firstPlayer = rand.Next(1, 3);


                if (firstPlayer == 1)
                {
                    MessageBox.Show(player1 + " startet.");
                    player1Pnl.Visible = true;
                }
                else if (firstPlayer == 2)
                {
                    MessageBox.Show(player2 + " startet.");
                    player2Pnl.Visible = true;

                }

                fillAnimalFields(firstPlayer);
                btnStart.Visible = false;

            }
            else
            {
                MessageBox.Show("Erst die Benutzernamen eingeben");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fillAnimalFields(int currentPlayer)
        {
            // Value for testing

            Random rand = new Random();
            int random = rand.Next(1, maxCards);

            if(currentPlayer == 1)
            {
                List<Animal> player1Cards = functionality.DistributeCards();

                lblAnimalPl1.Text = player1Cards[random].Name;
                tbxSpeedPl1.Text = Convert.ToString(player1Cards[random].Speed);
                tbxWeightPl1.Text = Convert.ToString(player1Cards[random].Weight);
                tbxAgePl1.Text = Convert.ToString(player1Cards[random].Age);
                tbxBodySizePl1.Text = Convert.ToString(player1Cards[random].BodySize);

                if(btnStart.Visible != false)
                {
                    btnReadyPl1.Visible = true;
                }
                
            } 

            if(currentPlayer == 2)
            {
                List<Animal> player2Cards = functionality.DistributeCards();

                lblAnimalPl2.Text = player2Cards[random].Name;
                tbxSpeedPl2.Text = Convert.ToString(player2Cards[random].Speed);
                tbxWeightPl2.Text = Convert.ToString(player2Cards[random].Weight);
                tbxAgePl2.Text = Convert.ToString(player2Cards[random].Age);
                tbxBodySizePl2.Text = Convert.ToString(player2Cards[random].BodySize);

                if (btnStart.Visible != false)
                {
                    btnReadyPl2.Visible = true;
                }
            }

  

        }

        private void btnNamePl1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tbxNamePl1.Text))
            {
                tbxNamePl1.ReadOnly = true;
                player1 = tbxNamePl1.Text;

                lblNamePl1.Visible = false;
                btnNamePl1.Visible = false;
            }
            else
            {
                MessageBox.Show("Bitte einen Spielernamen angeben", "Achtung");
            }

        }

        private void btnNamePl2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxNamePl2.Text))
            {
                tbxNamePl2.ReadOnly = true;
                player2 = tbxNamePl2.Text;

                lblNamePl2.Visible = false;
                btnNamePl2.Visible = false;
            } else
            {
                MessageBox.Show("Bitte einen Spielernamen angeben", "Achtung");
            }

        }

        private void btnReadyPl1_Click(object sender, EventArgs e)
        {
            var checkedButton = player1Pnl.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            
            
            

            if (checkedButton != null && !string.IsNullOrWhiteSpace(tbxSpeedPl1.Text))
            {
                currentPlayer = 2;
                tbxFight.Visible = true;
                player2Pnl.Visible = true;
                player1Pnl.Visible = false;
                fillAnimalFields(currentPlayer);
                MessageBox.Show(player2 + " ist an der Reihe");
            }
            else
            {
                MessageBox.Show("Bitte eine Eigenschaft auswählen");
            }

        }

        private void btnReadyPl2_Click(object sender, EventArgs e)
        {
            var checkedButton = player2Pnl.Controls.OfType<RadioButton>()
                                 .FirstOrDefault(r => r.Checked);

            if (checkedButton != null && !string.IsNullOrWhiteSpace(tbxSpeedPl2.Text))
            {
                currentPlayer = 1;
                tbxFight.Visible = true;
                player1Pnl.Visible = true;
                player2Pnl.Visible = false;
                fillAnimalFields(currentPlayer);
                MessageBox.Show(player1 + " ist an der Reihe");
               
            }
            else
            {
                MessageBox.Show("Bitte eine Eigenschaft auswählen");
            }

           

        }

        private void tbxFight_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbxSpeedPl1.Text) && !string.IsNullOrWhiteSpace(tbxSpeedPl2.Text))
            {
                tbxFight.Visible = false;

                // TODO-- Ab hier muss die kampf logik hin - functionality.cardsFight
                // Nach der Kampf logik kriegt der gewinner die karte vom verlierer und seine eigen in seine Liste und die Karte vom verlierer aus seiner Liste raus
                // Dann muss die ich sage mal "Runde" beendet werden und alle Grafik sachen resettet werden (Nurnoch der "Nächste Runde" starten knopf darf angezeigt werdeen

                resetGUI();
            }
            else
            {
                MessageBox.Show("Jeder Spieler muss eine Eigenschaft auswählen!");
            }

        }

        private void resetGUI()
        {
            btnStart.Visible = true;
            btnStart.Text = "Nächste Runde";
        }
    }
}

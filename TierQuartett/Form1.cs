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
        //Instanzierung der Functionality
        Functionality functionality = new Functionality();

        //Instanzierung der Spieler
        public static Spieler player1 = new Spieler();
        public static Spieler player2 = new Spieler();

        //Der Spieler der gerade am Zug ist
        int currentPlayer;

        //gewinner der Runde
        int winner = 0;

        //Die ausgewählten Tiere der Spieler
        Animal player1CurrentAnimal;
        Animal player2CurrentAnimal;

        //Die ausgewählten Werte der Spieler
        string player1Value;
        string player2Value;

        //Die Werte der Gerade gezeigten Karte
        Dictionary<string, string> animalProperties = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Checked das Namen eingegeben wurden
            if (!string.IsNullOrWhiteSpace(player1.Name) && !string.IsNullOrWhiteSpace(player2.Name))
            {
                Random rand = new Random();

                int firstPlayer = rand.Next(1, 3);


                //Wenn ein Gewinner fest steht soll dieser auch wieder dran kommen
                if(winner != 0) 
                {
                    if (winner == 1) 
                    {
                        MessageBox.Show(player1.Name + " startet.");
                        player1Pnl.Visible = true;
                    } else if (winner == 2)
                    {
                        MessageBox.Show(player2.Name + " startet.");
                        player2Pnl.Visible = true;
                    }
                }
                else if (firstPlayer == 1)
                {
                    MessageBox.Show(player1.Name + " startet.");
                    player1Pnl.Visible = true;
                }
                else if (firstPlayer == 2)
                {
                    MessageBox.Show(player2.Name + " startet.");
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

        //Füllt die Tier Felder
        private void fillAnimalFields(int currentPlayer)
        {
            Random rand = new Random();

            if (currentPlayer == 1)
            {
                int random = rand.Next(0, player1.Deck.Count());

                // Anzahl der Karten im Stapel zählen und in der Form anzeigen
                tbxPl1CardCount.Text = Convert.ToString(player1.Deck.Count());

                player1CurrentAnimal = player1.Deck[random];

                FillPlayer1Fields(random);

                if (btnStart.Visible != false)
                {
                    btnReadyPl1.Visible = true;
                }

            }

            if (currentPlayer == 2)
            {
                int random = rand.Next(0, player2.Deck.Count());

                // Anzahl der Karten im Stapel zählen und in der Form anzeigen
                tbxPl2CardCount.Text = Convert.ToString(player2.Deck.Count());

                player2CurrentAnimal = player2.Deck[random];

                FillPlayer2Fields(random);

                if (btnStart.Visible != false)
                {
                    btnReadyPl2.Visible = true;
                }
            }



        }

       
        private void btnNamePl1_Click(object sender, EventArgs e)
        {
            //Setzt den Namen vom Spieler
            if (!string.IsNullOrWhiteSpace(tbxNamePl1.Text))
            {
                tbxNamePl1.ReadOnly = true;
                player1.Name = tbxNamePl1.Text;

                lblNamePl1.Visible = false;
                btnNamePl1.Visible = false;

                // Stapel für Spieler 1 generieren
                player1.Deck = functionality.DistributeCards();
            }
            else
            {
                MessageBox.Show("Bitte einen Spielernamen angeben", "Achtung");
            }

        }

        private void btnNamePl2_Click(object sender, EventArgs e)
        {
            //Setzt den Namen vom Spieler
            if (!string.IsNullOrWhiteSpace(tbxNamePl2.Text))
            {
                tbxNamePl2.ReadOnly = true;
                player2.Name = tbxNamePl2.Text;

                lblNamePl2.Visible = false;
                btnNamePl2.Visible = false;

                // Stapel für Spieler 2 generieren
                player2.Deck = functionality.DistributeCards();
            } else
            {
                MessageBox.Show("Bitte einen Spielernamen angeben", "Achtung");
            }

        }

        private void btnReadyPl1_Click(object sender, EventArgs e)
        {
            currentPlayer = 1;
            var checkedButton = player1Pnl.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            // Überprüft ob eine Eigenschaft ausgewählt wurde
            if (checkedButton != null)
            {
                player1Value = animalProperties[checkedButton.Text];
                // Hier wählt man die selbe Eigenschaft für den anderen Spieler
                CheckClickedButton(currentPlayer, checkedButton.Name);
            }
            // Überprüft ob Beide Spieler einen Wert ausgefüllt haben, wenn ja erlaube den Kampf
            if (player1Value != null && player2Value != null)
            {
                btnFight.Visible = true;
            }
            else if (checkedButton != null && !string.IsNullOrWhiteSpace(tbxSpeedPl1.Text))
            {
                currentPlayer = 2;
                player2Pnl.Visible = true;
                btnReadyPl2.Visible = true;
                player1Pnl.Visible = false;
                fillAnimalFields(currentPlayer);
                MessageBox.Show(player2.Name + " ist an der Reihe");
            }
            else
            {
                MessageBox.Show("Bitte eine Eigenschaft auswählen");
            }

        }

        private void btnReadyPl2_Click(object sender, EventArgs e)
        {
            currentPlayer = 2;
            var checkedButton = player2Pnl.Controls.OfType<RadioButton>()
                                 .FirstOrDefault(r => r.Checked);

            // Überprüft ob eine Eigenschaft ausgewählt wurde
            if (checkedButton != null)
            {
                player2Value = animalProperties[checkedButton.Text];
                // Hier wählt man die selbe Eigenschaft für den anderen Spieler
                CheckClickedButton(currentPlayer, checkedButton.Name);
            }


            // Überprüft ob Beide Spieler einen Wert ausgefüllt haben, wenn ja erlaube den Kampf
            if (player1Value != null && player2Value != null)
                {
                    btnFight.Visible = true;
                }
                else if (checkedButton != null && !string.IsNullOrWhiteSpace(tbxSpeedPl2.Text))
                {
                    currentPlayer = 1;
                    player1Pnl.Visible = true;
                    btnReadyPl1.Visible = true;
                    player2Pnl.Visible = false;
                    fillAnimalFields(currentPlayer);

                    MessageBox.Show(player1.Name + " ist an der Reihe");

                }
                else
                {
                    MessageBox.Show("Bitte eine Eigenschaft auswählen");
                }



        }
        //player1Value / player2Value sind die ausgewählten werte von den einzelnen Spielern
        private void tbxFight_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(player1Value) && !string.IsNullOrWhiteSpace(player2Value))
            {
                //nur ein Test
                MessageBox.Show(player1Value + " VS " + player2Value);

                // winner - Legende: 0 = unentschieden, 1 = player1, 2 = player 2
                winner = functionality.fightCards(player1CurrentAnimal, Convert.ToDouble(player1Value.Split(' ')[0]), player2CurrentAnimal, Convert.ToDouble(player2Value.Split(' ')[0]));

                // Zähler aktualisieren und in der Form anzeigen
                tbxPl1CardCount.Text = Convert.ToString(player1.Deck.Count());
                tbxPl2CardCount.Text = Convert.ToString(player2.Deck.Count());

                //Zeige den Gewinner an
                DisplayWinner(winner);

                if(player1.Deck.Count() == 0)
                {
                    DialogResult dr = MessageBox.Show(player1.Name + " hat das gesamte Spiel gewonnen!");

                    if(dr == DialogResult.OK)
                    {
                        this.Close();
                    }

            
                } else if (player2.Deck.Count() == 0)
                {
                    DialogResult dr = MessageBox.Show(player2 + " hat das gesamte Spiel gewonnen!");

                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                } else
                {
                    btnFight.Visible = false;
                    player1Value = null;
                    player2Value = null;
                    ResetGUI();
                }

            }
            else
            {
                MessageBox.Show("Jeder Spieler muss eine Eigenschaft auswählen!");
            }

        }

        // Diese Methode setzt alle Werte und alle Windows Forms Steuerelemente zurück zu ihren Anfangszustand
        private void ResetGUI()
        {

            player1Pnl.Visible = false;
            player2Pnl.Visible = false;
            btnStart.Visible = true;
            btnStart.Text = "Nächste Runde";
        }

        // Diese Methode wählt die selbe Eigenschaft für den anderen Spieler
        public void CheckClickedButton(int currentPlayer, string clickedButton) {

            if(currentPlayer == 1)
            {
                switch (clickedButton)
                {
                    case "rdbSpeedPl1":
                        rdbWeightPl2.Enabled = false;
                        rdbAgePl2.Enabled = false;
                        rdbBodySizePl2.Enabled = false;
                        rdbSpeedPl2.Checked = true;
                        break;
                    case "rdbWeightPl1":
                        rdbSpeedPl2.Enabled = false;
                        rdbAgePl2.Enabled = false;
                        rdbBodySizePl2.Enabled = false;
                        rdbWeightPl2.Checked = true;
                        break;
                    case "rdbAgePl1":
                        rdbSpeedPl2.Enabled = false;
                        rdbWeightPl2.Enabled = false;
                        rdbBodySizePl2.Enabled = false;
                        rdbAgePl2.Checked = true;
                        break;
                    case "rdbBodySizePl1":
                        rdbSpeedPl2.Enabled = false;
                        rdbWeightPl2.Enabled = false;
                        rdbAgePl2.Enabled = false;
                        rdbBodySizePl2.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Hier ist was schief gelaufen");
                        break;
                }
            }
            else if(currentPlayer == 2)
            {

                switch (clickedButton)
                {
                    case "rdbSpeedPl2":
                        rdbWeightPl1.Enabled = false;
                        rdbAgePl1.Enabled = false;
                        rdbBodySizePl1.Enabled = false;
                        rdbSpeedPl1.Checked = true;
                        break;
                    case "rdbWeightPl2":
                        rdbSpeedPl1.Enabled = false;
                        rdbAgePl1.Enabled = false;
                        rdbBodySizePl1.Enabled = false;
                        rdbWeightPl1.Checked = true;
                        break;
                    case "rdbAgePl2":
                        rdbSpeedPl1.Enabled = false;
                        rdbWeightPl1.Enabled = false;
                        rdbBodySizePl1.Enabled = false;
                        rdbAgePl1.Checked = true;
                        break;
                    case "rdbBodySizePl2":
                        rdbSpeedPl1.Enabled = false;
                        rdbWeightPl1.Enabled = false;
                        rdbAgePl1.Enabled = false;
                        rdbBodySizePl1.Checked = true;
                        break;
                    default:
                        MessageBox.Show("Hier ist was schief gelaufen");
                        break;
                }
            }

        }
      

        //Gibt den Gewinner der Runde aus
        public void DisplayWinner(int winner)
        {
            DialogResult dr = new DialogResult();

            if (winner == 1)
            {
                dr = MessageBox.Show(player1.Name + " hat gewonnen!");
            } 
            else if(winner == 2 )
            {
                dr = MessageBox.Show(player2.Name +" hat gewonnen!");
                
            } else if(winner == 0)
            {
                dr = MessageBox.Show("Das war ein Unentschieden!");
            }

            if (dr == DialogResult.OK)
            {
                ResetAll();
            }

        }

        //Resetet alle RadioButtons
        public void ResetAll()
        {
            foreach (Control control in this.player1Pnl.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radiobutton = (RadioButton)control;
                    radiobutton.Enabled = true;
                    radiobutton.Checked = false;
                }
            }

            foreach (Control control in this.player2Pnl.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radiobutton = (RadioButton)control;
                    radiobutton.Enabled = true;
                    radiobutton.Checked = false;
                }
            }

            //Fill Player Card Counter
            tbxPl1CardCount.Text = Convert.ToString(player1.Deck.Count());
            tbxPl2CardCount.Text = Convert.ToString(player2.Deck.Count());

            // Fill Player Names
            tbxNamePl1.Text = player1.Name;
            tbxNamePl2.Text = player2.Name;

        }
        public void FillPlayer1Fields(int random)
        {
            // Füllt die Eigenschaften der Karte in die Textboxen
            lblAnimalPl1.Text = player1.Deck[random].Name;
            pctBoxPl1.Image = Image.FromFile(player1.Deck[random].Image);
            tbxSpeedPl1.Text = Convert.ToString(player1.Deck[random].Speed + " km/h");
            tbxWeightPl1.Text = Convert.ToString(player1.Deck[random].Weight + " kg");
            tbxAgePl1.Text = Convert.ToString(player1.Deck[random].Age + " Jahre");
            tbxBodySizePl1.Text = Convert.ToString(player1.Deck[random].BodySize + " Meter");

            animalProperties["Speed"] = tbxSpeedPl1.Text;
            animalProperties["Weight"] = tbxWeightPl1.Text;
            animalProperties["Age"] = tbxAgePl1.Text;
            animalProperties["BodySize"] = tbxBodySizePl1.Text;
        }

        public void FillPlayer2Fields(int random)
        {
            // Füllt die Eigenschaften der Karte in die Textboxen
            lblAnimalPl2.Text = player2.Deck[random].Name;
            pctBoxPl2.Image = Image.FromFile(player2.Deck[random].Image);
            tbxSpeedPl2.Text = Convert.ToString(player2.Deck[random].Speed + " km/h");
            tbxWeightPl2.Text = Convert.ToString(player2.Deck[random].Weight + " kg");
            tbxAgePl2.Text = Convert.ToString(player2.Deck[random].Age + " Jahre");
            tbxBodySizePl2.Text = Convert.ToString(player2.Deck[random].BodySize + " Meter");

            animalProperties["Speed"] = tbxSpeedPl2.Text;
            animalProperties["Weight"] = tbxWeightPl2.Text;
            animalProperties["Age"] = tbxAgePl2.Text;
            animalProperties["BodySize"] = tbxBodySizePl2.Text;
        }
    }
}

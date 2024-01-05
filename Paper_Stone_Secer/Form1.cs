using Paper_Stone_Secer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Stone_Secer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum enGameChoise { enPaper=1,enStone=2,enSecer=3};

        enum enWhoWinner{ enPlayer1=1,enComputer=2, enDraw = 3}

        struct stRoundInfo
        {
            public int Plyer1WinTimes;
            public int ComputerWinTimes;
            public int stRoundNumber;
            public string stWinnerName;
            public enWhoWinner stWinner;
            public enGameChoise Player1Choise;
            public enGameChoise ComputerChoise;
        }
       
        stRoundInfo RoundInfo;

      

        void TurnOnAllButtons()
        {
            btPaper.Enabled = true;
            btStone.Enabled = true;
            btSecer.Enabled = true;
            btPaper.BackColor = Color.Gold;
            btStone.BackColor = Color.Gold;
            btSecer.BackColor = Color.Gold;

        }
        void TurnOfAllButtons()
        {
            btPaper.Enabled = false;
            btStone.Enabled = false;
            btSecer.Enabled = false;
            btPaper.BackColor = Color.White;
            btStone.BackColor = Color.White;
            btSecer.BackColor = Color.White;

        }
        void Player1Turn()
        {
            lblWhoTurn.Text = "Player1 Turn";
            TurnOnAllButtons();
           
        }
       
        int GenerateRandomNumber(int From,int To)
        {
            Random random = new Random();
            int rand=random.Next(From,To);
            return rand;
        }
        void ComputerTurn()
        {
            pbLoading.Visible = true;


            RoundInfo.ComputerChoise = (enGameChoise)GenerateRandomNumber(1, 3);
            switch (RoundInfo.ComputerChoise)
            {
                case enGameChoise.enPaper:
                    pbComputer.Image = Resources.handComputer;
                    break;
                case enGameChoise.enSecer:
                    pbComputer.Image = Resources.scissorsComputer;
                    break;
                case enGameChoise.enStone:
                    pbComputer.Image = Resources.Rock;
                    break;
            }
            RoundInfo.stWinner = WhoWinTheRound();
            ShowScore();
            TurnOnAllButtons();
            lblWhoTurn.Text = "Player1 Turn";
            RoundInfo.stRoundNumber += 1;
            IsEndOfRounds();




        }
        enWhoWinner WhoWinTheRound()
        {
            if(RoundInfo.Player1Choise == RoundInfo.ComputerChoise)
            {
                return enWhoWinner.enDraw;
            }
            switch(RoundInfo.Player1Choise)
            {
                case enGameChoise.enPaper:
                    if(RoundInfo.ComputerChoise == enGameChoise.enSecer)
                    {
                        return enWhoWinner.enComputer;
                    }
                    break;
                case enGameChoise.enStone:
                    if (RoundInfo.ComputerChoise == enGameChoise.enPaper)
                    {
                        return enWhoWinner.enComputer;
                    }
                    break;
                case enGameChoise.enSecer:
                    if (RoundInfo.ComputerChoise == enGameChoise.enStone)
                    {
                        return enWhoWinner.enComputer;
                    }
                    break;
            }
            return enWhoWinner.enPlayer1;
        }
        void StartGame()
        {
                
                Player1Turn();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            plNumberOfRound.Visible = false;
            StartGame();
            btStart.Visible = false;
        }
        void IsEndOfRounds()
        {
            
            if(RoundInfo.stRoundNumber> cbNumberOfRound.SelectedIndex)
            {
                if(MessageBox.Show("انتهت اللعبه هل تريد اللعب مجددا","العب مجداا",MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    RoundInfo.stRoundNumber = 0;
                    RoundInfo.ComputerWinTimes = 0;
                    RoundInfo.Plyer1WinTimes = 0;
                    lblComputerScore.Text = "Computer 0";
                    lblPlayer1Score.Text = "Player1 0";
                    plNumberOfRound.Visible=true;
                    btStart.Enabled=true;
                    btStart.Visible=true;


                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                return;
            }
            
        }

        private void btPaper_Click(object sender, EventArgs e)
        {
            lblWhoTurn.Text = "Computer Turn";

            RoundInfo.Player1Choise = enGameChoise.enPaper;
            pbPlayer1.Image = Resources.handPlayer1;
            TurnOfAllButtons();
            pbComputer.Image = Resources.xo;

            ComputerTurn();



        }

        private void btStone_Click(object sender, EventArgs e)
        {

            lblWhoTurn.Text = "Computer Turn";

            RoundInfo.Player1Choise = enGameChoise.enStone;
            pbPlayer1.Image = Resources.Rock;
            TurnOfAllButtons();
            pbComputer.Image = Resources.xo;

            ComputerTurn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNumberOfRound.SelectedIndex = 3;
        }
        void ShowScore()
        {
            if (RoundInfo.stWinner == enWhoWinner.enPlayer1)
            {
                RoundInfo.stWinnerName = "Player1";

                RoundInfo.Plyer1WinTimes += 1;
                lblPlayer1Score.Text = "Player1 " + RoundInfo.Plyer1WinTimes.ToString();
                lblWhoWinRound.Text = RoundInfo.stWinnerName;
            }
            else if(RoundInfo.stWinner == enWhoWinner.enComputer)
            {
                RoundInfo.stWinnerName = "Computer";
                RoundInfo.ComputerWinTimes += 1;
                lblComputerScore.Text = "Computer " + RoundInfo.ComputerWinTimes.ToString();
                lblWhoWinRound.Text = RoundInfo.stWinnerName;
            }
            else
            {
                lblWhoWinRound.Text = "Draw";
            }
        }
        private void btSecer_Click(object sender, EventArgs e)
        {

            lblWhoTurn.Text = "Computer Turn";

            RoundInfo.Player1Choise = enGameChoise.enSecer;
            pbPlayer1.Image = Resources.seissorPlayer1;
            TurnOfAllButtons();
            pbComputer.Image = Resources.xo;

            ComputerTurn();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void plNumberOfRound_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

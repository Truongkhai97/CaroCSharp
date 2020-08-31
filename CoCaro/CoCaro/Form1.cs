using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class board : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public board()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(pnlBanCo,ptbAvatar);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            ChessBoard.drawChess();
         
            prbDemNguoc.Step = Cons.step;
            prbDemNguoc.Maximum=Cons.time;

            timerThoiGian.Interval = Cons.interval;

            //timerThoiGian.Start();
        }

        private void EndGame()
        {
            pnlBanCo.Enabled = false;
            timerThoiGian.Stop();
            MessageBox.Show("Kết thúc game !");
        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerThoiGian.Start();
            prbDemNguoc.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            //Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            prbDemNguoc.Value = 0;
            timerThoiGian.Stop();
            ChessBoard.drawChess();
        }


        //private int turn=0;

        //public int turn
        //{
        //    get
        //    {
        //        return turn;
        //    }

        //    set
        //    {
        //        turn = value;
        //    }
        //}

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    btn.Text = "X";
        //    if (turn == 0)
        //    {
        //        btn.Text = "X";

        //        turn = 1;
        //    }
        //    else if (turn == 1)
        //    {
        //        btn.Text = "O";
        //        turn = 0;
        //    }
        //}
        /*
        if (turn = 1)
            this.BackgroundImage = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-1.jpg");
        else (turn = 0)
            this.BackgroundImage = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-2.jpg");


        //btn.BackgroundImage = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-2.jpg");
    }
    */
        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerThoiGian_Tick(object sender, EventArgs e)
        {
            prbDemNguoc.PerformStep();
            if (prbDemNguoc.Value >= prbDemNguoc.Maximum)
            {
                EndGame();
            }
        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prbDemNguoc_Click(object sender, EventArgs e)
        {

        }

        private void pnlTrangThai_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

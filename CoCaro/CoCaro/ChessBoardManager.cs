using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get
            {
                return chessBoard;
            }

            set
            {
                chessBoard = value;
            }
        }

        public List<Player> Player
        {
            get
            {
                return player;
            }

            set
            {
                player = value;
            }
        }

        public int CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }

            set
            {
                currentPlayer = value;
            }
        }

        public PictureBox PtbAvatar
        {
            get
            {
                return ptbAvatar;
            }

            set
            {
                ptbAvatar = value;
            }
        }

        public List<List<Button>> Matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                matrix = value;
            }
        }

        private List<Player> player;
        private int currentPlayer;
        private PictureBox ptbAvatar;

        List<List<Button>> matrix;

        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, PictureBox ptbAvatar)
        {
            this.ChessBoard = chessBoard;
            this.PtbAvatar = ptbAvatar;
            this.Player = new List<Player>()
            {
                new Player("Player1",Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\x-letter.png")),
                new Player("Player2",Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\o-letter1.png"))
            };


        }
        #endregion

        #region Methods
        public void drawChess()
        {
            chessBoard.Enabled = true;
            chessBoard.Controls.Clear();
            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.chess_row; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.chess_col; j++)
                {
                    Button btn = new Button()
                    {
                        Height = Cons.chess_Height,
                        Width = Cons.chess_Width,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;

                    ChessBoard.Controls.Add(btn);
                    matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.chess_Height);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        //Ham tim nuoc di tot nhat
        //int currentMove, bestMove;
        //public int findBestMove(Panel chessBoard)
        //{
        //    foreach (Button btn)
        //    {
        //        if (btn.BackgroundImage == null)
        //        {
        //            if (currentMove > bestMove)
        //            {
        //                bestMove = currentMove;
        //            }
        //        }
        //    }
        //    return bestMove;
        //}

        ////Thuat toan minimax
        //int bestValue;
        //public void minimax(Panel chessBoard)
        //{
        //    if(currentPlayer=0)
        //    {
        //        bestValue = -100;
        //        foreach(Button btn)
        //        {
        //            if
        //        }
        //    }
        //}

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null) return;
            Mark(btn);
            ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new EventArgs());

            if (isEndGame(btn))
            {
                EndGame();
            }


            //if ((btn.Text == "X") || (btn.Text == "O")) return;
            //if (CurrentPlayer == 0)
            //{
            //    btn.Text = "X";
            //    ptbAvatar.Image = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-1.jpg");
            //    CurrentPlayer = 1;
            //}
            //else if (CurrentPlayer == 1)
            //{
            //    btn.Text = "O";
            //    ptbAvatar.Image = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-2.jpg");

            //    CurrentPlayer = 0;
            //}
        }

        private void EndGame()
        {
            if (endedGame != null)
            {
                endedGame(this, new EventArgs());
            }

            //if (currentPlayer == 0)
            //    MessageBox.Show("You win !");
            //else if (currentPlayer == 1)
            //    MessageBox.Show("You lose !");
        }

        private bool isEndGame(Button btn)
        {
            return isEndGameHorizontal(btn) || isEndGamePrimary(btn) || isEndGameVertical(btn) || isEndGameSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);
            return point;
        }

        private bool isEndGameHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.chess_col; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else break;
            }
            return countLeft + countRight == 5;

        }

        private bool isEndGameVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Cons.chess_row; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndGamePrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTopPrimary = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.Y - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTopPrimary++;
                }
                else break;
            }

            int countBottomPrimary = 0;
            for (int i = 1; i <= Cons.chess_col - point.X; i++)
            {
                if (point.Y + i >= Cons.chess_row || point.X + i >= Cons.chess_col)
                    break;
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottomPrimary++;
                }
                else break;
            }
            return countTopPrimary + countBottomPrimary == 5;

        }

        private bool isEndGameSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            //int countTopSub = 0;
            //for (int i = 0; i <= point.X; i++)
            //{
            //    if (point.X + i > Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
            //        break;

            //    if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
            //    {
            //        countTop++;
            //    }
            //    else
            //        break;
            //}

            int countTopSub = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.Y - i < 0 || point.X + i >= Cons.chess_col)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTopSub++;
                }
                else break;
            }

            int countBottomSub = 0;
            for (int i = 1; i <= Cons.chess_col - point.X; i++)
            {
                if (point.Y + i >= Cons.chess_row || point.X - i < 0)
                    break;
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottomSub++;
                }
                else break;
            }
            return countTopSub + countBottomSub == 5;
        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        //private void playervsCom(Panel chessBoard)
        //{
        //    drawChess();

        //}

        private void ChangePlayer()
        {
            ptbAvatar.Image = Player[CurrentPlayer].Mark;
            if (CurrentPlayer == 0)
                ptbAvatar.Image = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-1.jpg");
            else
                ptbAvatar.Image = Image.FromFile("C:\\Users\\Truon\\OneDrive\\documents\\visual studio 2015\\Projects\\CoCaro\\CoCaro\\Resources\\player-2.jpg");

        }
        #endregion

        //#region AI
        //private long[] MangDienTanCong = new long[7] { 0, 3, 24, 192, 1536, 12288, 98304 };
        //private long[] MangPhongNgu = new long[7] { 0, 1, 9, 81, 729, 6561, 59049 };

        //public void KhoiDongComputer(Panel chessBoard, Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    if (currentPlayer == 0)
        //    {
        //        DanhCo(point.X / 2, point.Y / 2, chessBoard);
        //    }
        //    else
        //    {
        //        btn = timKiemNuocDi();
        //        DanhCo(point.X, point.Y, chessBoard);
        //    }

        //}

        //private void DanhCo()
        //{

        //}

        //private Button timKiemNuocDi()
        //{
        //    Button btnResult = new Button();
        //    long diemMax = 0;
        //    for (int i = 0; i < Cons.chess_col; i++)
        //        for (int j = 0; j < Cons.chess_row; j++)
        //        {
        //            if (Matrix[i][j].BackgroundImage == null)
        //            {
        //                long diemTanCong = diemTanCong_Ngang(btn) + diemTanCong_Doc(btn) + diemTanCong_CheoChinh(btn) + diemTanCong_CheoPhu(btn);
        //                long diemPhongNgu = diemPhongNgu_Ngang(btn) + diemPhongNgu_Doc(btn) + diemPhongNgu_CheoChinh(btn) + diemPhongNgu_CheoPhu(btn);
        //            }
        //        }
        //    return btnResult;
        //}

        //private long diemTanCong_Ngang(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    long diemTC = 0;
        //    int soQuanTa = 0;
        //    int soQuanDich = 0;
        //    for(int dem=0;dem<6&&point.X+dem<Cons.chess_col)
        //    {
        //        if (Matrix[i][j].BackgroundImage == btn.BackgroundImage)
        //            soQuanTa++;
        //    }

        //    return tongDiem;
        //}
        //private long diemTanCong_Doc(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //private long diemTanCong_CheoChinh(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //private long diemTanCong_CheoPhu(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //private long diemPhongNgu_Ngang(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //private long diemPhongNgu_Doc(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //private long diemPhongNgu_CheoChinh(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //private long diemPhongNgu_CheoPhu(Button btn)
        //{
        //    Point point = GetChessPoint(btn);
        //    long tongDiem = 0;
        //    return tongDiem;
        //}
        //#endregion


    }
}


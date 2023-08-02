using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO
{
    public partial class Form1 : Form
    {
        private const int _boardSize = 20;
        private int[,] _board = new int[_boardSize, _boardSize];
        private int _turn = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    _board[i, j] = 0;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    _board[i, j] = 0;
                }
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    if (_board[i, j] == 1)
                    {
                        e.Graphics.FillEllipse(System.Drawing.Brushes.Red, i * 30, j * 30, 30, 30);
                    }
                    else if (_board[i, j] == 2)
                    {
                        e.Graphics.FillEllipse(System.Drawing.Brushes.Blue, i * 30, j * 30, 30, 30);
                    }
                }
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / 30;
            int y = e.Y / 30;

            if (_board[x, y] == 0)
            {
                _board[x, y] = _turn;

                if (_turn == 1)
                {
                    _turn = 2;
                }
                else
                {
                    _turn = 1;
                }
            }

            Panel.Invalidate();
        }

 
    }
}

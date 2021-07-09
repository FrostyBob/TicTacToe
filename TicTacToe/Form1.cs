using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static class Variables
        {
            public static readonly System.Drawing.Image X = Properties.Resources.X;
            public static readonly System.Drawing.Image O = Properties.Resources.O;
            public static int counter = 0;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            PictureBox ClickedBox = sender as PictureBox;
            if (ClickedBox.Image == null)
            {
                Variables.counter++;
                if (Variables.counter % 2 == 0)
                {
                    ClickedBox.Image = Variables.X;
                    CheckVictory(Variables.X, 'X');
                }
                else
                {
                    ClickedBox.Image = Variables.O;
                    CheckVictory(Variables.O, 'O');
                }
            }
        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {

            ForEachBox("reset");
            WinsTextBox.Text = null;
            Variables.counter = 0;
        }

        private void ForEachBox(string edit)
        {

            PictureBox[] squares = new PictureBox[9] { Box1, Box2, Box3, Box4, Box5, Box6, Box7, Box8, Box9 };

            foreach (PictureBox box in squares)
            {
                if (edit == "reset")
                {
                    box.Image = null;
                    box.Enabled = true;
                }
                else if (edit == "end")
                {
                    box.Enabled = false;
                }
            }
        }

        private void CheckVictory(System.Drawing.Image Symbol, char XorO)
        {

            if (VictHorizontal(Symbol) == true || VictDiagonal(Symbol) == true || VictVertical(Symbol) == true)
            {

                WinsTextBox.Text = XorO + " wins!";
                ForEachBox("end");

            }
            else if (Variables.counter == 9)
            {
                WinsTextBox.Text = "Draw!";
            }
        }

        private bool VictHorizontal(System.Drawing.Image Symbol)
        {

            if (Box1.Image == Symbol && Box2.Image == Symbol && Box3.Image == Symbol)
            {
                return true;
            }
            else if (Box4.Image == Symbol && Box5.Image == Symbol && Box6.Image == Symbol)
            {
                return true;
            }
            else if (Box7.Image == Symbol && Box8.Image == Symbol && Box9.Image == Symbol)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool VictVertical(System.Drawing.Image Symbol)
        {
            if (Box1.Image == Symbol && Box4.Image == Symbol && Box7.Image == Symbol)
            {
                return true;
            }
            else if (Box2.Image == Symbol && Box5.Image == Symbol && Box8.Image == Symbol)
            {
                return true;
            }
            else if (Box3.Image == Symbol && Box6.Image == Symbol && Box9.Image == Symbol)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool VictDiagonal(System.Drawing.Image Symbol)
        {
            if (Box1.Image == Symbol && Box5.Image == Symbol && Box9.Image == Symbol)
            {
                return true;
            }
            else if (Box3.Image == Symbol && Box5.Image == Symbol && Box7.Image == Symbol)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

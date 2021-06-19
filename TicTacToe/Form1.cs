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
       
        private void Box1_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box1);
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box2);
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box3);
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box4);
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box5);
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box6);
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box7);
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box8);
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            ChangeToXorO(Box9);
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

        private void ChangeToXorO(PictureBox box)
        {

            if (box.Image == null)
            {
                Variables.counter++;
                if (Variables.counter % 2 == 0)
                {
                    box.Image = Variables.X;
                    CheckVictory(Variables.X, 'X');
                }
                else
                {
                    box.Image = Variables.O;
                    CheckVictory(Variables.O, 'O');
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

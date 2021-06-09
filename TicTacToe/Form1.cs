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
        //Declares variables to link to images
        System.Drawing.Bitmap XImage = Properties.Resources.X;
        System.Drawing.Bitmap OImage = Properties.Resources.O;

        bool XorO = true;
        int counter = 0;

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

        //Clears all squares, button and variables to starting values
        private void ResetButton_Click_1(object sender, EventArgs e)
        {

            ForEachBox("reset");
            XorO = true;
            WinsTextBox.Text = null;
            counter = 0;
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
                counter++;
                if (XorO == true)
                {
                    box.Image = XImage;
                    CheckVictory(XImage, 'X');
                }
                else
                {
                    box.Image = OImage;
                    CheckVictory(OImage, 'O');
                }
                XorO = !XorO;
            }
        }

        private void CheckVictory(System.Drawing.Bitmap Sym, char Victor)
        {

            if (VictHorizontal(Sym) == true || VictDiagonal(Sym) == true || VictVertical(Sym) == true)
            {

                WinsTextBox.Text = Victor + " wins!";
                ForEachBox("end");

            }
            else if (counter == 9)
            {
                WinsTextBox.Text = "Draw!";
            }

        }

        private bool VictHorizontal(System.Drawing.Bitmap Symbol)
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

        private bool VictVertical(System.Drawing.Bitmap Symbol)
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

        private bool VictDiagonal(System.Drawing.Bitmap Symbol)
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

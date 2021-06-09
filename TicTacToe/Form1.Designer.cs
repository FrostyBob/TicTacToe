
namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WinsTextBox = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.Box6 = new System.Windows.Forms.PictureBox();
            this.Box5 = new System.Windows.Forms.PictureBox();
            this.Box4 = new System.Windows.Forms.PictureBox();
            this.Box7 = new System.Windows.Forms.PictureBox();
            this.Box8 = new System.Windows.Forms.PictureBox();
            this.Box9 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // WinsTextBox
            // 
            this.WinsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.WinsTextBox.Enabled = false;
            this.WinsTextBox.Location = new System.Drawing.Point(192, 370);
            this.WinsTextBox.Name = "WinsTextBox";
            this.WinsTextBox.ReadOnly = true;
            this.WinsTextBox.Size = new System.Drawing.Size(100, 20);
            this.WinsTextBox.TabIndex = 11;
            this.WinsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Box2
            // 
            this.Box2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box2.BackColor = System.Drawing.SystemColors.Window;
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box2.Location = new System.Drawing.Point(192, 79);
            this.Box2.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 91);
            this.Box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box2.TabIndex = 12;
            this.Box2.TabStop = false;
            this.Box2.Click += new System.EventHandler(this.Box2_Click);
            // 
            // Box3
            // 
            this.Box3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Box3.BackColor = System.Drawing.SystemColors.Window;
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box3.Location = new System.Drawing.Point(298, 79);
            this.Box3.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(100, 91);
            this.Box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box3.TabIndex = 12;
            this.Box3.TabStop = false;
            this.Box3.Click += new System.EventHandler(this.Box3_Click);
            // 
            // Box6
            // 
            this.Box6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Box6.BackColor = System.Drawing.SystemColors.Window;
            this.Box6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box6.Location = new System.Drawing.Point(298, 176);
            this.Box6.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(100, 91);
            this.Box6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box6.TabIndex = 12;
            this.Box6.TabStop = false;
            this.Box6.Click += new System.EventHandler(this.Box6_Click);
            // 
            // Box5
            // 
            this.Box5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Box5.BackColor = System.Drawing.SystemColors.Window;
            this.Box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box5.Location = new System.Drawing.Point(192, 176);
            this.Box5.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(100, 91);
            this.Box5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box5.TabIndex = 12;
            this.Box5.TabStop = false;
            this.Box5.Click += new System.EventHandler(this.Box5_Click);
            // 
            // Box4
            // 
            this.Box4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Box4.BackColor = System.Drawing.SystemColors.Window;
            this.Box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box4.Location = new System.Drawing.Point(86, 176);
            this.Box4.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(100, 91);
            this.Box4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box4.TabIndex = 12;
            this.Box4.TabStop = false;
            this.Box4.Click += new System.EventHandler(this.Box4_Click);
            // 
            // Box7
            // 
            this.Box7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Box7.BackColor = System.Drawing.SystemColors.Window;
            this.Box7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box7.Location = new System.Drawing.Point(86, 273);
            this.Box7.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(100, 91);
            this.Box7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box7.TabIndex = 12;
            this.Box7.TabStop = false;
            this.Box7.Click += new System.EventHandler(this.Box7_Click);
            // 
            // Box8
            // 
            this.Box8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Box8.BackColor = System.Drawing.SystemColors.Window;
            this.Box8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box8.Location = new System.Drawing.Point(192, 273);
            this.Box8.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(100, 91);
            this.Box8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box8.TabIndex = 12;
            this.Box8.TabStop = false;
            this.Box8.Click += new System.EventHandler(this.Box8_Click);
            // 
            // Box9
            // 
            this.Box9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Box9.BackColor = System.Drawing.SystemColors.Window;
            this.Box9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box9.Location = new System.Drawing.Point(298, 273);
            this.Box9.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box9.Name = "Box9";
            this.Box9.Size = new System.Drawing.Size(100, 91);
            this.Box9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box9.TabIndex = 12;
            this.Box9.TabStop = false;
            this.Box9.Click += new System.EventHandler(this.Box9_Click);
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.SystemColors.Window;
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box1.Location = new System.Drawing.Point(86, 79);
            this.Box1.MinimumSize = new System.Drawing.Size(100, 91);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 91);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Box1.TabIndex = 12;
            this.Box1.TabStop = false;
            this.Box1.Click += new System.EventHandler(this.Box1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetButton.Location = new System.Drawing.Point(192, 396);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 23);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Box9);
            this.Controls.Add(this.Box8);
            this.Controls.Add(this.Box7);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box5);
            this.Controls.Add(this.Box6);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.WinsTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox WinsTextBox;
        private System.Windows.Forms.PictureBox Box2;
        private System.Windows.Forms.PictureBox Box3;
        private System.Windows.Forms.PictureBox Box6;
        private System.Windows.Forms.PictureBox Box5;
        private System.Windows.Forms.PictureBox Box4;
        private System.Windows.Forms.PictureBox Box7;
        private System.Windows.Forms.PictureBox Box8;
        private System.Windows.Forms.PictureBox Box9;
        private System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ResetButton;

    }
}


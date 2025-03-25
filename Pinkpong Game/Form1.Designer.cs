namespace Pinkpong_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnBall = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelKick = new Panel();
            btnReset = new Button();
            SuspendLayout();
            // 
            // btnBall
            // 
            btnBall.BackColor = SystemColors.Highlight;
            btnBall.BackgroundImageLayout = ImageLayout.None;
            btnBall.FlatAppearance.BorderColor = Color.White;
            btnBall.FlatAppearance.BorderSize = 0;
            btnBall.FlatAppearance.MouseDownBackColor = Color.RoyalBlue;
            btnBall.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            btnBall.FlatStyle = FlatStyle.Flat;
            btnBall.Location = new Point(471, 283);
            btnBall.Name = "btnBall";
            btnBall.Size = new Size(15, 15);
            btnBall.TabIndex = 0;
            btnBall.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // panelKick
            // 
            panelKick.BackColor = Color.PaleVioletRed;
            panelKick.BackgroundImageLayout = ImageLayout.None;
            panelKick.Location = new Point(400, 550);
            panelKick.Name = "panelKick";
            panelKick.Size = new Size(200, 10);
            panelKick.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(16, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 2;
            btnReset.Text = "Play Again";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(984, 561);
            Controls.Add(btnReset);
            Controls.Add(panelKick);
            Controls.Add(btnBall);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingPong";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBall;
        private System.Windows.Forms.Timer timer1;
        private Panel panelKick;
        private Button btnReset;
    }
}

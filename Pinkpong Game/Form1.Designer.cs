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
            panel1 = new Panel();
            label2 = new Label();
            textBoxColumn = new TextBox();
            label1 = new Label();
            textboxRow = new TextBox();
            btnPause = new Button();
            panel1.SuspendLayout();
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
            btnBall.Location = new Point(491, 516);
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
            btnReset.Location = new Point(63, 79);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 23);
            btnReset.TabIndex = 2;
            btnReset.Text = "Play";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxColumn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(textboxRow);
            panel1.Location = new Point(386, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 129);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(130, 14);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Column Size";
            label2.Click += label2_Click;
            // 
            // textBoxColumn
            // 
            textBoxColumn.Location = new Point(126, 40);
            textBoxColumn.Name = "textBoxColumn";
            textBoxColumn.Size = new Size(88, 23);
            textBoxColumn.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(31, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Row Size";
            // 
            // textboxRow
            // 
            textboxRow.Location = new Point(14, 40);
            textboxRow.Name = "textboxRow";
            textboxRow.Size = new Size(88, 23);
            textboxRow.TabIndex = 0;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.DarkKhaki;
            btnPause.BackgroundImageLayout = ImageLayout.None;
            btnPause.Cursor = Cursors.Hand;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnPause.ForeColor = Color.DarkOliveGreen;
            btnPause.Location = new Point(902, 5);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 4;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(984, 561);
            Controls.Add(btnPause);
            Controls.Add(panel1);
            Controls.Add(btnBall);
            Controls.Add(panelKick);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PingPong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBall;
        private System.Windows.Forms.Timer timer1;
        private Panel panelKick;
        private Button btnReset;
        private Panel panel1;
        private Label label1;
        private TextBox textboxRow;
        private Button btnPause;
        private Label label2;
        private TextBox textBoxColumn;
    }
}

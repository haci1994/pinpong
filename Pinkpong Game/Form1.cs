
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Pinkpong_Game
{
    public partial class Form1 : Form
    {
        private int _xSpeed = 2;
        private int _ySpeed = 2;
        private bool _gameOver = false;
        private bool _gamePause = false;
        private bool _won = false;
        private List<Panel> _panels;
        private List<Panel> _shadowPanels;
        private int _rowSize = 3;
        private int _columnSize = 4;

        public Form1()
        {

            InitializeComponent();
            //_panels = MakeButtons(_columnSize, _rowSize);
            btnPause.Hide();
            //timer1.Start();
        }

        public void CheckPanelTouch()
        {
            int bb = btnBall.Bottom;
            int bt = btnBall.Top;
            int br = btnBall.Right;
            int bl = btnBall.Left;


            for (int i = 0; i < _panels.Count; i++)
            {
                var panel = _panels[i];

                //panelin alti
                if (bt >= panel.Bottom - 2 && bt <= panel.Bottom + 2 && br >= panel.Left && bl <= panel.Right)
                {
                    Controls.Remove(panel);
                    _panels.Remove(panel);
                    _ySpeed = -_ySpeed;
                }
                //panelin ustu
                if (bb >= panel.Top - 2 && bb <= panel.Top + 2 && br >= panel.Left && bl <= panel.Right)
                {
                    Controls.Remove(panel);
                    _panels.Remove(panel);
                    _ySpeed = -_ySpeed;
                }

                //panelin solu
                if (br >= panel.Left - 2 && br <= panel.Left + 2 && ((bt <= panel.Bottom && bt >= panel.Top) || (bb >= panel.Top && bb <= panel.Bottom)))
                {
                    Controls.Remove(panel);
                    _panels.Remove(panel);
                    _xSpeed = -_xSpeed;
                }

                //panelin sagi
                if (bl >= panel.Right - 2 && bl <= panel.Right + 2 && ((bt <= panel.Bottom && bt >= panel.Top) || (bb >= panel.Top && bb <= panel.Bottom)))
                {
                    Controls.Remove(panel);
                    _panels.Remove(panel);
                    _xSpeed = -_xSpeed;
                }
            }
        }

        public void CheckGameOver()
        {
            if (_gameOver)
            {
                timer1.Stop();
                panel1.Show();
                btnPause.Hide();
                foreach (var panel in _panels)
                {
                    Controls.Remove(panel);
                }
                foreach (var panel in _shadowPanels)
                {
                    Controls.Remove(panel);
                }
                _panels.Clear();
                MessageBox.Show("Game OVER!");
            }

            if (_won)
            {
                timer1.Stop();
                panel1.Show();
                btnPause.Hide();
                foreach (var panel in _panels)
                {
                    Controls.Remove(panel);
                }
                foreach (var panel in _shadowPanels)
                {
                    Controls.Remove(panel);
                }
                _panels.Clear();
                MessageBox.Show("CLEAR! GOOD JOB!");
            }
        }

        public List<Panel> MakeButtons(int w, int h)
        {

            if (w > 10 || h > 6)
            {
                MessageBox.Show("You exceeded limits... Max size is 6x10");
                w = 10;
                h = 6;
            }
            int btnW = 70;
            int btwn = 5;
            int leftSpare = (ClientSize.Width - btnW * w - 5 * (w - 1)) / 2;

            List<Panel> panelss = new List<Panel>();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var panel = new Panel();

                    panel.Width = btnW;
                    panel.Height = 20;
                    panel.Left = leftSpare + j * (btnW + btwn);
                    panel.Top = 60 + i * 25;
                    panel.BackColor = Color.PaleVioletRed;

                    panelss.Add(panel);
                    Controls.Add(panel);
                }
            }

            return panelss;
        }

        public List<Panel> MakeShadowButtons(int w, int h)
        {

            if (w > 10 || h > 6)
            {
                w = 10;
                h = 6;
            }
            int btnW = 70;
            int btwn = 5;
            int leftSpare = (ClientSize.Width - btnW * w - 5 * (w - 1)) / 2;

            List<Panel> panelss = new List<Panel>();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var panel = new Panel();

                    panel.Width = btnW;
                    panel.Height = 20;
                    panel.Left = leftSpare + j * (btnW + btwn);
                    panel.Top = 60 + i * 25;
                    panel.BackColor = Color.White;

                    panelss.Add(panel);
                    Controls.Add(panel);
                }
            }

            return panelss;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            CheckGameOver();

            if (_panels.Count == 0) _won = true;

            btnBall.Left += _xSpeed;
            btnBall.Top += _ySpeed;

            if (btnBall.Left < 0) _xSpeed = -_xSpeed;

            if (btnBall.Right >= ClientSize.Width) _xSpeed = -_xSpeed;

            if (btnBall.Top <= 0) _ySpeed = -_ySpeed;

            if (btnBall.Bottom >= ClientSize.Height)
            {
                _gameOver = true;
                _ySpeed = -_ySpeed;
            }

            int bl = btnBall.Left;
            int br = btnBall.Right;
            int bb = btnBall.Bottom;
            int pl = panelKick.Left;
            int pr = panelKick.Right;
            int p1 = panelKick.Left + panelKick.Width / 3;
            int p2 = panelKick.Right - panelKick.Width / 3;
            int pt = panelKick.Top;


            //left part behavior
            if (bl <= p1 && br >= pl && bb >= pt)
            {
                if (_xSpeed > 0)
                {
                    _xSpeed = -_xSpeed;
                    _ySpeed = 2;
                }

                if (_xSpeed < 0)
                {
                    _ySpeed = -_ySpeed;
                    _xSpeed = -3;
                }
            }

            //middle part behavior
            if (bl >= p1 && br <= p2 && bb >= pt)
            {
                if (_xSpeed > 0)
                {
                    _xSpeed = 2;
                    _ySpeed = -_ySpeed;
                }

                if (_xSpeed < 0)
                {
                    _xSpeed = -2;
                    _ySpeed = -_ySpeed;
                }
            }

            //right part behavior
            if (bl <= pr && br >= p2 && bb >= pt)
            {
                if (_xSpeed > 0)
                {
                    _ySpeed = -_ySpeed;
                    _xSpeed = 3;
                }

                if (_xSpeed < 0)
                {
                    _xSpeed = -_xSpeed;
                    _ySpeed = -_ySpeed;
                }
            }

            CheckPanelTouch();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (panelKick.Left > 0) panelKick.Left -= 15;
            }
            else if (keyData == Keys.Right)
            {
                if (panelKick.Right < ClientSize.Width) panelKick.Left += 15;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnBall.Left = 500;
            btnBall.Top = 300;
            _xSpeed = 2;
            _ySpeed = 2;

            _gameOver = false;
            _won = false;

            try
            {
                _panels = MakeButtons(int.Parse(textboxRow.Text), int.Parse(textBoxColumn.Text));
                _shadowPanels = MakeShadowButtons(int.Parse(textboxRow.Text), int.Parse(textBoxColumn.Text));
            }
            catch
            {
                MessageBox.Show("You did not enter row and column size! Default size will be 5 x 5");
                _panels = MakeButtons(5, 5);
                _shadowPanels = MakeShadowButtons(5, 5);
            }

            timer1.Start();
            panel1.Hide();
            btnPause.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_gamePause)
            {
                timer1.Start();
                btnPause.Text = "Pause";
                _gamePause = false;
            }
            else if (!_gamePause)
            {
                timer1.Stop();
                btnPause.Text = "Continue";
                _gamePause = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

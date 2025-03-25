
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Pinkpong_Game
{
    public partial class Form1 : Form
    {
        private int _xSpeed = 2;
        private int _ySpeed = 2;
        private bool _gameOver = false;
        private List<Panel> _panels;

        public Form1()
        {
            InitializeComponent();
            _panels = MakeButtons(8, 5);

            timer1.Start();
        }

        public void CheckPanelTouch()
        {
            int bb = btnBall.Bottom;
            int bt = btnBall.Top;
            int br = btnBall.Right;
            int bl = btnBall.Left;

            
            for (int i=0; i< _panels.Count; i++)
            {
                var panel = _panels[i];

                if (bt <= panel.Bottom && br >= panel.Left && bl <= panel.Right)
                {
                    Controls.Remove(panel);
                    _panels.Remove(panel);
                    _ySpeed = - _ySpeed;
                }

                //if (bt <= panel.Bottom || bb >= panel.Top && br >= panel.Left)
                //{
                //    Controls.Remove(panel);
                //    _panels.Remove(panel);
                //    _ySpeed = -_ySpeed;
                //}

                //if (bt <= panel.Bottom || bb >= panel.Top && bl <= panel.Right)
                //{
                //    Controls.Remove(panel);
                //    _panels.Remove(panel);
                //    _ySpeed = -_ySpeed;
                //}

                //if (bb >= panel.Top && br >= panel.Left && bl <= panel.Right)
                //{
                //    Controls.Remove(panel);
                //    _panels.Remove(panel);
                //    _ySpeed = -_ySpeed;
                //}
            }
        }

        public void CheckGameOver()
        {
            if (_gameOver)
            {
                timer1.Stop();
                MessageBox.Show("Game OVER!");
            }
        }

        public List<Panel> MakeButtons(int w, int h)
        {

            if (w > 10 || h > 6)
            {
                MessageBox.Show("You exceeded limits...");
                _gameOver = true;
                return default;
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            CheckGameOver();

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
                    _xSpeed = _xSpeed- 1;
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
                    _xSpeed += 1;
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
            timer1.Start();
        }
    }
}

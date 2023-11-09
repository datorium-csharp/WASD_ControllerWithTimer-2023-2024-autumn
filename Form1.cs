using System.Reflection;

namespace WASD_ControllerWithTimer_2023_2024_autumn
{
    public partial class Form1 : Form
    {

        private int speed = 5;
        private int verticalComponent = 0; // 0: no move, 1: down, -1: up
        private int horizontalComponent = 0; // 0: no move, 1: right, -1: left
        private int rocketFrameCount = 0;
        private string rocketOnOff = "off";

        public Form1()
        {
            InitializeComponent();
            InitializeTimers();
            InitializeGame();
        }

        private void InitializeGame()
        {
            var image = (Image)Properties.Resources.ResourceManager.GetObject("rocket_off_000");
            hero.BackColor = Color.Transparent;
            hero.Image = image;
            hero.SizeMode = PictureBoxSizeMode.StretchImage;
            hero.Width = 60;
            hero.Height = 100;
        }


        private void InitializeTimers()
        {
            timerMain.Interval = 10;
            timerMain.Start();

            timerRocket.Interval = 50;
            timerRocket.Start();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            HeroMove();
            HeroWallCollider();
        }

        private void HeroMove()
        {
            hero.Left += horizontalComponent * speed;
            hero.Top += verticalComponent * speed;
        }


        private void HeroWallCollider()
        {
            if(hero.Left > ClientRectangle.Width)
            {
                hero.Left = -hero.Width;
            }
            else if(hero.Left < -hero.Width)
            {
                hero.Left = ClientRectangle.Width;
            }
            
            if(hero.Top > ClientRectangle.Height)
            {
                hero.Top = -hero.Height;
            }
            else if(hero.Top < -hero.Height)
            {
                hero.Top = ClientRectangle.Height;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A) //moving to the left
            {
                horizontalComponent = -1;
                verticalComponent = 0;
            }
            else if(e.KeyCode == Keys.D) //moving to the right
            {
                horizontalComponent = 1;
                verticalComponent = 0;
            }
            else if(e.KeyCode == Keys.W) //moving to the top
            {
                verticalComponent = -1;
                horizontalComponent = 0;
            }
            else if(e.KeyCode == Keys.S) //moving to the bottom
            {
                verticalComponent = 1;
                horizontalComponent = 0;
            }
            else if(e.KeyCode == Keys.P) //pausing the game
            {                
                horizontalComponent = 0;
                verticalComponent = 0;
            }
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                if (timerMain.Interval > 1)
                {
                    timerMain.Interval -= 1;
                }                
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                timerMain.Interval += 1;
            }
            else if (e.KeyCode == Keys.O)
            {
                if(rocketOnOff == "off")
                {
                    rocketOnOff = "on";
                }
                else
                {
                    rocketOnOff = "off";
                }
            }
        }

        private void timerRocket_Tick(object sender, EventArgs e)
        {
            string rocketFrameImage = $"rocket_{rocketOnOff}_{rocketFrameCount.ToString("000")}";
            var image = (Image)Properties.Resources.ResourceManager.GetObject(rocketFrameImage);
            hero.Image = image;
            rocketFrameCount += 1;
            if(rocketFrameCount > 3)
            {
                rocketFrameCount = 0;
            }
        }
    }
}
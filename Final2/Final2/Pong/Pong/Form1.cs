using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Net;
using System.Net.Mail;
using MyVideo;
namespace Pong
{
    // Logan White
    // 4/4/19
    // Fundamentals of Programming TuThu 4:00 - 5:15
    // Professor Ken Wang

    public partial class Form1 : Form
    {
        // Instantiate the Media class
        Media myMedia = new Media();

        // Create a file dialog window
        OpenFileDialog file = new OpenFileDialog();

        // creates a new random generator
        Random rnd = new Random();
       
        int intBallSpeedUp = 3; //sets speed for ball up
        int intBallSpeedLeft = 5; // sets speed for ball left

        int intHumanSpeed = 5; // varaible for speed of player

        int intBarX = 400;  // position of bar

        int intAiSpeed = 6; //variable for speed of ai
        int intAiBarX = 400; //position of ai bar

        // position of ball
        int intBallY = 160;
        int intBallX = 400;

        int intScore = 0; // keeps score of bounces

        string[] arrayNames = new string[50];
       //direction of bar 
        // 0 = left
        // 2 = right
        // 3 = stopped
        int intBarDirection = 0;
        int intAiDirection = 3;

        int intWin = 0; // used for email to check if true
     

        public Form1()
        {           
            InitializeComponent();
            timer1.Enabled = false;   // makes sure timer is disabled for pong
            timer2.Enabled = true; //enables timer for checking tabpages
        }
        private void rockCollision()
        {
            // makes the ball change direction 
            intBallSpeedUp = -intBallSpeedUp;
            intBallSpeedLeft = -intBallSpeedLeft;
            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            tabPong.BackColor = rdmColor;
            intScore++;
        }
        private void rockCollision2()
        {

            intBallSpeedUp = +intBallSpeedUp;
            intBallSpeedLeft = -intBallSpeedLeft;

            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            tabPong.BackColor = rdmColor;
            intScore++;
        }
        private void rockColor()
        {
            // changes the color of the rocks backcolor and the tab's back color upon call
            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock1.BackColor = rdmColor;
            Color rdmColor2 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock2.BackColor = rdmColor2;
            Color rdmColor3 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock3.BackColor = rdmColor3;
            Color rdmColor4 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock4.BackColor = rdmColor4;
            Color rdmColor5 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock5.BackColor = rdmColor5;
            Color rdmColor6 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock6.BackColor = rdmColor6;
            Color rdmColor7 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock7.BackColor = rdmColor7;
            Color rdmColor8 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock8.BackColor = rdmColor8;
            Color rdmColor9 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock9.BackColor = rdmColor9;
            Color rdmColor12 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblRock12.BackColor = rdmColor12;

            Color rdmColorTab = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            tabPong.BackColor = rdmColorTab;

        }

        private void refreshlist()
        {
            lstBoxHistory.Items.Clear(); //clears list
            StreamReader newStreamReader = new StreamReader("PastPlays.txt"); //creates a new streamreader reading the text file
            int namesIndex = 0;
            while (newStreamReader.Peek() != -1) //reader will run through and add lines to an array
            {
                arrayNames[namesIndex] = newStreamReader.ReadLine();
                arrayNames[namesIndex] += ", " +newStreamReader.ReadLine();
                namesIndex++;

            }
            for (int i = 0; i <= arrayNames.Length - 1; i++) //adds array to the listbox items
            {
                if (arrayNames[i] != null)
                {
                    lstBoxHistory.Items.Add(arrayNames[i]);
                }

            }
            newStreamReader.Close(); //closes streamreader
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // removes the pages at first
            progressBar1.Visible = false;
            tabControl1.TabPages.Remove(tabPong);
            tabControl1.TabPages.Remove(tabBrowser);
            tabControl1.TabPages.Remove(tabGameOver);
            tabControl1.TabPages.Remove(tabMedia);

            refreshlist();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {


            // relative location of ball will be tracked 
            intBallY += intBallSpeedUp;
            intBallX += intBallSpeedLeft;

            // makes the ball start to move to according speed 
            lblBall.Left += intBallSpeedLeft;
            lblBall.Top += intBallSpeedUp;

            // bar will move right if direction = 0
            if (intBarDirection == 0)
            {
                intBarX += intHumanSpeed;
                lblPlayer.Left = intBarX;

                if (intBarX >= 780)
                {
                    intBarDirection = 2;
                }

            }

            // the bar will move left if direction = 2
            if (intBarDirection == 2)
            {
                intBarX -= intHumanSpeed;
                lblPlayer.Left = intBarX;
                if (intBarX <= -5)
                {
                    intBarDirection = 0;
                }

            }
            //if (intAiBarX == intBallX)
            //{
            //    intAiDirection = 3;
            //}

            //if (intAiDirection == 3)
            //{
            //    intAiSpeed = 0;
            //}
            if (intAiBarX < intBallX)
            {
                intAiDirection = 1;
            }
            if (intAiDirection == 1)
            {
                intAiBarX += intAiSpeed;
                lblAi.Left = intAiBarX;
            }
            if (intAiBarX > intBallX)
            {

                intAiDirection = 2;
            }

            if (intAiDirection == 2)
            {
                intAiBarX -= intAiSpeed;
                lblAi.Left = intAiBarX;
            }
      

            // if ball lands on right border it will bounce back

            if (lblBall.Left >= 865)
            {
                intBallSpeedLeft = -intBallSpeedLeft;
            }
            // if ball lands on left border it will bounce back

            if (lblBall.Left <= 0)
            {
                intBallSpeedLeft = -intBallSpeedLeft;
            }
           

            // If the ball intersects with any rock, the ball will bounce away
            // either at a negative or positive slope while also adding score
            // and changing the rock's color
            
            if (lblBall.Bounds.IntersectsWith(lblRock1.Bounds))
            {
                rockCollision2();
                rockColor();
            }
            if (lblBall.Bounds.IntersectsWith(lblRock2.Bounds))
            {
                rockCollision();
                rockColor();

            }
            if (lblBall.Bounds.IntersectsWith(lblRock3.Bounds))
            {
                rockCollision();
                rockColor();

            }
            if (lblBall.Bounds.IntersectsWith(lblRock4.Bounds))
            {
                rockCollision();
                rockColor();

            }
            if (lblBall.Bounds.IntersectsWith(lblRock5.Bounds))
            {
                rockCollision2();
                rockColor();

            }
            if (lblBall.Bounds.IntersectsWith(lblRock6.Bounds))
            {
                rockCollision2();
                rockColor();


            }
            if (lblBall.Bounds.IntersectsWith(lblRock7.Bounds))
            {
                rockCollision();
                rockColor();


            }
            if (lblBall.Bounds.IntersectsWith(lblRock8.Bounds))
            {
                rockCollision();
                rockColor();


            }
            if (lblBall.Bounds.IntersectsWith(lblRock9.Bounds))
            {
                rockCollision();
                rockColor();

            }


            if (lblBall.Bounds.IntersectsWith(lblRock12.Bounds))
            {
                rockCollision();
                rockColor();

            }



            /***************************************************************************************
            *    USE OF CODE FOR COLLISSION 
            *    Title: Bouncing the Ball off of Walls and Paddles Issue (Answer)
            *    Author:  Wendy Zang  Microsoft contingent staff
            *    Date: May 27, 2017
            *    Code version: 1.0
            *    Availability: https://social.msdn.microsoft.com/Forums/vstudio/en-US/d8170d63-c7a3-42c0-8f0e-9dfa86767feb/creating-pong-in-c-bouncing-the-ball-off-of-walls-and-paddles-issue?forum=csharpgeneral
            *
            ***************************************************************************************/

            // ball will bounce if it intersects with the racket

            if (lblBall.Bottom >= lblPlayer.Top && lblBall.Bottom <= lblPlayer.Bottom && lblBall.Left >= lblPlayer.Left && lblBall.Right <= lblPlayer.Right) //used code
            {
               
                intBallSpeedUp = -intBallSpeedUp; // ball will bounce back up

                // Decreases the width of paddle for difficulty

                if (lblPlayer.Width >= 20)
                lblPlayer.Width = lblPlayer.Width - 4;

                intScore++; // increases score
                try { 
                SoundPlayer player = new SoundPlayer(Properties.Resources.Jump_SoundBible_com_1007297584); // plays a sound
                player.Play();
                }
                catch
                {

                }
                rockColor();

            }
            if (lblBall.Bottom >= lblAi.Top && lblBall.Bottom <= lblAi.Bottom && lblBall.Left >= lblAi.Left && lblBall.Right <= lblAi.Right) // collision
            {

                intBallSpeedUp = -intBallSpeedUp; // ball will bounce back down              

                intScore++; // increases score
                try
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Jump_SoundBible_com_1007297584); // plays sound
                    player.Play();
                }
                catch
                {

                }
                rockColor();
            }

            // If the ball reaches past the racket, game ends
            if (intBallY >= 600)
                {
                    timer1.Enabled = false;
                try { 
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450);  // puts text into mail body text
                    player.Play(); 
                }
                catch
                {

                }

                MessageBox.Show("You Lose");

                tabControl1.SelectedTab = tabGameOver; // brings tab back to menu
                intWin = 0;
                if (tabControl1.SelectedTab != tabGameOver)
                {        
                tabControl1.TabPages.Add(tabGameOver); // adds game over tab
                }
                txtboxBody.Text = "You Lost with a score of: " + intScore; // puts text into mail body text
                tabControl1.SelectedTab = tabGameOver; // brings tab back to menu
            }

            if (intBallY <= 0)
            {
                timer1.Enabled = false;
                try
                {
                    SoundPlayer player = new SoundPlayer(Properties.Resources.Sad_Trombone_Joe_Lamb_665429450); //plays a sound
                    player.Play();
                }
                catch
                {

                }

                MessageBox.Show("You Win");
                intWin = 1;
                tabControl1.SelectedTab = tabGameOver; // brings tab back to menu
                if (tabControl1.SelectedTab != tabGameOver)
                {
                    tabControl1.TabPages.Add(tabGameOver); // adds game over tab
                }
                txtboxBody.Text = "You Won with a score of:" + intScore; // puts text into mail body text
                tabControl1.SelectedTab = tabGameOver; // brings tab back to menu

            }

            //Displays the score within pong game

            lblScore.Text = "Bounces:  " + intScore.ToString();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // closes the application
            this.Close();
        }

       

        private void pauseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //pauses the time if clicked
            timer1.Enabled = !timer1.Enabled;
        }

    

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // sets the keys to make bar move 
            switch (e.KeyChar)
            {
                case 'd': //right
                    intBarDirection = 0;
                    break;
                case 'D': //right
                    intBarDirection = 0;
                    break;
                case 'a': //left
                    intBarDirection = 2;
                    break;
                case 'A': //left
                    intBarDirection = 2;
                    break;
                case 'p': // pauses the game
                    if(tabControl1.SelectedTab == tabPong) { 
                    timer1.Enabled = !timer1.Enabled;
                    lblPause.Text = "";
                    lblYou.Text = "";
                    }
                    break;
                case 'P': // pauses the game
                    if (tabControl1.SelectedTab == tabPong)
                    {
                        timer1.Enabled = !timer1.Enabled;
                        lblPause.Text = "";
                        lblYou.Text = "";
                    }
                    break;
            }
        }


        /***************************************************************************************
        *    USE OF CODE FOR Random Color Generation
        *    Title: Get Random Color Duplicate (Answer)
        *    Author:  Rufus L
        *    Date: March 22, 2015
        *    Code version: 1.0
        *    Availability: https://stackoverflow.com/questions/29198073/get-random-color
        *
        ***************************************************************************************/

        private void changeBallColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changes ball color
            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblBall.BackColor = rdmColor;
        }

        private void changeRacketColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // changes color of player bar
            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblPlayer.BackColor = rdmColor;

        }

        private void changeScoreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change color of score keeper
            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblScore.ForeColor = rdmColor;
        }
        private void changeAIColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //changes color of ai bar randomly
            Color rdmColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            lblAi.BackColor = rdmColor;
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnAddScores.Enabled = true; // allows you to add new score
            // RESETS THE GAME TO PLAY AGAIN
            timer1.Enabled = false;
            lblBall.Top = 160;
            lblBall.Left = 400;

            lblPlayer.Left = 400;
            lblPlayer.Top = 500;
            lblPlayer.Width = 100;
            lblAi.Left = 400;
            lblAi.Top = 44;

            intBallSpeedUp = 3;
            intBallSpeedLeft = 5;

            intHumanSpeed = 5;

            intBarX = 400;
            intScore = 0;
            intAiSpeed = 6;
            intAiBarX = 400;
            intBallY = 160;
            intBallX = 400;
            intBarDirection = 0;
            intAiDirection = 3;
            lblPause.Text = "Press ''P'' To Start Game";
            tabControl1.SelectedTab = tabPong;
            tabControl1.TabPages.Remove(tabGameOver);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // "starts game" by showing pong tab
            tabControl1.TabPages.Add(tabPong);
            tabControl1.TabPages.Remove(tabMenu);
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            btnAddScores.Enabled = true; // allows you to add new score
            // RESETS THE GAME TO PLAY AGAIN
            timer1.Enabled = false;
            lblBall.Top = 160;
            lblBall.Left = 400;

            lblPlayer.Left = 400;
            lblPlayer.Top = 500;
            lblPlayer.Width = 100;
            lblAi.Left = 400;
            lblAi.Top = 44;

            intBallSpeedUp = 3;
            intBallSpeedLeft = 5;

            intHumanSpeed = 5;

            intBarX = 400;
            intScore = 0;
            intAiSpeed = 6;
            intAiBarX = 400;
            intBallY = 160;
            intBallX = 400;
            intBarDirection = 0;
            intAiDirection = 3;
            lblPause.Text = "Press ''P'' To Start Game";
            lblYou.Text = "This is you -->";
            tabControl1.SelectedTab = tabPong;
            tabControl1.TabPages.Remove(tabGameOver);

            tabControl1.TabPages.Remove(tabPong);
            tabControl1.TabPages.Remove(tabBrowser);
            tabControl1.TabPages.Remove(tabGameOver);
            tabControl1.TabPages.Remove(tabMedia);
            tabControl1.TabPages.Add(tabMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strEmailName = txtboxEmail.Text; // takes user's email and converts it to a string

            string strBody = txtboxBody.ToString(); // takes the body and converts it to a string

            if (strBody == strBody) //rewrites the body since the email shows System.Properties.Textbox.Text and then the message
            {
                strBody = "You Lost wih a score of: " + intScore.ToString();
            }
            if (intWin == 1) // if intwin = 1 it will convert to a winning message
            {
                strBody = "You Won wih a score of: " + intScore.ToString();
            }
            MailMessage myMail = new MailMessage(); //initiates a new mail

            //setting up the email, body, subject, and from where
            myMail.To.Add(new MailAddress(strEmailName)); // will email this address
            myMail.From = new MailAddress("pittcist2019@gmail.com", "Logan White");
            myMail.Subject = "Pong Results:";
            myMail.Body = strBody;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("pittcist2019@gmail.com", "pittcist0265");

            //shows a popup message if succeeds 
            try
            {
                smtp.Send(myMail);
                MessageBox.Show("Email has been sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddScores_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("PastPlays.txt" , true)) //creates a new streamwriter
            {               
                sw.WriteLine(txtboxName.Text); //writes input
                sw.WriteLine(intScore); //adds score
                sw.Close(); //closes the streamwriter
            }
            refreshlist(); //refreshes
            txtboxName.Text = ""; //clears the textbox
            btnAddScores.Enabled = false ; //disables button to add score (so as to not allow multiple enteries)


        }

        private void pongHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //adds the web browser tab
            tabControl1.TabPages.Add(tabBrowser);
            tabControl1.SelectedTab = tabBrowser;

            //opens link to wikipedia article on pong
            try { 
            webBrowser1.Url = new Uri("https://en.wikipedia.org/wiki/Pong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        { 
            //updates the progress bar in web browser
            if (e.MaximumProgress > 0)
            {
                int intProgress = Convert.ToInt32(e.CurrentProgress / e.MaximumProgress * 100);

                
                intProgress = intProgress > 100 ? 100 : intProgress;
                intProgress = intProgress < 0 ? 0 : intProgress;

                progressBar1.Value = intProgress;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer constantly updates resulting in this being checked, that way it will always go away if tabpage does not equal the tab page wanted
            // also removes webbrowser page if not on it

            if (tabControl1.SelectedTab != tabBrowser)
            {
                progressBar1.Visible = false;
                tabControl1.TabPages.Remove(tabBrowser);

            }
            if (tabControl1.SelectedTab == tabBrowser)
            {
                progressBar1.Visible = true;
            }
            if (tabControl1.SelectedTab != tabMedia)
            {
                tabControl1.TabPages.Remove(tabMedia);
            }
        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // opens tab media and shows it
            tabControl1.TabPages.Add(tabMedia);
            tabControl1.SelectedTab = tabMedia;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            // updates progressbar to media position
            if( timer3.Enabled == true)
            {          
            try { 
            progressBarMedia.Value = myMedia.Position;
            }
            catch
            {
            }
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            progressBarMedia.Maximum = Convert.ToInt32(myMedia.Duration());
            myMedia.Play();
            timer3.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            // Pauses the video
            myMedia.Pause = !myMedia.Pause;
            timer3.Enabled = !myMedia.Pause;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            myMedia.Stop();
            timer3.Enabled = false; //stops the video
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            myMedia.FullScreen(); //makes video full screen
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            // Create a file filter - only show the .wmv files
            file.Filter = "Windows Media Files | *.wmv; *.wav";

            // Set the currect directory to the initial directory
            file.InitialDirectory = Directory.GetCurrentDirectory();

            // Show the OpenFileDialog

            file.ShowDialog();
            myMedia.Open(file.FileName, pictureBox1);
            myMedia.Stop();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabMedia); //removes the tab going back
            myMedia.Stop(); //stops the video
        }
    } 
}

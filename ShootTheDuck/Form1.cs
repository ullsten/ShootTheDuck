namespace ShootTheDuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int score = 0;
        int totalShots = 0;
        int missedShots = 0;

        void shotVoice() //Sound when shooting
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\00.Edugrade - Systemutvecklare\02.ApplicationsWindowsForm\1.Sounds\gun_gunshot.wav");
            player.Play();
        }
        void missedVoice()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\00.Edugrade - Systemutvecklare\02.ApplicationsWindowsForm\1.Sounds\buuu.wav");
            player.Play();
        }
        void functionShot() //Count for score + total shots
        {
            score++;
            label1.Text = "Score=" + score;
            totalShots++;
            label3.Text = "Total shots=" + totalShots;

            shotVoice();
        }
        void functionMissedShot()       //Count for missed shots
        {
            missedShots++;
            label2.Text = "Missing shots=" + missedShots;
            totalShots++;
            label3.Text = "Total shots=" + totalShots;

            shotVoice();
        }
       void reset()
       {
            score = 0;
            missedShots = 0;
            totalShots = 0;
            label2.Text = "Missing shots=" + missedShots;
            label3.Text = "Total shots=" + totalShots;
            label1.Text = "Score=" + score;
            timer1.Start();
            label4.Text = "";
        }   
        private void timer1_Tick(object sender, EventArgs e) //Movement of duck
        {
            int x, y;
            x = random.Next(50,600);
            y = random.Next(0, 450);
            pictureBox1.Location= new Point(x,y);
            if (missedShots>=10)
            {
                timer1.Stop();
                label4.Text = "Game Over";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //What happen when click on duck
        {
            functionShot();
        }

        private void Form1_Load(object sender, EventArgs e) //What happen click on form(background)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            functionMissedShot();
        }

        private void button2_Click(object sender, EventArgs e) //Restart button
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e) //Exit game
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
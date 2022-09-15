namespace WinFormsApp1lol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox2;
            panel2.Hide();
            button1.TabStop = false;
            button2.TabStop = false;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - button2.Width);
            int y = r.Next(0, this.Height - button2.Height);
            button2.Location = new Point(x, y);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (button2.Location == button1.Location || button2.Location == label1.Location)
            {
                MoverBoton();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
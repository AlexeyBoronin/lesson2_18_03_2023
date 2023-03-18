namespace lesson2_18_03_2023
{
    public partial class Form1 : Form
    {
        Point moveStert;//точка перемещения

        public Form1()
        {
            InitializeComponent();
            /* this.FormBorderStyle=FormBorderStyle.None;
             this.BackColor = Color.Black;
             Button button1 = new Button
             {
                 Location = new Point
                 {
                     X = this.Width / 3,
                     Y = this.Height / 3
                 }
             };
             button1.Text = "Закрыть";
             button1.Click += button1_Click;
             button1.BackColor=Color.White;
             this.Controls.Add(button1);//добавление кнопки на форму*/
            this.Load += Form1_Load;

            /*this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;*/
        }
        /* private void button1_Click(object sender, EventArgs e)
         {
             this.Close();
         }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            /* System.Drawing.Drawing2D.GraphicsPath myPath=new System.Drawing.Drawing2D.GraphicsPath();
             myPath.AddEllipse(0,0,this.Width,this.Height);
             Region myRegion =   new Region(myPath);
             this.Region = myRegion;*/
            Button helloButton = new Button();
            helloButton.BackColor = Color.LightGray;
            helloButton.ForeColor = Color.DarkGray;
            helloButton.Location = new Point(10, 10);
            helloButton.Text = "Hello";
            //groupBox2.Controls.Add(helloButton);
        }
        /* private void Form1_MouseDown(object sender, MouseEventArgs e)
         {
             if(e.Button == MouseButtons.Left)
             { moveStert = new Point(e.X, e.Y); }
         }
         private void Form1_MouseMove(object sender, MouseEventArgs e)
         {
             if(e.Button == MouseButtons.Left)
             {
                 Point deltaPos=new Point(e.X-moveStert.X, e.Y-moveStert.Y);
                 this.Location=new Point(this.Location.X +deltaPos.X,this.Location.Y +deltaPos.Y);
             }
         }*/
    }
}
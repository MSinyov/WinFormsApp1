namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush brush = Brushes.Fuchsia;
            Graphics gr = this.CreateGraphics();
            gr.FillPie(brush, 40, 40, 80, 80, 80, 80);
            gr.Dispose();
        }
    }
}
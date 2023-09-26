namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button btn = new Button()
            {
                Size = new Size(200, 60),
                Text = "Button",
            };
            btn.Click += (s, e) => MessageBox.Show("test");
            Controls.Add(btn);



        }

        private void btnGroupeBox_Click(object sender, EventArgs e)
        {
            new FormGroupeBox().ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmPractice().ShowDialog();
        }
    }
}
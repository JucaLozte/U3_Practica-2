namespace U3_Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, count = 0, limite;
            num = int.Parse(textBox1.Text);
            limite = int.Parse(textBox2.Text);
            do
            {
                listBox1.Items.Add(num + " * " + count + " = " + num * count);
                count++;
            }
            while (count <= limite);
        }
    }
}
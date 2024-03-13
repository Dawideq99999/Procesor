namespace Procesor
{
    public partial class Procesor : Form
    {
        public Procesor()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var random = new Random();
            label1.Text = random.Next(0, 10000).ToString();
            label2.Text = random.Next(0, 10000).ToString();
            label3.Text = random.Next(0, 10000).ToString();
            label4.Text = random.Next(0, 10000).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                label1.Text = "NULL";
            else
                label1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                label2.Text = "NULL";
            else
                label2.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                label3.Text = "NULL";
            else
                label3.Text = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                label4.Text = "NULL";
            else
                label4.Text = textBox4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox6.Checked)
                label2.Text = label1.Text;
            if (checkBox1.Checked && checkBox7.Checked)
                label3.Text = label1.Text;
            if (checkBox1.Checked && checkBox8.Checked)
                label4.Text = label1.Text;

            if (checkBox2.Checked && checkBox5.Checked)
                label1.Text = label2.Text;
            if (checkBox2.Checked && checkBox7.Checked)
                label3.Text = label2.Text;
            if (checkBox2.Checked && checkBox8.Checked)
                label4.Text = label2.Text;

            if (checkBox3.Checked && checkBox5.Checked)
                label1.Text = label3.Text;
            if (checkBox3.Checked && checkBox6.Checked)
                label2.Text = label3.Text;
            if (checkBox3.Checked && checkBox8.Checked)
                label4.Text = label3.Text;

            if (checkBox4.Checked && checkBox5.Checked)
                label1.Text = label4.Text;
            if (checkBox4.Checked && checkBox6.Checked)
                label2.Text = label4.Text;
            if (checkBox4.Checked && checkBox7.Checked)
                label3.Text = label4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string stg = "";

            if (checkBox1.Checked && checkBox6.Checked)
            {
                stg = label2.Text;
                label2.Text = label1.Text;
                label1.Text = stg;
            }

            if (checkBox1.Checked && checkBox7.Checked)
            {
                stg = label3.Text;
                label3.Text = label1.Text;
                label1.Text = stg;
            }

            if (checkBox1.Checked && checkBox8.Checked)
            {
                stg = label4.Text;
                label4.Text = label1.Text;
                label1.Text = stg;
            }

            if (checkBox2.Checked && checkBox5.Checked)
            {
                stg = label1.Text;
                label1.Text = label2.Text;
                label2.Text = stg;
            }

            if (checkBox2.Checked && checkBox7.Checked)
            {
                stg = label3.Text;
                label3.Text = label2.Text;
                label2.Text = stg;
            }

            if (checkBox2.Checked && checkBox8.Checked)
            {
                stg = label4.Text;
                label4.Text = label2.Text;
                label2.Text = stg;
            }

            if (checkBox3.Checked && checkBox5.Checked)
            {
                stg = label1.Text;
                label1.Text = label3.Text;
                label3.Text = stg;
            }

            if (checkBox3.Checked && checkBox6.Checked)
            {
                stg = label2.Text;
                label2.Text = label3.Text;
                label3.Text = stg;
            }

            if (checkBox3.Checked && checkBox8.Checked)
            {
                stg = label4.Text;
                label4.Text = label3.Text;
                label3.Text = stg;
            }

            if (checkBox4.Checked && checkBox5.Checked)
            {
                stg = label1.Text;
                label1.Text = label4.Text;
                label4.Text = stg;
            }

            if (checkBox4.Checked && checkBox6.Checked)
            {
                stg = label2.Text;
                label2.Text = label4.Text;
                label4.Text = stg;
            }

            if (checkBox4.Checked && checkBox7.Checked)
            {
                stg = label3.Text;
                label3.Text = label4.Text;
                label4.Text = stg;
            }
        }
    }
}
using System.Web;

namespace CheckBox_RadioButtonBox_ComboBox_UpDownNumeric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = String.Empty;
            if (checkBox1.Checked)
            {
                item += "\npencil";
            }
            if (checkBox2.Checked)
            {
                item += "\nshopner";
            }
            if (checkBox3.Checked)
            {
                item += "\npen";
            }
            MessageBox.Show("you have bought " + item);
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                MessageBox.Show("YOU SELECT MALE ");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("YOU SELECT FEMALE ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "LAHORE")
            {
                MessageBox.Show("you select" + " LAHORE");
            }
            if (comboBox1.Text == "MULTAN")
            {
                MessageBox.Show("you select" + " MULTAN");
            }
            if (comboBox1.Text == "FAISALABAD")
            {
                MessageBox.Show("you select" + " FAISALABAD");
            }
            if (comboBox1.Text == "ISLAMABAD")
            {
                MessageBox.Show("you select" + " ISLAMABAD");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double price = (double)numericUpDown2.Value;
            int quantity = (int)numericUpDown1.Value;
            double show = price * quantity;
            MessageBox.Show("THE PRICE IS : " + show);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

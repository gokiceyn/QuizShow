using System.Linq.Expressions;

namespace QuizShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            label4.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "In what year was the Republic of Türkiye declared?";
                button1.Text = "1923";
                button2.Text = "1925";
                button3.Text = "1930";
                button4.Text = "1960";
                label7.Text = "1923";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Which city is not located in the Aegean region?";
                button1.Text = "izmir";

                button2.Text = "balýkesir";

                button3.Text = "aydýn";

                button4.Text = "manisa";

                label7.Text = "balýkesir";

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "To which author does the book The Last Birds belong?";
                button1.Text = "sait faik";
                button2.Text = "cemal süreya";
                button3.Text = "atilla ilhan";
                button4.Text = "sait faik";
                label7.Text = "sait faik";

                button5.Text = "results";


            }
            if (soruno == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("true: " + dogru + "\n" + "false: " + yanlis);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button1.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label8.Text = button2.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button4.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}

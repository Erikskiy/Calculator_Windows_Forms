using System;
using System.Windows.Forms;

namespace c__лаб_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a, b, result;
        public string operasia;
        public bool ekinshy_san_ba = false;

        private void button_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "1";
            }
            else
            {
                text_show.Text += "1";
            }
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "2";
            }
            else
            {
                text_show.Text += "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "3";
            }
            else
            {
                text_show.Text += "3";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "4";
            }
            else
            {
                text_show.Text += "4";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "5";
            }
            else
            {
                text_show.Text += "5";
            }
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "6";
            }
            else
            {
                text_show.Text += "6";
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "7";
            }
            else
            {
                text_show.Text += "7";
            }
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "8";
            }
            else
            {
                text_show.Text += "8";
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "9";
            }
            else
            {
                text_show.Text += "9";
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if ((text_show.Text == "null") || (text_show.Text == "+") || (text_show.Text == "-") || (text_show.Text == "*") || (text_show.Text == "/"))
            {
                text_show.Text = "0";
            }
            else
            {
                text_show.Text += "0";
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (!ekinshy_san_ba)
            {
                a = double.Parse(text_show.Text);
                operasia = "plus";
                text_show.Text = "+";
                ekinshy_san_ba = true;
            }
            else
            {
                b = double.Parse(text_show.Text);
                operasia = "plus";
                text_show.Text = "null";
                ekinshy_san_ba = false;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (!ekinshy_san_ba)
            {
                a = double.Parse(text_show.Text);
                operasia = "minus";
                text_show.Text = "-";
                ekinshy_san_ba = true;
            }
            else
            {
                b = double.Parse(text_show.Text);
                operasia = "minus";
                text_show.Text = "null";
                ekinshy_san_ba = false;
            }
        }

        private void button_kobeytu_Click(object sender, EventArgs e)
        {
            if (!ekinshy_san_ba)
            {
                a = double.Parse(text_show.Text);
                operasia = "kobeytu";
                text_show.Text = "*";
                ekinshy_san_ba = true;
            }
            else
            {
                b = double.Parse(text_show.Text);
                operasia = "kobeytu";
                text_show.Text = "null";
                ekinshy_san_ba = false;
            }
        }

        private void button_bolu_Click(object sender, EventArgs e)
        {
            if (!ekinshy_san_ba)
            {
                a = double.Parse(text_show.Text);
                operasia = "bolu";
                text_show.Text = "/";
                ekinshy_san_ba = true;
            }
            else
            {
                b = double.Parse(text_show.Text);
                operasia = "bolu";
                text_show.Text = "null";
                ekinshy_san_ba = false;
            }
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            ekinshy_san_ba = false;
            text_show.Text = "null";
            a = 0;
            b = 0;
            operasia = null;
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            b = double.Parse(text_show.Text);
            if (operasia == "plus")
            {
                result = a + b;
                text_show.Text = result.ToString();
                ekinshy_san_ba = false;
                a = 0;
                b = 0;
                operasia = null;
            }
            if (operasia == "minus")
            {
                result = a - b;
                text_show.Text = result.ToString();
                ekinshy_san_ba = false;
                a = 0;
                b = 0;
                operasia = null;
            }
            if (operasia == "kobeytu")
            {
                result = a * b;
                text_show.Text = result.ToString();
                ekinshy_san_ba = false;
                a = 0;
                b = 0;
                operasia = null;
            }
            if (operasia == "bolu")
            {
                result = a / b;
                text_show.Text = result.ToString();
                ekinshy_san_ba = false;
                a = 0;
                b = 0;
                operasia = null;
            }

        }
    }
}

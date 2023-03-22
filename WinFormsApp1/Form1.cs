using System.Media;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();
            MinValue.Text = MinSize.ToString();
            MaxValue.Text = MaxSize.ToString();
            textBox1.Text = "0";
        }

        // creating variables for calculating
        private double a = 1;
        private double b = 1;
        private char op = 'n';
        private double res = 1;
        private double MinSize = -2000000;
        private double MaxSize = 4000000;
        private double MaxSize1 = 4000000;
        private double MinSize1 = -2000000;
        TimeSpan ts = new TimeSpan(0,0,3);

        /// <summary>
        /// method that describes logic of button 'equal'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Equal_Click(object sender, EventArgs e)
        {

            switch (op)
            {
                case '+':
                    if (textBox1.Text == "")
                    {
                        b = a;
                        textBox1.Text = (a + b).ToString("G7");
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        res = a + b;
                        if(res >= MaxSize)
                        {
                            MessageBox.Show("Too big number!");
                            Clear_Click(sender, e);
                        }
                        else
                        {
                            textBox1.Text = res.ToString("G7");
                        }
                    }
                    break;
                case '-':
                    if (textBox1.Text == "")
                    {
                        b = a;
                        res = a - b;
                        textBox1.Text = res.ToString("G7");
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        res = a - b;
                        if (res <= MinSize)
                        {
                            MessageBox.Show("To small number!");
                            Clear_Click(sender, e);
                        }
                        else
                        {
                            textBox1.Text = res.ToString("G7");
                        }
                    }
                    break;
                case '*':
                    if (textBox1.Text == "")
                    {
                        b = a;
                        res = a * b;
                        textBox1.Text = res.ToString("G7");
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        res = a * b;
                        if(res >= MaxSize || res <= MinSize)
                        {
                            MessageBox.Show("Too big number");
                            Clear_Click(sender, e);
                        }
                        else
                        {
                            textBox1.Text = res.ToString("G7");
                        }
                    }
                    break;
                case '/':
                    if (textBox1.Text == "")
                    {
                        b = a;
                        res = a / b;
                        textBox1.Text = res.ToString("G7");
                    }
                    else
                    {
                        b = Convert.ToDouble(textBox1.Text);
                        res = a / b;
                        textBox1.Text = res.ToString("G7");
                    }
                    break;

            }
            op = 'n';

            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button 'division'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Div_Click(object sender, EventArgs e)
        {
            op = '/';
            if (textBox1.Text == "")
            {
                a = 1;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            textBox1.Focus();

        }

        /// <summary>
        /// method that describes logic of button 'Clear'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox1.Focus();
        }

        /// <summary>
        /// method that controls input to textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (Convert.ToInt32(textBox1.Text) > MaxSize1)
                {
                    textBox1.Text = "";
                }
                
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// method that describes logic of button 'Addition'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            op = '+';
            if (textBox1.Text == "")
            {
                a = 0;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button 'Subtracting'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Minus_Click(object sender, EventArgs e)
        {
            op = '-';
            if (textBox1.Text == "")
            {
                a = 0;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button 'Square power'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Square_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                a = 0;
                textBox1.Text = a.ToString("G7");
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                a = a * a;
                textBox1.Text = a.ToString("G7");
            }
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '1'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '2'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press2_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '3'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press3_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '4'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press4_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '5'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press5_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '6'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press6_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '7'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press7_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '8'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press8_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '9'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press9_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button 'sinus'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sin_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = (a * Math.PI) / 180;
            a = Math.Round(Math.Sin(a), 2);
            textBox1.Text = a.ToString();
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '0'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Press0_Click(object sender, EventArgs e)
        {
            Press1_Click(sender, e);
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '+-'
        /// this method changes the number's sign
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSign_Click(object sender, EventArgs e)
        {
            int i = textBox1.Text.IndexOf("-", 0, textBox1.Text.Length);

            if (i == (-1))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                string s = textBox1.Text;
                s = s.Remove(i, 1);
                textBox1.Text = s;
            }
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button 'Cosinus'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cos_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = (a * Math.PI) / 180;
            a = Math.Round(Math.Cos(a), 2);
            textBox1.Text = a.ToString();
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '1/x'
        /// method divides 1 by x
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneDivX_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Round((1 / a), 4);
            textBox1.Text = a.ToString();
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button '1*1/2'
        /// method expands to the power of half(0.5, 1/2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xPoweraHalf_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            a = Math.Round(Math.Pow(a, 0.5), 4);
            textBox1.Text = a.ToString();
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button ','
        /// method make the number double
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToDouble_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                    textBox1.Text = textBox1.Text.ToString();
                    Press1_Click(sender, e);
                }
                else
                {
                    textBox1.Text = textBox1.Text.ToString() + ",";
                }
            }
            textBox1.Focus();

        }

        /// <summary>
        /// method that describes logic of button 'Multiplication'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mult_Click(object sender, EventArgs e)
        {
            op = '*';
            if (textBox1.Text == "")
            {
                a = 1;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            textBox1.Focus();
        }

        /// <summary>
        /// method that describes logic of button 'Backspace',
        /// method helps to user delete last typed symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string s = textBox1.Text;
                s = s.Remove(textBox1.Text.Length - 1, 1);
                textBox1.Text = s;
            }
            textBox1.Focus();
        }

        /// <summary>
        /// method that blocks all keys except numbers
        /// '-' in the begining of number and ',' ones in number
        /// if pressed key is '=', this method will cal func Equals_Ñlick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '-') ||
                (e.KeyChar == ',') || (e.KeyChar == '='))
            {
               

                string s = textBox1.Text;
                if (e.KeyChar == ',')
                {
                    int i = s.IndexOf(',', 0, s.Length);
                    if (i != (-1)) { e.KeyChar = (char)Keys.None; }

                }
                if (e.KeyChar == '-')
                {
                    s = textBox1.Text;
                    int i = s.Length;
                    if (i > 0) { e.KeyChar = (char)Keys.None; }

                }
                if (e.KeyChar == '=')
                {
                    e.KeyChar = (char)Keys.None;
                    Equal_Click(sender, e);
                }
                
            }
            else { e.KeyChar = (char)Keys.None; }
            textBox1.Focus();

        }

        /// <summary>
        /// method that discribes logic of button 'SUBMIT'
        /// button 'SUBMIT' is for select MIN and MAX value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitValue_Click(object sender, EventArgs e)
        {
            try
            {
                MaxSize1 = Convert.ToInt32(MaxValue.Text);
            }
            catch
            {

            }
            if (MaxSize1 > MaxSize || MaxSize1 < MinSize)
            {
                MaxValue.Text = "0";
                string TooBigNumber = "Too big number for MAX value!";
                SystemSounds.Hand.Play();
                MessageBox.Show(TooBigNumber);
            }
            else
            {
                MaxSize1 = Convert.ToDouble(MaxValue.Text);
            }

            MinSize1 = Convert.ToInt32(MinValue.Text);
            if (MinSize1 < MinSize || MinSize1 > MaxSize)
            {
                MinValue.Text = "0";
                string TooSmallNumber = "Too small number for MIN value!";
                SystemSounds.Hand.Play();
                MessageBox.Show(TooSmallNumber);
            }
            else
            {
                MinSize1 = Convert.ToDouble(MinValue.Text);
            }

        }

        /// <summary>
        /// method that controls input to field MinValue
        /// in this field user can't input any symbols except digits, keychars 'BACK' and 'ENTER'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)
                || (e.KeyChar == (char)Keys.Enter))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    SubmitValue_Click((object)sender, e);
                }

            }
            else
            {
                e.KeyChar = (char)Keys.None;
                MinValue.Focus();
            }
        }

        /// <summary>
        /// method that controls input to field MinValue
        /// in this field user can't input any symbols except digits, keychars 'BACK' and 'ENTER'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)
                || (e.KeyChar == (char)Keys.Enter))
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    SubmitValue_Click((object)sender, e);
                }
                
            }
            else
            {
                e.KeyChar = (char)Keys.None;
                MaxValue.Focus();
            }
        }
    }
}
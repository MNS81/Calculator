namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private double number;
        private double result;
        private string operation;
        private void Button1_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "1";
        private void Button2_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "2";
        private void Button3_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "3";
        private void Button4_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "4";
        private void Button5_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "5";
        private void Button6_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "6";
        private void button7_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "7";
        private void Button8_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "8";
        private void Button9_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "9";
        private void Button0_Click(object sender, EventArgs e) => InputValuesTextBox.Text += "0";

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            number = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "plus";
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            number = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "minus";
        }
        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            number = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "moltiply";
        }
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            number = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "divide";
        }
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "plus":
                    result = number + double.Parse(InputValuesTextBox.Text);
                    InputValuesTextBox.Text = result.ToString();
                    break;
                case "minus":
                    result = number - double.Parse(InputValuesTextBox.Text);
                    InputValuesTextBox.Text = result.ToString();
                    break;
                case "moltiply":
                    result = number * double.Parse(InputValuesTextBox.Text);
                    InputValuesTextBox.Text = result.ToString();
                    break;
                case "divide":
                    double temp = double.Parse(InputValuesTextBox.Text);
                    if (temp != 0)
                    {
                        result = number / double.Parse(InputValuesTextBox.Text);
                        InputValuesTextBox.Text = result.ToString();
                    }
                    else
                        InputValuesTextBox.Text = "Œÿ»¡ ¿";
                    break;
            }
            number = 0;
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            InputValuesTextBox.Text = String.Empty;
            number = 0;
            result = 0;
        }
    }
}

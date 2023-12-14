namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
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
            result = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "plus";
        }
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            result = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "minus";
        }
        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            result = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "moltiply";
        }
        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            result = double.Parse(InputValuesTextBox.Text);
            InputValuesTextBox.Text = String.Empty;
            operation = "divide";
        }
        private void ButtonResult_Click(object sender, EventArgs e)
        {
            bool calculate = true;
            double value = double.Parse(InputValuesTextBox.Text);
            if (operation == "plus")
                result += value;
            else if (operation == "minus")
                result -= value;
            else if (operation == "moltiply")
                result *= value;
            else
            {
                if (value != 0)
                    result /= value;
                else
                    calculate = false;
            }
            InputValuesTextBox.Text = calculate == true ? result.ToString() : "Œÿ»¡ ¿";
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            InputValuesTextBox.Text = String.Empty;
            result = 0;
        }
    }
}

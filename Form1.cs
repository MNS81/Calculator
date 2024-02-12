using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private string value = "";
        private void Button_Click(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text;
            if (str == "C")
                value = "";
            else if (str == "=")
                value = new DataTable().Compute(value, null).ToString();
            else
                value += str;
            InputValuesTextBox.Text = value;
        }
    }
}

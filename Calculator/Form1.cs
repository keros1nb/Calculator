using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double currentValue = 0;
        private string currentOperator = "";
       


        public Form1()
        {

            InitializeComponent();
        }


      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "1";
        }

        private void btTwo_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "3";
        }

        private void btnFour_Click_1(object sender, EventArgs e)
        {
            displayLabel.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "5";
        }

        private void btnSix_Click_1(object sender, EventArgs e)
        {
            displayLabel.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "9";

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            displayLabel.Text += "0";
        }

  // кнопка "=" (и ее функция с приколом))
        private void btnEquals_Click_1(object sender, EventArgs e)
        {

            double newValue = double.Parse(displayLabel.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = currentValue + newValue;
                    break;
                case "-":
                    result = currentValue - newValue;
                    break;
                case "*":
                    result = currentValue * newValue;
                    break;
                case "/":
                    result = currentValue / newValue;
                    break;
            }

            
            displayLabel.Text = result.ToString();
            currentValue = result;
            currentOperator = "";


            if (result == 1000 - 7)
            {
                this.BackgroundImage = Image.FromFile("../../../Pictures/Ded.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                this.BackgroundImage = null;
            }
            displayLabel.Text = result.ToString();

        }
      //кнопка "+"
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //проверка числа на действительность , на которое произвоидтся действие 
            double newValue;
            if (!double.TryParse(displayLabel.Text, out newValue))
            {
                MessageBox.Show("Неверный ввод числа");
                return;
            }

            currentOperator = "+";
            currentValue += newValue;
            displayLabel.Text = "";

        }

        //кнопка "Clear(очистка)"
        private void btnClear_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "";
            currentValue = 0;
            currentOperator = "";
        }

        //кнопка "-"
        private void btnMinus_Click(object sender, EventArgs e)
        {
            //проверка числа на действительность , на которое произвоидтся действие 
            double newValue;
            if (!double.TryParse(displayLabel.Text, out newValue))
            {
                MessageBox.Show("Неверный ввод числа");
                return;
            }

            currentOperator = "-";
            currentValue = double.Parse(displayLabel.Text);
            displayLabel.Text = "";
        }

        //кнопка "*"
        private void button1_Click_1(object sender, EventArgs e)
        {
            //проверка числа на действительность , на которое произвоидтся действие 
            double newValue;
            if (!double.TryParse(displayLabel.Text, out newValue))
            {
                MessageBox.Show("Неверный ввод числа");
                return;
            }

            currentOperator = "*";
            currentValue = double.Parse(displayLabel.Text);
            displayLabel.Text = "";
        }

        //кнопка "/"
        private void btnDivide_Click(object sender, EventArgs e)
        {
            //проверка числа на действительность , на которое произвоидтся действие 
            double newValue;
            if (!double.TryParse(displayLabel.Text, out newValue))
            {
                MessageBox.Show("Неверный ввод числа");
                return;
            }

            currentOperator = "/";
            currentValue = double.Parse(displayLabel.Text);
            displayLabel.Text = "";
        }

        //кнопка "√"
        private void btnSqrt_Click(object sender, EventArgs e)
        {

            if (double.TryParse(displayLabel.Text, out double number))
            {
                double sqrt = Math.Sqrt(number);
                displayLabel.Text = sqrt.ToString();
                currentValue = sqrt;
                currentOperator = "";
            }
            else
            {
                MessageBox.Show("Корень не может быть найти из данного числа. Выберите другое число.");
            }
        }

        
    }
    }

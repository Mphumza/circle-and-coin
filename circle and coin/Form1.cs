using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace circle_and_coin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txtRadius.Text);
            double weight = double.Parse(txtWeight.Text);

            int num = ComboBox.SelectedIndex;

            Circle circleObj = new Circle(radius);

            Coin coinObj = new Coin(weight, radius);

            if (rbCoin.Checked)
            {
                if (num == 0) { lblAns.Text = coinObj.calcPerimeter().ToString(); }
                if (num == 1) { lblAns.Text = coinObj.calcArea().ToString(); }
                if (num == 2) { lblAns.Text = coinObj.getCoinValue().ToString(); }
            }

            if (rbCircle.Checked)
            {
                if (num == 0) { lblAns.Text = circleObj.calcPerimeter().ToString(); }
                if (num == 1) { lblAns.Text = circleObj.calcArea().ToString(); }

            }
            else
            {
                lblAns.Text = "INVALID OPTION";







            }
        }
    }
}







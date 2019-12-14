using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void Btn_is_Click(object sender, EventArgs e)
        {
            math get_sring = new math();
            string ans = "";
            double root1 = 0;
            double root2 = 0;
            double b = 0;
            double a = 0;
            double c = 0;
            double identifier = 0;
            int n ;
           
            //string XX = "1*x^2+6*x+5=0";
            string XX = tb_1.Text ;
            string aa = XX.Substring(0, 1);
            if (aa == "-" )
            {
                a = Convert.ToDouble(XX.Substring(0,2));
                n = 10;
            }
            else
            {
                a = Convert.ToDouble(aa);
                n = 9;
            }


            b = Convert.ToDouble(get_sring.GetStringBetween(XX, "*x^2", "*x"));
            c = Convert.ToDouble(get_sring.GetStringBetween(XX, XX.Substring(0, n ), "=0"));

            identifier = b * b - (4 * a * c);

            if (identifier > 0)
            {
                root1 = (-b + (Math.Sqrt(identifier) / (2 * a)));
                root2 = (-b - (Math.Sqrt(identifier) / (2 * a)));
                string r1 = Convert.ToString(root1);
                string r2 = Convert.ToString(root2);
                ans = " X = " + r1 + " X = " + r2;
                lbl_show.Text = ans.ToString();
            }

            if (identifier < 0)
            {
                double Real = (-b / (2 * a));
                double Complex = ((Math.Sqrt((identifier * (-1.00))) / (2 * a)));
                string SReal = Convert.ToString(Real);
                string SComplex = Convert.ToString(Complex);
                ans = "X = " + SReal + "+/-" + SComplex + "i";
                lbl_show.Text = ans.ToString();
            }

            if (identifier == 0)
            {
                root1 = (-b / (2 * a));
                string Root = Convert.ToString(root1);
                ans = "X : +/- " + Root;

                lbl_show.Text = ans.ToString();
            }
        }
    }
}

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
    public partial class Form2 : Form
    {
       
        public data dataObj { get; set; }
        public Form2()
        {
            InitializeComponent();

        }

        private void Bt_is_Click(object sender, EventArgs e)
        {
            data da = new data();

            //string authors = "100*x^3-12*z^4+15*y^5+200*t^1=0";  -1*x^1+1*q^1+2*z^1=1
            string authors = TB_1.Text;
            string aa = authors.Substring(0, 1);
            if (TB_1.Text[0] == '-')
            {
                authors += "$";
            }
            else
            {
                authors = TB_1.Text.Insert(0, "+");
                authors += "$";
            }
            string[] authorsList = authors.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '^', '*', '+', '-', '=','$' });
            foreach (string author in authorsList)
            {
                if (author.Trim() != "")
                {
                    da.dvg_2.Columns.Add(author, author);
                }
            }
            ///////////////////////////////////////////////////
            da.lb_show.Text = authors.Replace("$", "");
            da._show = authors.ToString();
            da.fnOj = this;
            da.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}

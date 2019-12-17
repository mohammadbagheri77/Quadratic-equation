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
    public partial class data : Form
    {
        public string _show { get; set; }
        public data()
        {
            InitializeComponent();

        }
        public Form2 fnOj { get; set; }
        private void Btn_1_Click(object sender, EventArgs e)
        {
            fnOj.dvg_3.Columns.Clear();
            fnOj.dvg_3.Rows.Clear();
            fnOj.dvg_3.Columns.Add("جواب", "جواب");

            // string authors = "1*x^2+1*z^3+2*t^3=0";           2*x^2+1*z^3=0

            /////////////////////////////////////////////////////////
            ///بررسی خالی بودن 
            check da_chki = new check();
            List<check> list_chki = new List<check>();
            List<string> list_data = new List<string>();
            for (int i = 0; i < dvg_2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dvg_2.Columns.Count; j++)
                {
                    if (string.IsNullOrWhiteSpace(dvg_2.Rows[i].Cells[j].Value.ToString()))
                    {
                        check da_chki1 = new check();
                        da_chki1.vali = dvg_2.Columns[j].HeaderText.ToString();
                        da_chki1.da_vali = dvg_2.Rows[i].Cells[j].Value.ToString();
                        da_chki1.is_por = false;
                        list_chki.Add(da_chki1);

                    }
                    else
                    {
                        check da_chki2 = new check();
                        da_chki2.vali = dvg_2.Columns[j].HeaderText.ToString();
                        da_chki2.da_vali = dvg_2.Rows[i].Cells[j].Value.ToString();
                        da_chki2.is_por = true;
                        list_chki.Add(da_chki2);
                    }

                }
            }
            //////////////////////////////////////////////////////////////////////////
            /////ساخت مجهولی
            List<string> rabt = new List<string>();
            int aa = 0;
            int cc = 0;
            int k = 0;
            int fs = dvg_2.Columns.Count;
            cc = fs;
            for (int i = 0; i < dvg_2.Rows.Count - 1; i++)
            {
                string f_show = " ";
                double fa = 0;
                double ff = 0;
                int b = 0;
                int bb = 0;

                for (k = aa; k < cc; k++)
                {
                    string s_show = _show;


                    if (list_chki[k].is_por == false)
                    {
                        string tvan = "";
                        b = _show.IndexOf($"{list_chki[k].vali}");
                        bb = b;
                        bb++;
                        b++;
                        if (Convert.ToString(_show[b]) == "^")
                        {
                            b++;
                            while (true)
                            {
                                if (_show[b] == '+')
                                {
                                    break;
                                }
                                if (_show[b] == '-')
                                {
                                    break;
                                }
                                if (_show[b] == '=')
                                {
                                    break;
                                }
                                else
                                {
                                    tvan += _show[b];
                                    b++;
                                }
                            }
                            Console.WriteLine(tvan);
                        }


                        string zarb = "";
                        int d = _show.IndexOf($"{list_chki[k].vali}");
                        d--;
                        if (Convert.ToString(_show[d]) != "^")
                        {
                            // d--;
                            while (true)
                            {
                                if (_show[d] == '+')
                                {
                                    break;
                                }
                                if (_show[d] == '-')
                                {
                                    break;
                                }
                                else
                                {
                                    d--;
                                    zarb = zarb.Insert(0, Convert.ToString(_show[d]));

                                }
                            }
                            // Console.WriteLine(c);
                        }


                        string mosave = "";
                        int q = _show.IndexOf("=");
                        if (Convert.ToString(_show[q]) != "^")
                        {
                            q++;
                            while (true)
                            {
                                if (_show[q] == '$')
                                {
                                    break;
                                }
                                else
                                {
                                    mosave += _show[q];
                                    q++;
                                }
                            }
                            //                       Console.WriteLine(a);
                        }

                        s_show = s_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", "").Replace($"={mosave}$", "");
                        if (mosave[0] == '-')
                        {
                            s_show += $"{mosave.Remove(0, 1)}";
                        }
                        else
                        {
                            s_show += $"-{mosave}";
                        }
                        //  s_show = s_show.Insert(0, "(");
                        //  s_show += ")";
                        //22*x^2+5*z^3+2*t^4=1
                        f_show = s_show;
                        if (zarb[0] == '-')
                        {
                            ff = -Convert.ToDouble(zarb.Remove(0, 1));
                        }
                        else
                        {
                            ff = Convert.ToDouble(zarb.Remove(0, 1));
                        }

                        fa = Convert.ToDouble(tvan);

                    }

                }

                for (k = aa; k < cc; k++)
                {

                    if (list_chki[k].is_por == true)
                    {
                        double result;
                        double jj;

                        string tvan = "";
                        b = _show.IndexOf($"{list_chki[k].vali}");
                        bb = _show.IndexOf($"{list_chki[k].vali}");
                        bb++;
                        b++;
                        if (Convert.ToString(_show[b]) == "^")
                        {
                            b++;
                            while (true)
                            {
                                if (_show[b] == '+')
                                {
                                    break;
                                }
                                if (_show[b] == '-')
                                {
                                    break;
                                }
                                if (_show[b] == '=')
                                {
                                    break;
                                }
                                else
                                {
                                    tvan += _show[b];
                                    b++;
                                }
                            }
                        }
                        string zarb = "";
                        int d = _show.IndexOf($"{list_chki[k].vali}");
                        d--;
                        if (Convert.ToString(_show[d]) != "^")
                        {
                            while (true)
                            {
                                if (_show[d] == '+')
                                {
                                    break;
                                }
                                if (_show[d] == '-')
                                {
                                    break;
                                }
                                else
                                {
                                    d--;
                                    zarb = zarb.Insert(0, Convert.ToString(_show[d]));
                                }
                            }
                        }

                        if (Convert.ToString(_show[bb]) == "^")
                        {
                            result = Math.Pow(Convert.ToDouble(list_chki[k].da_vali), Convert.ToDouble(tvan));

                            if (zarb[0] == '-')
                            {
                                jj = result * Convert.ToDouble(zarb);
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                jj = result * Convert.ToDouble(zarb);
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                           // jj = result * Convert.ToDouble(zarb);

                           // f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                        }
                        else
                        {
                            jj = Convert.ToDouble(list_chki[k].da_vali) * Convert.ToDouble(zarb.Remove(0, 1));
                            f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                        }
                    }
                }

                List<int> zz = new List<int>();
                List<string> xx = new List<string>();
                // string str1 = "+38-1-9";
                string str1 = f_show;
                string[] alamat = str1.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')' });
                string[] gam = str1.Split(new Char[] { '(', '+', '-', ')' });
                int ggam = 0;
                string vb = "";

                foreach (string author in gam)
                {
                    if (author.Trim() != "")
                        zz.Add(Convert.ToInt32(author));
                }

                foreach (string author in alamat)
                {
                    if (author.Trim() != "")
                        xx.Add(author);
                }

                for (int ll = 0; ll < zz.Count; ll++)
                {
                    vb += xx[ll] + Convert.ToString(zz[ll]);
                    ggam = Convert.ToInt32(vb) + ggam;
                    vb = "";
                }
                if (fa != 0)
                {
                    double jvab = Convert.ToDouble(ggam) / ff;
                    double res = Math.Ceiling(Math.Pow(jvab, (double)1 / fa));
                   // list_data.Add(Convert.ToString(res));
                    fnOj.dvg_3.Rows.Add(res);
                    // MessageBox.Show(Convert.ToString(res));
                }
                else
                {
                    double jvab = Convert.ToDouble(ggam) / ff;
                   // list_data.Add(Convert.ToString(jvab));
                    fnOj.dvg_3.Rows.Add(jvab);
                    // MessageBox.Show(Convert.ToString(jvab));
                }

                aa = cc;
                cc = cc + fs;
            }

            ////////////////////////////////////////////////////////////////////////////
            ///نمایش جدول اول
            DataGridView sourceGrid = this.dvg_2;
            DataGridView targetGrid = this.fnOj.dvg_1;

            var targetRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow sourceRow in sourceGrid.Rows)
            {
                if (!sourceRow.IsNewRow)
                {
                    var targetRow = (DataGridViewRow)sourceRow.Clone();
                    foreach (DataGridViewCell cell in sourceRow.Cells)
                    {
                        targetRow.Cells[cell.ColumnIndex].Value = cell.Value;
                    }
                    targetRows.Add(targetRow);
                }
            }
            targetGrid.Columns.Clear();
            foreach (DataGridViewColumn column in sourceGrid.Columns)
            {
                targetGrid.Columns.Add((DataGridViewColumn)column.Clone());
            }
            targetGrid.Rows.AddRange(targetRows.ToArray());
            ///////////////////////////////////////////////////////////////////////////
            ///نمایش جدول دوم
            //fnOj.dvg_3.Columns.Clear();
            //fnOj.dvg_3.Rows.Clear();
            //fnOj.dvg_3.Columns.Add("جواب", "جواب");

            //for (int ss = 0; ss < list_data.Count; ss++)
            //{
            //    fnOj.dvg_3.Rows.Add(list_data[ss]);
            //}

            Close();
        }



    }
}


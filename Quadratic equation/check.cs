using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Quadratic_equation
{
    class check
    {
        //   1*a^1+1*b^1+1*c^1=1
        public string vali { get; set; }
        public string da_vali { get; set; }
        public bool is_por { get; set; }
        public List<check> list_chki = new List<check>();
        public List<string> list_data = new List<string>();
        public List<string> list_d2 = new List<string>();
        /////////////////////////////////////////////////////////////
        public void get_One(string _vali, string _da_vali, bool _is_por)
        {
            check da_chki1 = new check();
            da_chki1.vali = _vali;
            da_chki1.da_vali = _da_vali;
            da_chki1.is_por = _is_por;
            list_chki.Add(da_chki1);
        }
        /////////////////////////////////////////////////////////////
        public double jvab;
        public string res;
        public string res2;
        public string out_One(int aa, int cc, string _show)
        {
            string f_show = " ";
            double fa = 0;
            double ff = 0;
            int b = 0;
            int bb = 0;
            int k;
            string mosave = "";
            string _name = "";
            for (k = aa; k < cc; k++)
            {
                string s_show = _show;


                if (list_chki[k].is_por == false)
                {
                    _name = list_chki[k].vali;
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
                            if (Convert.ToString(jj)[0] == '-')
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                        }
                        else
                        {
                            jj = result * Convert.ToDouble(zarb);
                            if (Convert.ToString(jj)[0] == '-')
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                            }
                            else
                            {
                                f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                            }
                        }
                    }
                    else
                    {
                        jj = Convert.ToDouble(list_chki[k].da_vali) * Convert.ToDouble(zarb.Remove(0, 1));
                        f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                    }
                }
            }

            List<BigInteger> zz = new List<BigInteger>();
            List<string> xx = new List<string>();
            // string str1 = "+38-1-9";
            string str1;

            str1 = f_show;

            string[] alamat = str1.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')' });
            string[] gam = str1.Split(new Char[] { '(', '+', '-', ')' });
            BigInteger ggam = 0;
            string vb = "";

            BigInteger a = new BigInteger();
            foreach (string author in gam)
            {
                if (author.Trim() != "")
                {
                    a = BigInteger.Parse(author);
                    zz.Add(a);
                }
            }

            foreach (string author in alamat)
            {
                if (author.Trim() != "")
                    xx.Add(author);
            }
            BigInteger d1 = new BigInteger();
            for (int ll = 0; ll < zz.Count; ll++)
            {
                vb += xx[ll] + Convert.ToString(zz[ll]);
                d1 = BigInteger.Parse(vb);
                ggam = d1 + ggam;
                vb = "";
            }

            if (fa != 1)
            {
                ggam = -ggam + Convert.ToInt32(mosave);
                jvab = Double.Parse(ggam.ToString()) / ff;
                res = _name + "= " + $"{Math.Ceiling(Math.Pow(jvab, (double)1 / fa))}";
            }
            else
            {
                ggam = -ggam + Convert.ToInt32(mosave);
                res = _name + "= " + $"{Double.Parse(ggam.ToString()) / ff}";
            }


            return res;
        }
        public string out_two(int aa, int cc, string _show)
        {
            string f_show = "";
            string d22 = "";

            int _num = 0;
            int bb = 0;
            int k;
            string mosave = "";
            string s_show = _show;
            List<string> add1 = new List<string>();
            for (k = aa; k < cc; k++)
            {

                int d = 0;
                int b = 0;

                if (list_chki[k].is_por == false)
                {
                    string tvan = "";
                    b = s_show.IndexOf($"{list_chki[k].vali}");
                    bb = b;
                    bb++;
                    b++;
                    if (Convert.ToString(s_show[b]) == "^")
                    {
                        b++;
                        while (true)
                        {
                            if (s_show[b] == '+')
                            {
                                break;
                            }
                            if (s_show[b] == '-')
                            {
                                break;
                            }
                            if (s_show[b] == '=')
                            {
                                break;
                            }
                            else
                            {
                                tvan += s_show[b];
                                b++;
                            }
                        }
                        Console.WriteLine(tvan);
                    }


                    string zarb = "";
                    d = s_show.IndexOf($"{list_chki[k].vali}");
                    d--;
                    if (Convert.ToString(s_show[d]) != "^")
                    {
                        // d--;
                        while (true)
                        {
                            if (s_show[d] == '+')
                            {
                                break;
                            }
                            if (s_show[d] == '-')
                            {
                                break;
                            }
                            else
                            {
                                d--;
                                zarb = zarb.Insert(0, Convert.ToString(s_show[d]));

                            }
                        }
                        Console.WriteLine(zarb);
                    }



                    s_show = s_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", "");
                    d22 = $"{zarb}*{list_chki[k].vali}^{tvan}";
                    list_d2.Add(d22);

                    f_show = s_show;

                }
            }

            int q = s_show.IndexOf("=");
            if (Convert.ToString(s_show[q]) != "^")
            {
                q++;
                while (true)
                {
                    if (s_show[q] == '$')
                    {
                        break;
                    }
                    else
                    {
                        mosave += s_show[q];
                        q++;
                    }
                }
                //                       Console.WriteLine(a);
            }
            f_show = f_show.Replace($"={mosave}$", "");

            for (k = aa; k < cc; k++)
            {
                int d = 0;
                int b = 0;
                if (list_chki[k].is_por == true)
                {
                    string[] aList = list_chki[k].da_vali.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '^', '*', '+', '-', '=', '$' });
                    List<string> lk = new List<string>();
                    foreach (string au in aList)
                    {
                        if (au.Trim() != "")
                        {
                            lk.Add(au);
                        }
                    }


                    if (lk.Count == 0)
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
                        d = _show.IndexOf($"{list_chki[k].vali}");
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
                                if (Convert.ToString(jj)[0] == '-')
                                {
                                    f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                                }
                                else
                                {
                                    f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                                }
                            }
                            else
                            {
                                jj = result * Convert.ToDouble(zarb);
                                if (Convert.ToString(jj)[0] == '-')
                                {
                                    f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                                }
                                else
                                {
                                    f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"+{Convert.ToString(jj)}");
                                }
                            }
                        }
                        else
                        {
                            jj = Convert.ToDouble(list_chki[k].da_vali) * Convert.ToDouble(zarb.Remove(0, 1));
                            f_show = f_show.Replace($"{zarb}*{list_chki[k].vali}^{tvan}", $"{Convert.ToString(jj)}");
                        }
                    }
                    else
                    {
                        _num = 1;

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
                        d = _show.IndexOf($"{list_chki[k].vali}");
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
                            for (int kl = 0; kl < lk.Count; kl++)
                            {
                                string tvan1 = "";
                                string str2 = "";
                                str2 = list_chki[k].da_vali;
                                str2 += "=0";
                                b = str2.IndexOf($"{lk[kl]}");
                                b++;
                                if (Convert.ToString(str2[b]) == "^")
                                {
                                    b++;
                                    while (true)
                                    {
                                        if (str2[b] == '+')
                                        {
                                            break;
                                        }
                                        if (str2[b] == '-')
                                        {
                                            break;
                                        }
                                        if (str2[b] == '=')
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            tvan1 += str2[b];
                                            b++;
                                        }
                                    }
                                }

                                //  Console.WriteLine(tvan1);
                                string zarb1 = "";
                                d = str2.IndexOf($"{lk[kl]}");
                                d--;
                                if (Convert.ToString(str2[d]) != "^")
                                {
                                    while (true)
                                    {
                                        if (str2[d] == '+')
                                        {
                                            break;
                                        }
                                        if (str2[d] == '-')
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            d--;
                                            zarb1 = zarb1.Insert(0, Convert.ToString(str2[d]));
                                        }
                                    }
                                }

                                // Console.WriteLine(zarb1);
                                //////////////////////////////////////////////
                                string tvan2 = "";
                                b = _show.IndexOf($"{lk[kl]}");
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
                                            tvan2 += _show[b];
                                            b++;
                                        }
                                    }
                                }
                                Console.WriteLine(tvan2);

                                string zarb2 = "";
                                d = _show.IndexOf($"{lk[kl]}");
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
                                            zarb2 = zarb2.Insert(0, Convert.ToString(_show[d]));
                                        }
                                    }
                                }
                                Console.WriteLine(zarb2);
                                ////////////////////////////////////////////////
                                string str1 = "";
                                string str3 = "";
                                if (tvan1 == tvan2)
                                {
                                    if (zarb1[0] == '+')
                                    {

                                        str1 = $"{Convert.ToInt32(zarb) * (Convert.ToInt32(zarb1) + Convert.ToInt32(zarb2))}";
                                        str1 += lk[kl] + "^" + tvan1;
                                        add1.Add("+" + str1);
                                    }
                                    else
                                    {

                                        str1 = $"{Convert.ToInt32(zarb) * (Convert.ToInt32(zarb1) + Convert.ToInt32(zarb2))}";
                                        str1 += lk[kl] + "^" + tvan1;
                                        add1.Add("-" + str1);
                                    }

                                }
                                else
                                {
                                    str1 = $"{Convert.ToInt32(zarb) * Convert.ToInt32(zarb1) }";
                                    str1 += lk[kl] + "^" + tvan1;
                                    str3 = $"{Convert.ToInt32(zarb) * Convert.ToInt32(zarb2) }";
                                    str3 += lk[kl] + "^" + tvan2;
                                    if (zarb2[0] == '+')
                                    {
                                        str1 += "+" + str3;
                                        add1.Add(str1);
                                    }
                                    else
                                    {
                                        str1 += "-" + str3;
                                        add1.Add(str1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (_num == 0)
            {
                List<BigInteger> zz = new List<BigInteger>();
                List<string> xx = new List<string>();
                // string str1 = "+38-1-9";
                string str1;

                str1 = f_show;

                string[] alamat = str1.Split(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')' });
                string[] gam = str1.Split(new Char[] { '(', '+', '-', ')' });
                BigInteger ggam = 0;
                string vb = "";

                BigInteger a = new BigInteger();
                foreach (string author in gam)
                {
                    if (author.Trim() != "")
                    {
                        a = BigInteger.Parse(author);
                        zz.Add(a);
                    }
                }

                foreach (string author in alamat)
                {
                    if (author.Trim() != "")
                        xx.Add(author);
                }
                BigInteger d1 = new BigInteger();
                for (int ll = 0; ll < zz.Count; ll++)
                {
                    vb += xx[ll] + Convert.ToString(zz[ll]);
                    d1 = BigInteger.Parse(vb);
                    ggam = d1 + ggam;
                    vb = "";
                }

                for (int gg = 0; gg < list_d2.Count; gg++)
                {
                    res2 += list_d2[gg];
                }
                res2 += "=";
                ggam = -ggam + Convert.ToInt32(mosave);
                res2 += $"{ggam}";
            }
            else
            {
                for (int kl = 0; kl < add1.Count; kl++)
                {
                    res2 += add1[kl];
                }
                res2 += "=" + mosave;
            }


            return res2;
        }

    }
}

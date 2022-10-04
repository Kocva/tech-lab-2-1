using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int penny;
            try
            {
                penny = int.Parse(this.txtPenny.Text);
            }
            catch
            {
                return;
            }
            MessageBox.Show(logic.Convert(penny));
        }
    }

    public class logic
    {
        public static string Convert(int penny)
        {
            string outMessage = "";
            if (penny >= 1 & penny <= 9999)
            {
                int rubles = penny / 100;
                var pennyRes = penny % 100;

                if (pennyRes <= 20)
                {
                    if (rubles % 10 == 1)
                        outMessage = rubles + " рубль " + pennyRes + " копеек";
                    else if (rubles == 0)
                        outMessage = pennyRes + " копеек";
                    else if (rubles % 10 > 1 && rubles % 10 < 5)
                        outMessage = rubles + " рубля " + pennyRes + " копеек";
                    else if ((rubles % 10) > 4 || (rubles % 10) == 0)
                        outMessage = rubles + " рублей " + pennyRes + " копеек";

                }
                else if (pennyRes == 0)
                {
                    if (rubles % 10 == 1)
                        outMessage = rubles + " рубль ровно";
                    else if (rubles % 10 > 1 && rubles % 10 < 5)
                        outMessage = rubles + " рубля ровно";
                    else if ((rubles % 10) > 4 || (rubles % 10) == 0)
                        outMessage = rubles + " рублей ровно";

                }

                else if (pennyRes % 10 == 1)
                {
                    if (rubles % 10 == 1)
                        outMessage = rubles + " рубль " + pennyRes + " копейка";
                    else if (rubles == 0)
                        outMessage = pennyRes + " копейка";
                    else if (rubles % 10 > 1 && rubles % 10 < 5)
                        outMessage = rubles + " рубля " + pennyRes + " копейка";
                    else if ((rubles % 10) > 4 || (rubles % 10) == 0)
                        outMessage = rubles + " рублей " + pennyRes + " копейка";

                }

                else if (pennyRes % 10 > 1 && pennyRes % 10 < 5)
                {
                    if (rubles % 10 == 1)
                        outMessage = rubles + " рубль " + pennyRes + " копейки";
                    else if (rubles == 0)
                        outMessage = pennyRes + " копейки";
                    else if (rubles % 10 > 1 && rubles % 10 < 5)
                        outMessage = rubles + " рубля " + pennyRes + " копейки";
                    else if ((rubles % 10) > 4 || (rubles % 10) == 0)
                        outMessage = rubles + " рублей " + pennyRes + " копейки";

                }

                else if (pennyRes % 10 > 4)
                {
                    if (rubles % 10 == 1)
                        outMessage = rubles + " рубль " + pennyRes + " копеек";
                    else if (rubles == 0)
                        outMessage = pennyRes + " копеек";
                    else if (rubles % 10 > 1 && rubles % 10 < 5)
                        outMessage = rubles + " рубля " + pennyRes + " копеек";
                    else if ((rubles % 10) > 4 || (rubles % 10) == 0)
                        outMessage = rubles + " рублей " + pennyRes + " копеек";

                }



            }
            else
            {
                outMessage = "Введенное число не входит в диапазон";
            }
            return outMessage;

        }
    }
}

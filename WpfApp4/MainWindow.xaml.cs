using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEEuro = Convert.ToDouble(rateE.Text);
            double sumEEuro = Convert.ToDouble(sumE.Text);
            double resEEuro = rateEEuro * sumEEuro;
            resSumE.Text = resEEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGGri = Convert.ToDouble(rateG.Text);
            double sumGGri = Convert.ToDouble(sumG.Text);
            double resGGri = rateGGri * sumGGri;
            resSumG.Text = resGGri.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateHDr = Convert.ToDouble(rateH.Text);
            double sumHDr = Convert.ToDouble(sumH.Text);
            double resHDr = rateHDr * sumHDr;
            resSumH.Text = resHDr.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double dmD = Convert.ToDouble(Dm.Text);           
            double resdmD = dmD * 0.0254;
            resDM.Text = resdmD.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            double ftF = Convert.ToDouble(Ft.Text);
            double resftF = ftF * 0.3048;
            resFt.Text = resftF.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mlM= Convert.ToDouble(Ml.Text);
            double resmlM = mlM * 1609.344;
            resMl.Text = resmlM.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double vrV = Convert.ToDouble(Vr.Text);
            double resvrV = vrV * 1066.8;
            resMl.Text = resvrV.ToString();
        }
    }
}

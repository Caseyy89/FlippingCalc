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

namespace FlippingCalc
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Exit Button
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(99);
        }
        // Reset Button
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //Buy Buttons
            BuyAlchemy.Clear();
            BuyAlt.Clear();
            BuyAncient.Clear();
            BuyAnnulment.Clear();
            BuyAugment.Clear();
            BuyBauble.Clear();
            BuyBinding.Clear();
            BuyBlessed.Clear();
            BuyChance.Clear();
            BuyChisel.Clear();
            BuyChromatic.Clear();
            BuyDivine.Clear();
            BuyEngineers.Clear();
            BuyEx.Clear();
            BuyFusing.Clear();
            BuyGCP.Clear();
            BuyHarbinger.Clear();
            BuyHorizons.Clear();
            BuyJeweller.Clear();
            BuyOffering.Clear();
            BuyPerandus.Clear();
            BuyPortal.Clear();
            BuyRegal.Clear();
            BuyRegret.Clear();
            BuyRSextant.Clear();
            BuyScouring.Clear();
            BuyScrap.Clear();
            BuySilver.Clear();
            BuyTransmute.Clear();
            BuyVaal.Clear();
            BuyWhetstone.Clear();
            BuyWisdom.Clear();
            BuyWSextant.Clear();
            BuyYSextant.Clear();
            //Sell Buttons
            SellAlchemy.Clear();
            SellAlt.Clear();
            SellAncient.Clear();
            SellAnnulment.Clear();
            SellAugment.Clear();
            SellBauble.Clear();
            SellBinding.Clear();
            SellBlessed.Clear();
            SellChance.Clear();
            SellChisel.Clear();
            SellChromatic.Clear();
            SellDivine.Clear();
            SellEngineers.Clear();
            SellEx.Clear();
            SellFusing.Clear();
            SellGCP.Clear();
            SellHarbinger.Clear();
            SellHorizons.Clear();
            SellJeweller.Clear();
            SellOffering.Clear();
            SellPerandus.Clear();
            SellPortal.Clear();
            SellRegal.Clear();
            SellRegret.Clear();
            SellRSextant.Clear();
            SellScouring.Clear();
            SellScrap.Clear();
            SellSilver.Clear();
            SellTransmute.Clear();
            SellVaal.Clear();
            SellWhetstone.Clear();
            SellWisdom.Clear();
            SellWSextant.Clear();
            SellYSextant.Clear();
            //Profit TextBoxes
            ProfitAlchemy.Clear();
            ProfitAlt.Clear();
            ProfitAncient.Clear();
            ProfitAnnulment.Clear();
            ProfitAugment.Clear();
            ProfitBauble.Clear();
            ProfitBinding.Clear();
            ProfitBlessed.Clear();
            ProfitChance.Clear();
            ProfitChisel.Clear();
            ProfitChromatic.Clear();
            ProfitDivine.Clear();
            ProfitEngineers.Clear();
            ProfitEx.Clear();
            ProfitFusing.Clear();
            ProfitGCP.Clear();
            ProfitHarbinger.Clear();
            ProfitHorizons.Clear();
            ProfitJeweller.Clear();
            ProfitOffering.Clear();
            ProfitPerandus.Clear();
            ProfitPortal.Clear();
            ProfitRegal.Clear();
            ProfitRegret.Clear();
            ProfitRSextant.Clear();
            ProfitScouring.Clear();
            ProfitScrap.Clear();
            ProfitSilver.Clear();
            ProfitTransmute.Clear();
            ProfitVaal.Clear();
            ProfitWhetstone.Clear();
            ProfitWisdom.Clear();
            ProfitWSextant.Clear();
            ProfitYSextant.Clear();

        }
        // Calc Button
        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            GetResultInTextBox1(BuyAlchemy, SellAlchemy, ProfitAlchemy);
            GetResultInTextBox1(BuyAlt, SellAlt, ProfitAlt);
            GetResultInTextBox1(BuyAncient, SellAncient, ProfitAncient);
            GetResultInTextBox1(BuyAnnulment, SellAnnulment, ProfitAnnulment);
            GetResultInTextBox1(BuyAugment, SellAugment, ProfitAugment);
            GetResultInTextBox1(BuyBauble, SellBauble, ProfitBauble);
            GetResultInTextBox1(BuyBinding, SellBinding, ProfitBinding);
            GetResultInTextBox1(BuyBlessed, SellBlessed, ProfitBlessed);
            GetResultInTextBox1(BuyChance, SellChance, ProfitChance);
            GetResultInTextBox1(BuyChisel, SellChisel, ProfitChisel);
            GetResultInTextBox1(BuyChromatic, SellChromatic, ProfitChromatic);
            GetResultInTextBox1(BuyDivine, SellDivine, ProfitDivine);
            GetResultInTextBox1(BuyEngineers, SellEngineers, ProfitEngineers);
            GetResultInTextBox1(BuyEx, SellEx, ProfitEx);
            GetResultInTextBox1(BuyFusing, SellFusing, ProfitFusing);
            GetResultInTextBox1(BuyGCP, SellGCP, ProfitGCP);
            GetResultInTextBox1(BuyHarbinger, SellHarbinger, ProfitHarbinger);
            GetResultInTextBox1(BuyHorizons, SellHorizons, ProfitHorizons);
            GetResultInTextBox1(BuyJeweller, SellJeweller, ProfitJeweller);
            GetResultInTextBox1(BuyOffering, SellOffering, ProfitOffering);
            GetResultInTextBox1(BuyPerandus, SellPerandus, ProfitPerandus);
            GetResultInTextBox1(BuyPortal, SellPortal, ProfitPortal);
            GetResultInTextBox1(BuyRegal, SellRegal, ProfitRegal);
            GetResultInTextBox1(BuyRegret, SellRegret, ProfitRegret);
            GetResultInTextBox1(BuyRSextant, SellRSextant, ProfitRSextant);
            GetResultInTextBox1(BuyScouring, SellScouring, ProfitScouring);
            GetResultInTextBox1(BuyScrap, SellScrap, ProfitScrap);
            GetResultInTextBox1(BuySilver, SellSilver, ProfitSilver);
            GetResultInTextBox1(BuyTransmute, SellTransmute, ProfitTransmute);
            GetResultInTextBox1(BuyVaal, SellVaal, ProfitVaal);
            GetResultInTextBox1(BuyWhetstone, SellWhetstone, ProfitWhetstone);
            GetResultInTextBox1(BuyWisdom, SellWisdom, ProfitWisdom);
            GetResultInTextBox1(BuyWSextant, SellWSextant, ProfitWSextant);
            GetResultInTextBox1(BuyYSextant, SellYSextant, ProfitYSextant);

        }
        // Math for Profit Box
        public void GetResultInTextBox1(TextBox first, TextBox second, TextBox result)
        {
            var r1 = float.TryParse(first.Text, out float a);
            var r2 = float.TryParse(second.Text, out float b);

            if (r1 && r2)
            {
                result.Text = Math.Round(100 - ((a / b) * 100), 3).ToString() + "%"; // (100 - (buy/sell) * 100),3) , into a string with 3 decimals and a % behind it 
            }
            else
            {
                result.Text = "";
            }
        }
        // Links Button
        private void LinksButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 subWindow = new Window1();
            subWindow.Show();
        }
        // Quant Button
        private void QuantButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 subWindow = new Window2();
            subWindow.Show();

            GetResultInTextBox2(BuyAlt, SellAlt, QuantBox, subWindow.QuantBuyAlt, subWindow.QuantSellAlt);
            GetResultInTextBox2(BuyAlchemy, SellAlchemy, QuantBox, subWindow.QuantBuyAlch, subWindow.QuantSellAlch);
            GetResultInTextBox2(BuyAncient, SellAncient, QuantBox, subWindow.QuantBuyAncient, subWindow.QuantSellAncient);
            GetResultInTextBox2(BuyAnnulment, SellAnnulment, QuantBox, subWindow.QuantBuyAnnulment, subWindow.QuantSellAnnulment);
            GetResultInTextBox2(BuyAugment, SellAugment, QuantBox, subWindow.QuantBuyAugmentation, subWindow.QuantSellAugmentation);
            GetResultInTextBox2(BuyBauble, SellBauble, QuantBox, subWindow.QuantBuyBauble, subWindow.QuantSellBauble);
            GetResultInTextBox2(BuyBinding, SellBinding, QuantBox, subWindow.QuantBuyBinding, subWindow.QuantSellBinding);
            GetResultInTextBox2(BuyBlessed, SellBlessed, QuantBox, subWindow.QuantBuyBlessed, subWindow.QuantSellBlessed);
            GetResultInTextBox2(BuyChance, SellChance, QuantBox, subWindow.QuantBuyChance, subWindow.QuantSellChance);
            GetResultInTextBox2(BuyChisel, SellChisel, QuantBox, subWindow.QuantBuyChisel, subWindow.QuantSellChisel);
            GetResultInTextBox2(BuyChromatic, SellChromatic, QuantBox, subWindow.QuantBuyChromatic, subWindow.QuantSellChromatic);
            GetResultInTextBox2(BuyDivine, SellDivine, QuantBox, subWindow.QuantBuyDivine, subWindow.QuantSellDivine);
            GetResultInTextBox2(BuyEngineers, SellEngineers, QuantBox, subWindow.QuantBuyEngineers, subWindow.QuantSellEngineers);
            GetResultInTextBox2(BuyEx, SellEx, QuantBox, subWindow.QuantBuyEx, subWindow.QuantSellEx);
            GetResultInTextBox2(BuyFusing, SellFusing, QuantBox, subWindow.QuantBuyFusing, subWindow.QuantSellFusing);
            GetResultInTextBox2(BuyGCP, SellGCP, QuantBox, subWindow.QuantBuyGCP, subWindow.QuantSellGCP);
            GetResultInTextBox2(BuyHarbinger, SellHarbinger, QuantBox, subWindow.QuantBuyHarbinger, subWindow.QuantSellHarbinger);
            GetResultInTextBox2(BuyHorizons, SellHorizons, QuantBox, subWindow.QuantBuyHorizons, subWindow.QuantSellHorizons);
            GetResultInTextBox2(BuyJeweller, SellJeweller, QuantBox, subWindow.QuantBuyJewellers, subWindow.QuantSellJewellers);
            GetResultInTextBox2(BuyOffering, SellOffering, QuantBox, subWindow.QuantBuyOffering, subWindow.QuantSellOffering);
            GetResultInTextBox2(BuyPerandus, SellPerandus, QuantBox, subWindow.QuantBuyPerandus, subWindow.QuantSellPerandus);
            GetResultInTextBox2(BuyPortal, SellPortal, QuantBox, subWindow.QuantBuyPortal, subWindow.QuantSellPortal);
            GetResultInTextBox2(BuyRegal, SellRegal, QuantBox, subWindow.QuantBuyRegal, subWindow.QuantSellRegal);
            GetResultInTextBox2(BuyRegret, SellRegret, QuantBox, subWindow.QuantBuyRegret, subWindow.QuantSellRegret);
            GetResultInTextBox2(BuyRSextant, SellRSextant, QuantBox, subWindow.QuantBuyRSextant, subWindow.QuantSellRSextant);
            GetResultInTextBox2(BuyScouring, SellScouring, QuantBox, subWindow.QuantBuyScouring, subWindow.QuantSellScouring);
            GetResultInTextBox2(BuyScrap, SellScrap, QuantBox, subWindow.QuantBuyScrap, subWindow.QuantSellScrap);
            GetResultInTextBox2(BuySilver, SellSilver, QuantBox, subWindow.QuantBuySilver, subWindow.QuantSellSilver);
            GetResultInTextBox2(BuyTransmute, SellTransmute, QuantBox, subWindow.QuantBuyTransmute, subWindow.QuantSellTransmute);
            GetResultInTextBox2(BuyVaal, SellVaal, QuantBox, subWindow.QuantBuyVaal, subWindow.QuantSellVaal);
            GetResultInTextBox2(BuyWhetstone, SellWhetstone, QuantBox, subWindow.QuantBuyWhetstone, subWindow.QuantSellWhetstone);
            GetResultInTextBox2(BuyWisdom, SellWisdom, QuantBox, subWindow.QuantBuyWisdom, subWindow.QuantSellWisdom);
            GetResultInTextBox2(BuyWSextant, SellWSextant, QuantBox, subWindow.QuantBuyWSextant, subWindow.QuantSellWSextant);
            GetResultInTextBox2(BuyYSextant, SellYSextant, QuantBox, subWindow.QuantBuyYSextant, subWindow.QuantSellYSextant);

        }
        // Math for Quant Button
        public void GetResultInTextBox2(TextBox first, TextBox second, TextBox third, TextBox fourth, TextBox fifth)
        {
            var r1 = float.TryParse(first.Text, out float a);
            var r2 = float.TryParse(second.Text, out float b);
            var r3 = float.TryParse(third.Text, out float c);

            if (r1 && r2 && r3)
            {
                fourth.Text = Math.Round((c / a), 3).ToString(); // quant x buy/sell = quant x C 
                fifth.Text = Math.Round((c / b), 3).ToString();
            }
            else
            {
                fourth.Text = "";
                fifth.Text = "";
            }
        }

    }
}

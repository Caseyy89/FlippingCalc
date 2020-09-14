using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using MahApps.Metro.Controls;
using ControlzEx.Theming;

namespace FlippingCalc
{
    /// </summary>
    public partial class Calc : MetroWindow
    {
        public Calc()
        {
            InitializeComponent();
        }

        //Discord Button
        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://discord.com/invite/vStKutp");
        }

        // Exit Button
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(99);
        }
        // Reset Button Currency
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //Buy Buttons
            BuyAlchemy.Clear();
            BuyAlt.Clear();
            BuyAncient.Clear();
            BuyAnnulment.Clear();
            BuyAugmentation.Clear();
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
            BuyPerandus.Clear();
            BuyPortal.Clear();
            BuyRegal.Clear();
            BuyRegret.Clear();
            BuySimple_Sextant.Clear();
            BuyScouring.Clear();
            BuyScrap.Clear();
            BuySilver.Clear();
            BuyTransmute.Clear();
            BuyVaal.Clear();
            BuyWhetstone.Clear();
            BuyWisdom.Clear();
            BuyPrime_Sextant.Clear();
            BuyAwakened_Sextant.Clear();
            BuyMirror.Clear();
            BuyHunter.Clear();
            BuyWarlord.Clear();
            BuyRedeemer.Clear();
            BuyCrusader.Clear();
            //Sell Buttons
            SellAlchemy.Clear();
            SellAlt.Clear();
            SellAncient.Clear();
            SellAnnulment.Clear();
            SellAugmentation.Clear();
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
            SellPerandus.Clear();
            SellPortal.Clear();
            SellRegal.Clear();
            SellRegret.Clear();
            SellSimple_Sextant.Clear();
            SellScouring.Clear();
            SellScrap.Clear();
            SellSilver.Clear();
            SellTransmute.Clear();
            SellVaal.Clear();
            SellWhetstone.Clear();
            SellWisdom.Clear();
            SellPrime_Sextant.Clear();
            SellAwakened_Sextant.Clear();
            SellMirror.Clear();
            SellHunter.Clear();
            SellWarlord.Clear();
            SellRedeemer.Clear();
            SellCrusader.Clear();
            //Profit TextBoxes
            ProfitAlchemy.Clear();
            ProfitAlt.Clear();
            ProfitAncient.Clear();
            ProfitAnnulment.Clear();
            ProfitAugmentation.Clear();
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
            ProfitPerandus.Clear();
            ProfitPortal.Clear();
            ProfitRegal.Clear();
            ProfitRegret.Clear();
            ProfitSimple_Sextant.Clear();
            ProfitScouring.Clear();
            ProfitScrap.Clear();
            ProfitSilver.Clear();
            ProfitTransmute.Clear();
            ProfitVaal.Clear();
            ProfitWhetstone.Clear();
            ProfitWisdom.Clear();
            ProfitPrime_Sextant.Clear();
            ProfitAwakened_Sextant.Clear();
            ProfitMirror.Clear();
            ProfitHunter.Clear();
            ProfitWarlord.Clear();
            ProfitRedeemer.Clear();
            ProfitCrusader.Clear();
            //Quantbox
            QuantBox.Clear();
        }
        // Reset Button Fossil
        private void ResetButtonFossil_Click(object sender, RoutedEventArgs e)
        {
            //Buy Buttons
            BuyAberrant.Clear();
            BuyAetheric.Clear();
            BuyBloodstained.Clear();
            BuyBound.Clear();
            BuyCorroded.Clear();
            BuyDense.Clear();
            BuyEnchanted.Clear();
            BuyEncrusted.Clear();
            BuyFaceted.Clear();
            BuyFractured.Clear();
            BuyFrigid.Clear();
            BuyGilded.Clear();
            BuyGlyphic.Clear();
            BuyHollow.Clear();
            BuyJagged.Clear();
            BuyLucent.Clear();
            BuyMetallic.Clear();
            BuyPerfect.Clear();
            BuyPrismatic.Clear();
            BuyPristine.Clear();
            BuySanctified.Clear();
            BuyScorched.Clear();
            BuySerrated.Clear();
            BuyShuddering.Clear();
            BuyTangled.Clear();
            //Sell Buttons
            SellAberrant.Clear();
            SellAetheric.Clear();
            SellBloodstained.Clear();
            SellBound.Clear();
            SellCorroded.Clear();
            SellDense.Clear();
            SellEnchanted.Clear();
            SellEncrusted.Clear();
            SellFaceted.Clear();
            SellFractured.Clear();
            SellFrigid.Clear();
            SellGilded.Clear();
            SellGlyphic.Clear();
            SellHollow.Clear();
            SellJagged.Clear();
            SellLucent.Clear();
            SellMetallic.Clear();
            SellPerfect.Clear();
            SellPrismatic.Clear();
            SellPristine.Clear();
            SellSanctified.Clear();
            SellScorched.Clear();
            SellSerrated.Clear();
            SellShuddering.Clear();
            SellTangled.Clear();
            //Profit TextBoxes
            ProfitAberrant.Clear();
            ProfitAetheric.Clear();
            ProfitBloodstained.Clear();
            ProfitBound.Clear();
            ProfitCorroded.Clear();
            ProfitDense.Clear();
            ProfitEnchanted.Clear();
            ProfitEncrusted.Clear();
            ProfitFaceted.Clear();
            ProfitFractured.Clear();
            ProfitFrigid.Clear();
            ProfitGilded.Clear();
            ProfitGlyphic.Clear();
            ProfitHollow.Clear();
            ProfitJagged.Clear();
            ProfitLucent.Clear();
            ProfitMetallic.Clear();
            ProfitPerfect.Clear();
            ProfitPrismatic.Clear();
            ProfitPristine.Clear();
            ProfitSanctified.Clear();
            ProfitScorched.Clear();
            ProfitSerrated.Clear();
            ProfitShuddering.Clear();
            ProfitTangled.Clear();
            //Quantbox
            QuantBoxFossil.Clear();
        }

        // Reset Button Oil
        private void ResetButtonOil_Click(object sender, RoutedEventArgs e)
        {
            //Buy Buttons
            BuyClear.Clear();
            BuySepia.Clear();
            BuyAmber.Clear();
            BuyVerdant.Clear();
            BuyTeal.Clear();
            BuyAzure.Clear();
            BuyIndigo.Clear();
            BuyViolet.Clear();
            BuyCrimson.Clear();
            BuyBlack.Clear();
            BuyOpal.Clear();
            BuySilverOil.Clear();
            BuyGolden.Clear();
            //Sell Buttons
            SellClear.Clear();
            SellSepia.Clear();
            SellAmber.Clear();
            SellVerdant.Clear();
            SellTeal.Clear();
            SellAzure.Clear();
            SellIndigo.Clear();
            SellViolet.Clear();
            SellCrimson.Clear();
            SellBlack.Clear();
            SellOpal.Clear();
            SellSilverOil.Clear();
            SellGolden.Clear();
            //Profit TextBoxes
            ProfitClear.Clear();
            ProfitSepia.Clear();
            ProfitAmber.Clear();
            ProfitVerdant.Clear();
            ProfitTeal.Clear();
            ProfitAzure.Clear();
            ProfitIndigo.Clear();
            ProfitViolet.Clear();
            ProfitCrimson.Clear();
            ProfitBlack.Clear();
            ProfitOpal.Clear();
            ProfitSilverOil.Clear();
            ProfitGolden.Clear();
            //Quantbox
            QuantBoxOil.Clear();
            
        }

        // Reset Button Cata
        private void ResetButtonCata_Click(object sender, RoutedEventArgs e)
        {
            //Buy Buttons
            BuyAbrasive.Clear();
            BuyFertile.Clear();
            BuyImbued.Clear();
            BuyIntrinsic.Clear();
            BuyPrismaticCata.Clear();
            BuyTempering.Clear();
            BuyTurbulent.Clear();
            //Sell Buttons
            SellAbrasive.Clear();
            SellFertile.Clear();
            SellImbued.Clear();
            SellIntrinsic.Clear();
            SellPrismaticCata.Clear();
            SellTempering.Clear();
            SellTurbulent.Clear();
            //Profit TextBoxes
            ProfitAbrasive.Clear();
            ProfitFertile.Clear();
            ProfitImbued.Clear();
            ProfitIntrinsic.Clear();
            ProfitPrismaticCata.Clear();
            ProfitTempering.Clear();
            ProfitTurbulent.Clear();
            //Quantbox
            QuantBoxCata.Clear();

        }

        // Reset Button Fragments
        private void ResetButtonFragment_Click(object sender, RoutedEventArgs e)
        {
            //Buy Buttons
            BuyAtziri1.Clear();
            BuyAtziri2.Clear();
            BuyAtziri3.Clear();
            BuyAtziri4.Clear();
            BuyUAtziri1.Clear();
            BuyUAtziri2.Clear();
            BuyUAtziri3.Clear();
            BuyUAtziri4.Clear();
            BuyPale1.Clear();
            BuyPale2.Clear();
            BuyPale3.Clear();
            BuyPale4.Clear();
            BuyHydra.Clear();
            BuyPhoenix.Clear();
            BuyMinotaur.Clear();
            BuyChimera.Clear();
            BuyElder1.Clear();
            BuyElder2.Clear();
            BuyElder3.Clear();
            BuyElder4.Clear();
            BuyUElder1.Clear();
            BuyUElder2.Clear();
            BuyUElder3.Clear();
            BuyUElder4.Clear();
            BuyXoph.Clear();
            BuyTul.Clear();
            BuyEsh.Clear();
            BuyNetol.Clear();
            BuyChayula.Clear();
            BuyKarui.Clear();
            BuyMaraketh.Clear();
            BuyTemplar.Clear();
            BuyVaalE.Clear();
            BuyEternal.Clear ();
            BuyOffering.Clear();
            BuyDVessel.Clear();
            BuySimulacrum.Clear();
            //Sell Buttons
            SellAtziri1.Clear();
            SellAtziri2.Clear();
            SellAtziri3.Clear();
            SellAtziri4.Clear();
            SellUAtziri1.Clear();
            SellUAtziri2.Clear();
            SellUAtziri3.Clear();
            SellUAtziri4.Clear();
            SellPale1.Clear();
            SellPale2.Clear();
            SellPale3.Clear();
            SellPale4.Clear();
            SellHydra.Clear();
            SellPhoenix.Clear();
            SellMinotaur.Clear();
            SellChimera.Clear();
            SellElder1.Clear();
            SellElder2.Clear();
            SellElder3.Clear();
            SellElder4.Clear();
            SellUElder1.Clear();
            SellUElder2.Clear();
            SellUElder3.Clear();
            SellUElder4.Clear();
            SellXoph.Clear();
            SellTul.Clear();
            SellEsh.Clear();
            SellNetol.Clear();
            SellChayula.Clear();
            SellKarui.Clear();
            SellMaraketh.Clear();
            SellTemplar.Clear();
            SellVaalE.Clear();
            SellEternal.Clear();
            SellOffering.Clear();
            SellDVessel.Clear();
            SellSimulacrum.Clear();
            //Profit TextBoxes
            ProfitAtziri1.Clear();
            ProfitAtziri2.Clear();
            ProfitAtziri3.Clear();
            ProfitAtziri4.Clear();
            ProfitUAtziri1.Clear();
            ProfitUAtziri2.Clear();
            ProfitUAtziri3.Clear();
            ProfitUAtziri4.Clear();
            ProfitPale1.Clear();
            ProfitPale2.Clear();
            ProfitPale3.Clear();
            ProfitPale4.Clear();
            ProfitHydra.Clear();
            ProfitPhoenix.Clear();
            ProfitMinotaur.Clear();
            ProfitChimera.Clear();
            ProfitElder1.Clear();
            ProfitElder2.Clear();
            ProfitElder3.Clear();
            ProfitElder4.Clear();
            ProfitUElder1.Clear();
            ProfitUElder2.Clear();
            ProfitUElder3.Clear();
            ProfitUElder4.Clear();
            ProfitXoph.Clear();
            ProfitTul.Clear();
            ProfitEsh.Clear();
            ProfitNetol.Clear();
            ProfitChayula.Clear();
            ProfitKarui.Clear();
            ProfitMaraketh.Clear();
            ProfitTemplar.Clear();
            ProfitVaalE.Clear();
            ProfitEternal.Clear();
            ProfitOffering.Clear();
            ProfitDVessel.Clear();
            ProfitSimulacrum.Clear();
            //Quantbox
            QuantBoxFragment.Clear();
        }


        // Calc Button Currency

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            GetResultInTextBox1(BuyAlchemy, SellAlchemy, ProfitAlchemy);
            GetResultInTextBox1(BuyAlt, SellAlt, ProfitAlt);
            GetResultInTextBox1(BuyAncient, SellAncient, ProfitAncient);
            GetResultInTextBox1(BuyAnnulment, SellAnnulment, ProfitAnnulment);
            GetResultInTextBox1(BuyAugmentation, SellAugmentation, ProfitAugmentation);
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
            GetResultInTextBox1(BuyPerandus, SellPerandus, ProfitPerandus);
            GetResultInTextBox1(BuyPortal, SellPortal, ProfitPortal);
            GetResultInTextBox1(BuyRegal, SellRegal, ProfitRegal);
            GetResultInTextBox1(BuyRegret, SellRegret, ProfitRegret);
            GetResultInTextBox1(BuySimple_Sextant, SellSimple_Sextant, ProfitSimple_Sextant);
            GetResultInTextBox1(BuyScouring, SellScouring, ProfitScouring);
            GetResultInTextBox1(BuyScrap, SellScrap, ProfitScrap);
            GetResultInTextBox1(BuySilver, SellSilver, ProfitSilver);
            GetResultInTextBox1(BuyTransmute, SellTransmute, ProfitTransmute);
            GetResultInTextBox1(BuyVaal, SellVaal, ProfitVaal);
            GetResultInTextBox1(BuyWhetstone, SellWhetstone, ProfitWhetstone);
            GetResultInTextBox1(BuyWisdom, SellWisdom, ProfitWisdom);
            GetResultInTextBox1(BuyPrime_Sextant, SellPrime_Sextant, ProfitPrime_Sextant);
            GetResultInTextBox1(BuyAwakened_Sextant, SellAwakened_Sextant, ProfitAwakened_Sextant);
            GetResultInTextBox1(BuyMirror, SellMirror, ProfitMirror);
            GetResultInTextBox1(BuyHunter, SellHunter, ProfitHunter);
            GetResultInTextBox1(BuyWarlord, SellWarlord, ProfitWarlord);
            GetResultInTextBox1(BuyRedeemer, SellRedeemer, ProfitRedeemer);
            GetResultInTextBox1(BuyCrusader, SellCrusader, ProfitCrusader);
        }
        // Calc Button Fossil
        private void CalcButtonFossil_Click(object sender, RoutedEventArgs e)
        {
            GetResultInTextBox1(BuyAberrant, SellAberrant, ProfitAberrant);
            GetResultInTextBox1(BuyAetheric, SellAetheric, ProfitAetheric);
            GetResultInTextBox1(BuyBloodstained, SellBloodstained, ProfitBloodstained);
            GetResultInTextBox1(BuyBound, SellBound, ProfitBound);
            GetResultInTextBox1(BuyCorroded, SellCorroded, ProfitCorroded);
            GetResultInTextBox1(BuyDense, SellDense, ProfitDense);
            GetResultInTextBox1(BuyEnchanted, SellEnchanted, ProfitEnchanted);
            GetResultInTextBox1(BuyEncrusted, SellEncrusted, ProfitEncrusted);
            GetResultInTextBox1(BuyFaceted, SellFaceted, ProfitFaceted);
            GetResultInTextBox1(BuyFractured, SellFractured, ProfitFractured);
            GetResultInTextBox1(BuyFrigid, SellFrigid, ProfitFrigid);
            GetResultInTextBox1(BuyGilded, SellGilded, ProfitGilded);
            GetResultInTextBox1(BuyGlyphic, SellGlyphic, ProfitGlyphic);
            GetResultInTextBox1(BuyHollow, SellHollow, ProfitHollow);
            GetResultInTextBox1(BuyJagged, SellJagged, ProfitJagged);
            GetResultInTextBox1(BuyLucent, SellLucent, ProfitLucent);
            GetResultInTextBox1(BuyMetallic, SellMetallic, ProfitMetallic);
            GetResultInTextBox1(BuyPerfect, SellPerfect, ProfitPerfect);
            GetResultInTextBox1(BuyPrismatic, SellPrismatic, ProfitPrismatic);
            GetResultInTextBox1(BuyPristine, SellPristine, ProfitPristine);
            GetResultInTextBox1(BuySanctified, SellSanctified, ProfitSanctified);
            GetResultInTextBox1(BuyScorched, SellScorched, ProfitScorched);
            GetResultInTextBox1(BuySerrated, SellSerrated, ProfitSerrated);
            GetResultInTextBox1(BuyShuddering, SellShuddering, ProfitShuddering);
            GetResultInTextBox1(BuyTangled, SellTangled, ProfitTangled);
        }

        // Calc Button Oil
        private void CalcButtonOil_Click(object sender, RoutedEventArgs e)
        {
            GetResultInTextBox1(BuyClear, SellClear, ProfitClear);
            GetResultInTextBox1(BuySepia, SellSepia, ProfitSepia);
            GetResultInTextBox1(BuyAmber, SellAmber, ProfitAmber);
            GetResultInTextBox1(BuyVerdant, SellVerdant, ProfitVerdant);
            GetResultInTextBox1(BuyTeal, SellTeal, ProfitTeal);
            GetResultInTextBox1(BuyAzure, SellAzure, ProfitAzure);
            GetResultInTextBox1(BuyIndigo, SellIndigo, ProfitIndigo);
            GetResultInTextBox1(BuyViolet, SellViolet, ProfitViolet);
            GetResultInTextBox1(BuyCrimson, SellCrimson, ProfitCrimson);
            GetResultInTextBox1(BuyBlack, SellBlack, ProfitBlack);
            GetResultInTextBox1(BuyOpal, SellOpal, ProfitOpal);
            GetResultInTextBox1(BuySilverOil, SellSilverOil, ProfitSilverOil);
            GetResultInTextBox1(BuyGolden, SellGolden, ProfitGolden);
        }

        // Calc Button Cata
        private void CalcButtonCata_Click(object sender, RoutedEventArgs e)
        {
            GetResultInTextBox1(BuyAbrasive, SellAbrasive, ProfitAbrasive);
            GetResultInTextBox1(BuyFertile, SellFertile, ProfitFertile);
            GetResultInTextBox1(BuyImbued, SellImbued, ProfitImbued);
            GetResultInTextBox1(BuyIntrinsic, SellIntrinsic, ProfitIntrinsic);
            GetResultInTextBox1(BuyPrismaticCata, SellPrismaticCata, ProfitPrismaticCata);
            GetResultInTextBox1(BuyTempering, SellTempering, ProfitTempering);
            GetResultInTextBox1(BuyTurbulent, SellTurbulent, ProfitTurbulent);
        }

        // Calc Button Fragments

        private void CalcButtonFragment_Click(object sender, RoutedEventArgs e)
        {
            GetResultInTextBox1(BuyAtziri1, SellAtziri1, ProfitAtziri1);
            GetResultInTextBox1(BuyAtziri2, SellAtziri2, ProfitAtziri2);
            GetResultInTextBox1(BuyAtziri3, SellAtziri3, ProfitAtziri3);
            GetResultInTextBox1(BuyAtziri4, SellAtziri4, ProfitAtziri4);
            GetResultInTextBox1(BuyUAtziri1, SellUAtziri1, ProfitUAtziri1);
            GetResultInTextBox1(BuyUAtziri2, SellUAtziri2, ProfitUAtziri2);
            GetResultInTextBox1(BuyUAtziri3, SellUAtziri3, ProfitUAtziri3);
            GetResultInTextBox1(BuyUAtziri4, SellUAtziri4, ProfitUAtziri4);
            GetResultInTextBox1(BuyPale1, SellPale1, ProfitPale1);
            GetResultInTextBox1(BuyPale2, SellPale2, ProfitPale2);
            GetResultInTextBox1(BuyPale3, SellPale3, ProfitPale3);
            GetResultInTextBox1(BuyPale4, SellPale4, ProfitPale4);
            GetResultInTextBox1(BuyHydra, SellHydra, ProfitHydra);
            GetResultInTextBox1(BuyPhoenix, SellPhoenix, ProfitPhoenix);
            GetResultInTextBox1(BuyMinotaur, SellMinotaur, ProfitMinotaur);
            GetResultInTextBox1(BuyChimera, SellChimera, ProfitChimera);
            GetResultInTextBox1(BuyElder1, SellElder1, ProfitElder1);
            GetResultInTextBox1(BuyElder2, SellElder2, ProfitElder2);
            GetResultInTextBox1(BuyElder3, SellElder3, ProfitElder3);
            GetResultInTextBox1(BuyElder4, SellElder4, ProfitElder4);
            GetResultInTextBox1(BuyUElder1, SellUElder1, ProfitUElder1);
            GetResultInTextBox1(BuyUElder2, SellUElder2, ProfitUElder2);
            GetResultInTextBox1(BuyUElder3, SellUElder3, ProfitUElder3);
            GetResultInTextBox1(BuyUElder4, SellUElder4, ProfitUElder4);
            GetResultInTextBox1(BuyXoph, SellXoph, ProfitXoph);
            GetResultInTextBox1(BuyTul, SellTul, ProfitTul);
            GetResultInTextBox1(BuyNetol, SellNetol, ProfitNetol);
            GetResultInTextBox1(BuyChayula, SellChayula, ProfitChayula);
            GetResultInTextBox1(BuyKarui, SellKarui, ProfitKarui);
            GetResultInTextBox1(BuyMaraketh, SellMaraketh, ProfitMaraketh);
            GetResultInTextBox1(BuyTemplar, SellTemplar, ProfitTemplar);
            GetResultInTextBox1(BuyVaalE, SellVaalE, ProfitVaalE);
            GetResultInTextBox1(BuyEternal, SellEternal, ProfitEternal);
            GetResultInTextBox1(BuyOffering, SellOffering, ProfitOffering);
            GetResultInTextBox1(BuyDVessel, SellDVessel, ProfitDVessel);
            GetResultInTextBox1(BuySimulacrum, SellSimulacrum, ProfitSimulacrum);
        }


        // Math for Profit Box
        public void GetResultInTextBox1(TextBox first, TextBox second, TextBox result)
        {
            var culture = new CultureInfo("en-US");
            var r1 = float.TryParse(first.Text, NumberStyles.Currency, culture, out float a);
            var r2 = float.TryParse(second.Text, NumberStyles.Currency, culture, out float b);

            if (r1 && r2)
            {
                result.Text = Math.Round(100 - ((a / b) * 100), 3).ToString(culture) + "%"; // (100 - (buy/sell) * 100),3) , into a string with 3 decimals and a % behind it 
            }
            else
            {
                result.Text = "";
            }
        }
        // Links Button
        private void LinksButton_Click(object sender, RoutedEventArgs e)
        {
            Links subWindow = new Links();
            subWindow.Show();
        }
        // Quant Button Currency
        private void QuantButton_Click(object sender, RoutedEventArgs e)
        {
            QuantCurrency subWindow = new QuantCurrency();
            subWindow.Show();

            GetResultInTextBox2(BuyAlt, SellAlt, QuantBox, subWindow.QuantBuyAlt, subWindow.QuantSellAlt);
            GetResultInTextBox2(BuyAlchemy, SellAlchemy, QuantBox, subWindow.QuantBuyAlch, subWindow.QuantSellAlch);
            GetResultInTextBox2(BuyAncient, SellAncient, QuantBox, subWindow.QuantBuyAncient, subWindow.QuantSellAncient);
            GetResultInTextBox2(BuyAnnulment, SellAnnulment, QuantBox, subWindow.QuantBuyAnnulment, subWindow.QuantSellAnnulment);
            GetResultInTextBox2(BuyAugmentation, SellAugmentation, QuantBox, subWindow.QuantBuyAugmentation, subWindow.QuantSellAugmentation);
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
            GetResultInTextBox2(BuyPerandus, SellPerandus, QuantBox, subWindow.QuantBuyPerandus, subWindow.QuantSellPerandus);
            GetResultInTextBox2(BuyPortal, SellPortal, QuantBox, subWindow.QuantBuyPortal, subWindow.QuantSellPortal);
            GetResultInTextBox2(BuyRegal, SellRegal, QuantBox, subWindow.QuantBuyRegal, subWindow.QuantSellRegal);
            GetResultInTextBox2(BuyRegret, SellRegret, QuantBox, subWindow.QuantBuyRegret, subWindow.QuantSellRegret);
            GetResultInTextBox2(BuyPrime_Sextant, SellPrime_Sextant, QuantBox, subWindow.QuantBuyPrime_Sextant, subWindow.QuantSellPrime_Sextant);
            GetResultInTextBox2(BuyScouring, SellScouring, QuantBox, subWindow.QuantBuyScouring, subWindow.QuantSellScouring);
            GetResultInTextBox2(BuyScrap, SellScrap, QuantBox, subWindow.QuantBuyScrap, subWindow.QuantSellScrap);
            GetResultInTextBox2(BuySilver, SellSilver, QuantBox, subWindow.QuantBuySilver, subWindow.QuantSellSilver);
            GetResultInTextBox2(BuyTransmute, SellTransmute, QuantBox, subWindow.QuantBuyTransmute, subWindow.QuantSellTransmute);
            GetResultInTextBox2(BuyVaal, SellVaal, QuantBox, subWindow.QuantBuyVaal, subWindow.QuantSellVaal);
            GetResultInTextBox2(BuyWhetstone, SellWhetstone, QuantBox, subWindow.QuantBuyWhetstone, subWindow.QuantSellWhetstone);
            GetResultInTextBox2(BuyWisdom, SellWisdom, QuantBox, subWindow.QuantBuyWisdom, subWindow.QuantSellWisdom);
            GetResultInTextBox2(BuySimple_Sextant, SellSimple_Sextant, QuantBox, subWindow.QuantBuySimple_Sextant, subWindow.QuantSellSimple_Sextant);
            GetResultInTextBox2(BuyAwakened_Sextant, SellAwakened_Sextant, QuantBox, subWindow.QuantBuyAwakened_Sextant, subWindow.QuantSellAwakened_Sextant);
            GetResultInTextBox2(BuyMirror, SellMirror, QuantBox, subWindow.QuantBuyMirror, subWindow.QuantSellMirror);
            GetResultInTextBox2(BuyHunter, SellHunter, QuantBox, subWindow.QuantBuyHunter, subWindow.QuantSellHunter);
            GetResultInTextBox2(BuyWarlord, SellWarlord, QuantBox, subWindow.QuantBuyWarlord, subWindow.QuantSellWarlord);
            GetResultInTextBox2(BuyRedeemer, SellRedeemer, QuantBox, subWindow.QuantBuyRedeemer, subWindow.QuantSellRedeemer);
            GetResultInTextBox2(BuyCrusader, SellCrusader, QuantBox, subWindow.QuantBuyCrusader, subWindow.QuantSellCrusader);
        }

        // Quant Button Fossil
        private void QuantButtonFossil_Click(object sender, RoutedEventArgs e)
        {
            QuantFossil subWindow = new QuantFossil();
            subWindow.Show();

            GetResultInTextBox3(BuyAberrant, SellAberrant, QuantBoxFossil, subWindow.QuantBuyAberrant, subWindow.QuantSellAberrant);
            GetResultInTextBox3(BuyAetheric, SellAetheric, QuantBoxFossil, subWindow.QuantBuyAetheric, subWindow.QuantSellAetheric);
            GetResultInTextBox3(BuyBloodstained, SellBloodstained, QuantBoxFossil, subWindow.QuantBuyBloodstained, subWindow.QuantSellBloodstained);
            GetResultInTextBox3(BuyBound, SellBound, QuantBoxFossil, subWindow.QuantBuyBound, subWindow.QuantSellBound);
            GetResultInTextBox3(BuyCorroded, SellCorroded, QuantBoxFossil, subWindow.QuantBuyCorroded, subWindow.QuantSellCorroded);
            GetResultInTextBox3(BuyDense, SellDense, QuantBoxFossil, subWindow.QuantBuyDense, subWindow.QuantSellDense);
            GetResultInTextBox3(BuyEnchanted, SellEnchanted, QuantBoxFossil, subWindow.QuantBuyEnchanted, subWindow.QuantSellEnchanted);
            GetResultInTextBox3(BuyEncrusted, SellEncrusted, QuantBoxFossil, subWindow.QuantBuyEncrusted, subWindow.QuantSellEncrusted);
            GetResultInTextBox3(BuyFaceted, SellFaceted, QuantBoxFossil, subWindow.QuantBuyFaceted, subWindow.QuantSellFaceted);
            GetResultInTextBox3(BuyFractured, SellFractured, QuantBoxFossil, subWindow.QuantBuyFractured, subWindow.QuantSellFractured);
            GetResultInTextBox3(BuyFrigid, SellFrigid, QuantBoxFossil, subWindow.QuantBuyFrigid, subWindow.QuantSellFrigid);
            GetResultInTextBox3(BuyGilded, SellGilded, QuantBoxFossil, subWindow.QuantBuyGilded, subWindow.QuantSellGilded);
            GetResultInTextBox3(BuyGlyphic, SellGlyphic, QuantBoxFossil, subWindow.QuantBuyGlyphic, subWindow.QuantSellGlyphic);
            GetResultInTextBox3(BuyHollow, SellHollow, QuantBoxFossil, subWindow.QuantBuyHollow, subWindow.QuantSellHollow);
            GetResultInTextBox3(BuyJagged, SellJagged, QuantBoxFossil, subWindow.QuantBuyJagged, subWindow.QuantSellJagged);
            GetResultInTextBox3(BuyLucent, SellLucent, QuantBoxFossil, subWindow.QuantBuyLucent, subWindow.QuantSellLucent);
            GetResultInTextBox3(BuyMetallic, SellMetallic, QuantBoxFossil, subWindow.QuantBuyMetallic, subWindow.QuantSellMetallic);
            GetResultInTextBox3(BuyPerfect, SellPerfect, QuantBoxFossil, subWindow.QuantBuyPerfect, subWindow.QuantSellPerfect);
            GetResultInTextBox3(BuyPrismatic, SellPrismatic, QuantBoxFossil, subWindow.QuantBuyPrismatic, subWindow.QuantSellPrismatic);
            GetResultInTextBox3(BuyPristine, SellPristine, QuantBoxFossil, subWindow.QuantBuyPristine, subWindow.QuantSellPristine);
            GetResultInTextBox3(BuySanctified, SellSanctified, QuantBoxFossil, subWindow.QuantBuySanctified, subWindow.QuantSellSanctified);
            GetResultInTextBox3(BuyScorched, SellScorched, QuantBoxFossil, subWindow.QuantBuyScorched, subWindow.QuantSellScorched);
            GetResultInTextBox3(BuySerrated, SellSerrated, QuantBoxFossil, subWindow.QuantBuySerrated, subWindow.QuantSellSerrated);
            GetResultInTextBox3(BuyShuddering, SellShuddering, QuantBoxFossil, subWindow.QuantBuyShuddering, subWindow.QuantSellShuddering);
            GetResultInTextBox3(BuyTangled, SellTangled, QuantBoxFossil, subWindow.QuantBuyTangled, subWindow.QuantSellTangled);

        }
        // Quant Button Oil
        private void QuantButtonOil_Click(object sender, RoutedEventArgs e)
        {
            QuantOil subWindow = new QuantOil();
            subWindow.Show();

            GetResultInTextBox4(BuyClear, SellClear, QuantBoxOil, subWindow.QuantBuyClear, subWindow.QuantSellClear);
            GetResultInTextBox4(BuySepia, SellSepia, QuantBoxOil, subWindow.QuantBuySepia, subWindow.QuantSellSepia);
            GetResultInTextBox4(BuyAmber, SellAmber, QuantBoxOil, subWindow.QuantBuyAmber, subWindow.QuantSellAmber);
            GetResultInTextBox4(BuyVerdant, SellVerdant, QuantBoxOil, subWindow.QuantBuyVerdant, subWindow.QuantSellVerdant);
            GetResultInTextBox4(BuyTeal, SellTeal, QuantBoxOil, subWindow.QuantBuyTeal, subWindow.QuantSellTeal);
            GetResultInTextBox4(BuyAzure, SellAzure, QuantBoxOil, subWindow.QuantBuyAzure, subWindow.QuantSellAzure);
            GetResultInTextBox4(BuyIndigo, SellIndigo, QuantBoxOil, subWindow.QuantBuyIndigo, subWindow.QuantSellIndigo);
            GetResultInTextBox4(BuyViolet, SellViolet, QuantBoxOil, subWindow.QuantBuyViolet, subWindow.QuantSellViolet);
            GetResultInTextBox4(BuyCrimson, SellCrimson, QuantBoxOil, subWindow.QuantBuyCrimson, subWindow.QuantSellCrimson);
            GetResultInTextBox4(BuyBlack, SellBlack, QuantBoxOil, subWindow.QuantBuyBlack, subWindow.QuantSellBlack);
            GetResultInTextBox4(BuyOpal, SellOpal, QuantBoxOil, subWindow.QuantBuyOpal, subWindow.QuantSellOpal);
            GetResultInTextBox4(BuySilverOil, SellSilverOil, QuantBoxOil, subWindow.QuantBuySilverOil, subWindow.QuantSellSilverOil);
            GetResultInTextBox4(BuyGolden, SellGolden, QuantBoxOil, subWindow.QuantBuyGolden, subWindow.QuantSellGolden);
        }

        // Quant Button Cata
        private void QuantButtonCata_Click(object sender, RoutedEventArgs e)
        {
            QuantCatalyst subWindow = new QuantCatalyst();
            subWindow.Show();

            GetResultInTextBox5(BuyAbrasive, SellAbrasive, QuantBoxCata, subWindow.QuantBuyAbrasive, subWindow.QuantSellAbrasive);
            GetResultInTextBox5(BuyFertile, SellFertile, QuantBoxCata, subWindow.QuantBuyFertile, subWindow.QuantSellFertile);
            GetResultInTextBox5(BuyImbued, SellImbued, QuantBoxCata, subWindow.QuantBuyImbued, subWindow.QuantSellImbued);
            GetResultInTextBox5(BuyIntrinsic, SellIntrinsic, QuantBoxCata, subWindow.QuantBuyIntrinsic, subWindow.QuantSellIntrinsic);
            GetResultInTextBox5(BuyPrismaticCata, SellPrismaticCata, QuantBoxCata, subWindow.QuantBuyPrismaticCata, subWindow.QuantSellPrismaticCata);
            GetResultInTextBox5(BuyTempering, SellTempering, QuantBoxCata, subWindow.QuantBuyTempering, subWindow.QuantSellTempering);
            GetResultInTextBox5(BuyTurbulent, SellTurbulent, QuantBoxCata, subWindow.QuantBuyTurbulent, subWindow.QuantSellTurbulent);
        }

        // Quant Button Fragments
        private void QuantButtonFragment_Click(object sender, RoutedEventArgs e)
        {
            QuantFragment subWindow = new QuantFragment();
            subWindow.Show();

            GetResultInTextBox6(BuyAtziri1, SellAtziri1, QuantBoxFragment, subWindow.QuantBuyAtziri1, subWindow.QuantSellAtziri1);
            GetResultInTextBox6(BuyAtziri2, SellAtziri2, QuantBoxFragment, subWindow.QuantBuyAtziri2, subWindow.QuantSellAtziri2);
            GetResultInTextBox6(BuyAtziri3, SellAtziri3, QuantBoxFragment, subWindow.QuantBuyAtziri3, subWindow.QuantSellAtziri3);
            GetResultInTextBox6(BuyAtziri4, SellAtziri4, QuantBoxFragment, subWindow.QuantBuyAtziri4, subWindow.QuantSellAtziri4);
            GetResultInTextBox6(BuyUAtziri1, SellUAtziri1, QuantBoxFragment, subWindow.QuantBuyUAtziri1, subWindow.QuantSellUAtziri1);
            GetResultInTextBox6(BuyUAtziri2, SellUAtziri2, QuantBoxFragment, subWindow.QuantBuyUAtziri2, subWindow.QuantSellUAtziri2);
            GetResultInTextBox6(BuyUAtziri3, SellUAtziri3, QuantBoxFragment, subWindow.QuantBuyUAtziri3, subWindow.QuantSellUAtziri3);
            GetResultInTextBox6(BuyUAtziri4, SellUAtziri4, QuantBoxFragment, subWindow.QuantBuyUAtziri4, subWindow.QuantSellUAtziri4);
            GetResultInTextBox6(BuyPale1, SellPale1, QuantBoxFragment, subWindow.QuantBuyPale1, subWindow.QuantSellPale1);
            GetResultInTextBox6(BuyPale2, SellPale2, QuantBoxFragment, subWindow.QuantBuyPale2, subWindow.QuantSellPale2);
            GetResultInTextBox6(BuyPale3, SellPale3, QuantBoxFragment, subWindow.QuantBuyPale3, subWindow.QuantSellPale3);
            GetResultInTextBox6(BuyPale4, SellPale4, QuantBoxFragment, subWindow.QuantBuyPale4, subWindow.QuantSellPale4);
            GetResultInTextBox6(BuyHydra, SellHydra, QuantBoxFragment, subWindow.QuantBuyHydra, subWindow.QuantSellHydra);
            GetResultInTextBox6(BuyPhoenix, SellPhoenix, QuantBoxFragment, subWindow.QuantBuyPhoenix, subWindow.QuantSellPhoenix);
            GetResultInTextBox6(BuyMinotaur, SellMinotaur, QuantBoxFragment, subWindow.QuantBuyMinotaur, subWindow.QuantSellMinotaur);
            GetResultInTextBox6(BuyChimera, SellChimera, QuantBoxFragment, subWindow.QuantBuyChimera, subWindow.QuantSellChimera);
            GetResultInTextBox6(BuyElder1, SellElder1, QuantBoxFragment, subWindow.QuantBuyElder1, subWindow.QuantSellElder1);
            GetResultInTextBox6(BuyElder2, SellElder2, QuantBoxFragment, subWindow.QuantBuyElder2, subWindow.QuantSellElder2);
            GetResultInTextBox6(BuyElder3, SellElder3, QuantBoxFragment, subWindow.QuantBuyElder3, subWindow.QuantSellElder3);
            GetResultInTextBox6(BuyElder4, SellElder4, QuantBoxFragment, subWindow.QuantBuyElder4, subWindow.QuantSellElder4);
            GetResultInTextBox6(BuyUElder1, SellUElder1, QuantBoxFragment, subWindow.QuantBuyUElder1, subWindow.QuantSellUElder1);
            GetResultInTextBox6(BuyUElder2, SellUElder2, QuantBoxFragment, subWindow.QuantBuyUElder2, subWindow.QuantSellUElder2);
            GetResultInTextBox6(BuyUElder3, SellUElder3, QuantBoxFragment, subWindow.QuantBuyUElder3, subWindow.QuantSellUElder3);
            GetResultInTextBox6(BuyUElder4, SellUElder4, QuantBoxFragment, subWindow.QuantBuyUElder4, subWindow.QuantSellUElder4);
            GetResultInTextBox6(BuyXoph, SellXoph, QuantBoxFragment, subWindow.QuantBuyXoph, subWindow.QuantSellXoph);
            GetResultInTextBox6(BuyTul, SellTul, QuantBoxFragment, subWindow.QuantBuyTul, subWindow.QuantSellTul);
            GetResultInTextBox6(BuyEsh, SellEsh, QuantBoxFragment, subWindow.QuantBuyEsh, subWindow.QuantSellEsh);
            GetResultInTextBox6(BuyNetol, SellNetol, QuantBoxFragment, subWindow.QuantBuyNetol, subWindow.QuantSellNetol);
            GetResultInTextBox6(BuyChayula, SellChayula, QuantBoxFragment, subWindow.QuantBuyChayula, subWindow.QuantSellChayula);
            GetResultInTextBox6(BuyKarui, SellKarui, QuantBoxFragment, subWindow.QuantBuyKarui, subWindow.QuantSellKarui);
            GetResultInTextBox6(BuyMaraketh, SellMaraketh, QuantBoxFragment, subWindow.QuantBuyMaraketh, subWindow.QuantSellMaraketh);
            GetResultInTextBox6(BuyTemplar, SellTemplar, QuantBoxFragment, subWindow.QuantBuyTemplar, subWindow.QuantSellTemplar);
            GetResultInTextBox6(BuyVaalE, SellVaalE, QuantBoxFragment, subWindow.QuantBuyVaalE, subWindow.QuantSellVaalE);
            GetResultInTextBox6(BuyEternal, SellEternal, QuantBoxFragment, subWindow.QuantBuyEternal, subWindow.QuantSellEternal);
            GetResultInTextBox6(BuyOffering, SellOffering, QuantBoxFragment, subWindow.QuantBuyOffering, subWindow.QuantSellOffering);
            GetResultInTextBox6(BuyDVessel, SellDVessel, QuantBoxFragment, subWindow.QuantBuyDVessel, subWindow.QuantSellDVessel);
            GetResultInTextBox6(BuySimulacrum, SellSimulacrum, QuantBoxFragment, subWindow.QuantBuySimulacrum, subWindow.QuantSellSimulacrum);
        }

        // Quant Math Currency

        public void GetResultInTextBox2(TextBox first, TextBox second, TextBox third, TextBox fourth, TextBox fifth)
        {
            var culture = new CultureInfo("en-US");
            var r1 = float.TryParse(first.Text, NumberStyles.Currency, culture, out float a);
            var r2 = float.TryParse(second.Text, NumberStyles.Currency, culture, out float b);
            var r3 = float.TryParse(third.Text, out float c);

            if (r1 && r2 && r3)
            {
                fourth.Text = Math.Round((c / a), 3).ToString(culture); // quant x buy/sell = quant x C 
                fifth.Text = Math.Round((c / b), 3).ToString(culture);
            }
            else
            {
                fourth.Text = "";
                fifth.Text = "";
            }
        }

        // Quant Math Fossils

        public void GetResultInTextBox3(TextBox first, TextBox second, TextBox third, TextBox fourth, TextBox fifth)
        {
            var culture = new CultureInfo("en-US");
            var r1 = float.TryParse(first.Text, NumberStyles.Currency, culture, out float a);
            var r2 = float.TryParse(second.Text, NumberStyles.Currency, culture, out float b);
            var r3 = float.TryParse(third.Text, out float c);

            if (r1 && r2 && r3)
            {
                fourth.Text = Math.Round((c / a), 3).ToString(culture); // quant x buy/sell = quant x C 
                fifth.Text = Math.Round((c / b), 3).ToString(culture);
            }
            else
            {
                fourth.Text = "";
                fifth.Text = "";
            }
        }

        // Quant Math Oils 

        public void GetResultInTextBox4(TextBox first, TextBox second, TextBox third, TextBox fourth, TextBox fifth)
        {
            var culture = new CultureInfo("en-US");
            var r1 = float.TryParse(first.Text, NumberStyles.Currency, culture, out float a);
            var r2 = float.TryParse(second.Text, NumberStyles.Currency, culture, out float b);
            var r3 = float.TryParse(third.Text, out float c);

            if (r1 && r2 && r3)
            {
                fourth.Text = Math.Round((c / a), 3).ToString(culture); // quant x buy/sell = quant x C 
                fifth.Text = Math.Round((c / b), 3).ToString(culture);
            }
            else
            {
                fourth.Text = "";
                fifth.Text = "";
            }
        }

        // Quant Math Catalysts

        public void GetResultInTextBox5(TextBox first, TextBox second, TextBox third, TextBox fourth, TextBox fifth)
        {
            var culture = new CultureInfo("en-US");
            var r1 = float.TryParse(first.Text, NumberStyles.Currency, culture, out float a);
            var r2 = float.TryParse(second.Text, NumberStyles.Currency, culture, out float b);
            var r3 = float.TryParse(third.Text, out float c);
            
            if (r1 && r2 && r3)
            {
                fourth.Text = Math.Round((c / a), 3).ToString(culture); // quant x buy/sell = quant x C 
                fifth.Text = Math.Round((c / b), 3).ToString(culture);
            }
            else
            {
                fourth.Text = "";
                fifth.Text = "";
            }
        }

        // Quant Math Fragment

        public void GetResultInTextBox6(TextBox first, TextBox second, TextBox third, TextBox fourth, TextBox fifth)
        {
            var culture = new CultureInfo("en-US");
            var r1 = float.TryParse(first.Text, NumberStyles.Currency, culture, out float a);
            var r2 = float.TryParse(second.Text, NumberStyles.Currency, culture, out float b);
            var r3 = float.TryParse(third.Text, out float c);

            if (r1 && r2 && r3)
            {
                fourth.Text = Math.Round((c / a), 3).ToString(culture); // quant x buy/sell = quant x C 
                fifth.Text = Math.Round((c / b), 3).ToString(culture);
            }
            else
            {
                fourth.Text = "";
                fifth.Text = "";
            }
        }
    }
}

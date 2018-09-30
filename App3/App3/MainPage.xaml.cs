using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CalcolatriceLibrary;
namespace App3
{
    public partial class MainPage : ContentPage
    {
       bool sceltoOperatore=false;
        string operatore;
       string calcolo;
        bool sceltoNumero = false;
        int num1, num2;
        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }
        void OnSelectOperator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            sceltoNumero = true;
            if (!sceltoOperatore && sceltoNumero)
            { operatore = button.Text; calcolo += operatore; }
            sceltoOperatore = true;
            this.resultText.Text = calcolo;
        }
        void OnSelectButton(object sender, EventArgs e)
        {
            if (this.resultText.Text == "0")
            {
                this.resultText.Text = "";
            }
            Button button = (Button)sender; //Invia il bottone premuto
            if (!sceltoNumero)
            {
                num1 = Convert.ToInt32(button.Text);
                
            }
            else
            {
                num2 = Convert.ToInt32(button.Text);
                
            }

            calcolo = button.Text;
            this.resultText.Text = calcolo; //Stampa su schermo
            
        }
        void OnCalcola(object sender, EventArgs e)
        {
            //split + calcola();
            if (sceltoOperatore)
            {

                Calculator calc = new Calculator();
                calc.Num1 = num1;
                calc.Num2 = num2;
                if (operatore.Contains("+")) 
                {
                    calc.Addizione();
                }
                if (operatore.Contains("-"))
                {
                    calc.Sottrazione();
                }
                if (operatore.Contains("*"))
                {
                    calc.Moltiplicazione();
                }
                if (operatore.Contains("/"))
                {
                    calc.Divisione();
                }
                this.resultText.Text = calc.Ris.ToString();
                calcolo = calc.Ris.ToString();
            }
            sceltoOperatore = false;
            num1 = Convert.ToInt32(calcolo);
            sceltoNumero = false;
        }
       
        void OnClear(object sender, EventArgs e)
        {
            this.resultText.Text = "0";
            sceltoNumero = false;
            sceltoOperatore = false;
        }

        public bool Operatore(Button bottone)
        {
            var result = OperatorHelper.Calculate(bottone.Text);
            return result;
        }
    }
}

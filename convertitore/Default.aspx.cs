using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace convertitore
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void FromList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToList.Items.FindByValue("Celsius").Attributes.Add("style", "display: normal");
            ToList.Items.FindByValue("Kelvin").Attributes.Add("style", "display: normal");
            ToList.Items.FindByValue("Fahrenheit").Attributes.Add("style", "display: normal");
            
            switch (FromList.SelectedValue)
            {
                case "Celsius":
                    ToList.Items.FindByValue("Celsius").Attributes.Add("style", "display: none");
                    break;
                case "Kelvin":
                    ToList.Items.FindByValue("Kelvin").Attributes.Add("style", "display: none");
                    break;
                case "Fahrenheit":
                    ToList.Items.FindByValue("Fahrenheit").Attributes.Add("style", "display: none");
                    break;
            }
            
        }
           
        protected void ToList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FromList.Items.FindByValue("Celsius").Attributes.Add("style", "display: normal");
            FromList.Items.FindByValue("Kelvin").Attributes.Add("style", "display: normal");
            FromList.Items.FindByValue("Fahrenheit").Attributes.Add("style", "display: normal");

            switch (ToList.SelectedValue)
            {
                case "Celsius":
                    FromList.Items.FindByValue("Celsius").Attributes.Add("style", "display: none");
                    break;
                case "Kelvin":
                    FromList.Items.FindByValue("Kelvin").Attributes.Add("style", "display: none");
                    break;
                case "Fahrenheit":
                    FromList.Items.FindByValue("Fahrenheit").Attributes.Add("style", "display: none");
                    break;
            }
           
        }

        protected void angleButton_Click(object sender, EventArgs e)
        {
            try
            {
                string from = AngleFrom.Text;
                double fromAsDouble = Convert.ToDouble(from);

                if (FromList.SelectedValue == "Celsius" && ToList.SelectedValue == "Fahrenheit")
                {
                    AngleTo.Text = ((fromAsDouble * 9 / 5) + 32).ToString() + " °F";
                }
                else if (FromList.SelectedValue == "Celsius" && ToList.SelectedValue == "Kelvin")
                {
                    AngleTo.Text = (fromAsDouble + 271.15) + " K";
                }
                else if (FromList.SelectedValue == "Fahrenheit" && ToList.SelectedValue == "Celsius")
                {
                    AngleTo.Text = ((fromAsDouble - 32) * 5 / 9).ToString() + " °C";
                }
                else if (FromList.SelectedValue == "Fahrenheit" && ToList.SelectedValue == "Kelvin")
                {
                    AngleTo.Text = ((fromAsDouble + 459.67) * 5 / 9).ToString() + " K";
                }
                else if (FromList.SelectedValue == "Kelvin" && ToList.SelectedValue == "Celsius")
                {
                    AngleTo.Text = (fromAsDouble - 271.15) + " °C";
                }
                else if (FromList.SelectedValue == "Kelvin" && ToList.SelectedValue == "Fahrenheit")
                {
                    AngleTo.Text = (fromAsDouble * 9 / 5) - 459.67 + " °F";
                }

            }
            catch (FormatException)
            {
                AngleReponse.Text = "Error! Please Enter a Valid Value! E.g. 5, 5.55";
            }
        }

        protected void angleReset_Click(object sender, EventArgs e)
        {
            AngleTo.Text = "";
            AngleFrom.Text = "";
            AngleReponse.Text = "";
            FromList.SelectedIndex = 0;
            ToList.SelectedIndex = 0;
        }

        protected void FromListLenght_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToListLenght.Items.FindByValue("Meters").Attributes.Add("style", "display: normal");
            ToListLenght.Items.FindByValue("Miles").Attributes.Add("style", "display: normal");
            ToListLenght.Items.FindByValue("Yards").Attributes.Add("style", "display: normal");
            ToListLenght.Items.FindByValue("Feet").Attributes.Add("style", "display: normal");

            if (FromListLenght.SelectedValue == "Meters")
            {
                ToListLenght.Items.FindByValue("Meters").Attributes.Add("style", "display: none");
            }
            if (FromListLenght.SelectedValue == "Miles")
            {
                ToListLenght.Items.FindByValue("Miles").Attributes.Add("style", "display: none");
            }
            if (FromListLenght.SelectedValue == "Yards")
            {
                ToListLenght.Items.FindByValue("Yards").Attributes.Add("style", "display: none");
            }
            if (FromListLenght.SelectedValue == "Feet")
            {
                ToListLenght.Items.FindByValue("Feet").Attributes.Add("style", "display: none");
            }
        }

        protected void btnLenghtCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string from = LenghtFrom.Text;
                double fromAsDouble = Convert.ToDouble(from);

                if (FromListLenght.SelectedValue == "Meters" && ToListLenght.SelectedValue == "Miles")
                {
                    LenghtTo.Text = (fromAsDouble * 0.00062137).ToString() + " mi";
                }
                else if (FromListLenght.SelectedValue == "Meters" && ToListLenght.SelectedValue == "Yards")
                {
                    LenghtTo.Text = (fromAsDouble * 1.0936).ToString() + " y";
                }
                else if (FromListLenght.SelectedValue == "Meters" && ToListLenght.SelectedValue == "Feet")
                {
                    LenghtTo.Text = (fromAsDouble / 0.3048).ToString() + " ft";
                }
                else if (FromListLenght.SelectedValue == "Miles" && ToListLenght.SelectedValue == "Meters")
                {
                    LenghtTo.Text = (fromAsDouble / 0.00062137).ToString() + " m";
                }
                else if (FromListLenght.SelectedValue == "Miles" && ToListLenght.SelectedValue == "Yards")
                {
                    LenghtTo.Text = (fromAsDouble * 1760.0).ToString() + " y";
                }
                else if (FromListLenght.SelectedValue == "Miles" && ToListLenght.SelectedValue == "Feet")
                {
                    LenghtTo.Text = (fromAsDouble * 5280).ToString() + " ft";
                }
                else if (FromListLenght.SelectedValue == "Yards" && ToListLenght.SelectedValue == "Meters")
                {
                    LenghtTo.Text = (fromAsDouble / 1.0936).ToString() + " m";
                }
                else if (FromListLenght.SelectedValue == "Yards" && ToListLenght.SelectedValue == "Miles")
                {
                    LenghtTo.Text = (fromAsDouble / 1760.0).ToString() + " mi";
                }
                else if (FromListLenght.SelectedValue == "Yards" && ToListLenght.SelectedValue == "Feet")
                {
                    LenghtTo.Text = (fromAsDouble * 3.0000).ToString() + " ft";
                }
                else if (FromListLenght.SelectedValue == "Feet" && ToListLenght.SelectedValue == "Meters")
                {
                    LenghtTo.Text = (fromAsDouble * 0.3048).ToString() + " m";
                }
                else if (FromListLenght.SelectedValue == "Feet" && ToListLenght.SelectedValue == "Miles")
                {
                    LenghtTo.Text = (fromAsDouble / 5280).ToString() + " mi";
                }
                else if (FromListLenght.SelectedValue == "Feet" && ToListLenght.SelectedValue == "Yards")
                {
                    LenghtTo.Text = (fromAsDouble / 3.0000).ToString() + " y";
                }

            }
            catch (FormatException)
            {
                LenghtResoponse.Text = "Error! Please Enter a Valid Value! E.g. 5, 5.55";
            }
        }

        protected void btnLenghtReset_Click(object sender, EventArgs e)
        {
            LenghtTo.Text = "";
            LenghtFrom.Text = "";
            LenghtResoponse.Text = "";
            FromListLenght.SelectedIndex = 0;
            ToListLenght.SelectedIndex = 0;
        }

        protected void ButtonMassCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string from = MassFrom.Text;
                double fromAsDouble = Convert.ToDouble(from);

                if (MassFromList.SelectedValue == "kilogram" && MassToList.SelectedValue == "Pound")
                {
                    MassTo.Text = (fromAsDouble / 0.45359237).ToString() + " lbs";
                }
                else if (MassFromList.SelectedValue == "kilogram" && MassToList.SelectedValue == "Ounce")
                {
                    MassTo.Text = (fromAsDouble / 0.028349523125).ToString() + " oz";
                }
                else if (MassFromList.SelectedValue == "Pound" && MassToList.SelectedValue == "kilogram")
                {
                    MassTo.Text = (fromAsDouble * 0.45359237).ToString() + " kg";
                }
                else if (MassFromList.SelectedValue == "Pound" && MassToList.SelectedValue == "Ounce")
                {
                    MassTo.Text = (fromAsDouble *16).ToString() + " oz";
                }
                else if (MassFromList.SelectedValue == "Ounce" && MassToList.SelectedValue == "kilogram")
                {
                    MassTo.Text = (fromAsDouble * 0.028349523125).ToString() + " kg";
                }
                else if (MassFromList.SelectedValue == "Ounce" && MassToList.SelectedValue == "Pound")
                {
                    MassTo.Text = (fromAsDouble / 16).ToString() + " lbs";
                }
                              

            }
            catch (FormatException)
            {
                MassResponse.Text = "Error! Please Enter a Valid Value! E.g. 5, 5.55";
            }
        }

        protected void ButtonMassReset_Click(object sender, EventArgs e)
        {
            MassTo.Text = "";
            MassFrom.Text = "";
            MassResponse.Text = "";
            MassFromList.SelectedIndex = 0;
            MassToList.SelectedIndex = 0;
        }

        protected void MassFromList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MassToList.Items.FindByValue("kilogram").Attributes.Add("style", "display: normal");
            MassToList.Items.FindByValue("Pound").Attributes.Add("style", "display: normal");
            MassToList.Items.FindByValue("Ounce").Attributes.Add("style", "display: normal");

            if (MassFromList.SelectedValue == "kilogram")
            {
                MassToList.Items.FindByValue("kilogram").Attributes.Add("style", "display: none");
            }
            if (MassFromList.SelectedValue == "Pound")
            {
                MassToList.Items.FindByValue("Pound").Attributes.Add("style", "display: none");
            }
            if (MassFromList.SelectedValue == "Ounce")
            {
                MassToList.Items.FindByValue("Ounce").Attributes.Add("style", "display: none");
            }
        }

        protected void DropDownListFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownListTo.Items.FindByValue("Seconds").Attributes.Add("style", "display: normal");
            DropDownListTo.Items.FindByValue("Minutes").Attributes.Add("style", "display: normal");
            DropDownListTo.Items.FindByValue("Hours").Attributes.Add("style", "display: normal");

            if (DropDownListFrom.SelectedValue == "Seconds")
            {
                DropDownListTo.Items.FindByValue("Seconds").Attributes.Add("style", "display: none");
            }
            if (DropDownListFrom.SelectedValue == "Minutes")
            {
                DropDownListTo.Items.FindByValue("Minutes").Attributes.Add("style", "display: none");
            }
            if (DropDownListFrom.SelectedValue == "Hours")
            {
                DropDownListTo.Items.FindByValue("Hours").Attributes.Add("style", "display: none");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            TimeTo.Text = "";
            TimeFrom.Text = "";
            TimeResponse.Text = "";
            DropDownListFrom.SelectedIndex = 0;
            DropDownListTo.SelectedIndex = 0;
        }

        protected void brnCalculate_Click(object sender, EventArgs e)
        {
             try
            {
                string from = TimeFrom.Text;
                double fromAsDouble = Convert.ToDouble(from);

                if (DropDownListFrom.SelectedValue == "Seconds" && DropDownListTo.SelectedValue == "Minutes")
                {
                    TimeTo.Text = (fromAsDouble / 60).ToString() + " min";
                }
                else if (DropDownListFrom.SelectedValue == "Seconds" && DropDownListTo.SelectedValue == "Hours")
                {
                    TimeTo.Text = (fromAsDouble /60/60).ToString() + " h";
                }
                else if (DropDownListFrom.SelectedValue == "Minutes" && DropDownListTo.SelectedValue == "Seconds")
                {
                    TimeTo.Text = (fromAsDouble *60).ToString() + " s";
                }
                else if (DropDownListFrom.SelectedValue == "Minutes" && DropDownListTo.SelectedValue == "Hours")
                {
                    TimeTo.Text = (fromAsDouble /60).ToString() + " h";
                }
                else if (DropDownListFrom.SelectedValue == "Hours" && DropDownListTo.SelectedValue == "Seconds")
                {
                    TimeTo.Text = (fromAsDouble *60*60).ToString() + " s";
                }
                else if (DropDownListFrom.SelectedValue == "Hours" && DropDownListTo.SelectedValue == "Minutes")
                {
                    TimeTo.Text = (fromAsDouble *60).ToString() + " min";
                }
                              

            }
            catch (FormatException)
            {
                TimeResponse.Text = "Error! Please Enter a Valid Value! E.g. 5, 5.55";
            }
        }

        protected void btnPressureCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string from = PressureFrom.Text;
                double fromAsDouble = Convert.ToDouble(from);

                if (FromListPressure.SelectedValue == "Pascal" && ToListPressure.SelectedValue == "Bar")
                {
                    PressureTo.Text = (fromAsDouble / 100000).ToString() + " bar";
                }
                else if (FromListPressure.SelectedValue == "Pascal" && ToListPressure.SelectedValue == "Torr")
                {
                    PressureTo.Text = (fromAsDouble / 133.32236842108).ToString() + " torr";
                }
                else if (FromListPressure.SelectedValue == "Pascal" && ToListPressure.SelectedValue == "Atmosphere")
                {
                    PressureTo.Text = (fromAsDouble / 101325).ToString() + " atm";
                }
                else if (FromListPressure.SelectedValue == "Bar" && ToListPressure.SelectedValue == "Pascal")
                {
                    PressureTo.Text = (fromAsDouble * 100000).ToString() + " Pa";
                }
                else if (FromListPressure.SelectedValue == "Bar" && ToListPressure.SelectedValue == "Torr")
                {
                    PressureTo.Text = (fromAsDouble * 750.062).ToString() + " torr";
                }
                else if (FromListPressure.SelectedValue == "Bar" && ToListPressure.SelectedValue == "Atmosphere")
                {
                    PressureTo.Text = (fromAsDouble * 0.986923).ToString() + " atm";
                }
                if (FromListPressure.SelectedValue == "Torr" && ToListPressure.SelectedValue == "Pascal")
                {
                    PressureTo.Text = (fromAsDouble * 133.32236842108).ToString() + " Pa";
                }
                else if (FromListPressure.SelectedValue == "Torr" && ToListPressure.SelectedValue == "Bar")
                {
                    PressureTo.Text = (fromAsDouble / 750.062).ToString() + " bar";
                }
                else if (FromListPressure.SelectedValue == "Torr" && ToListPressure.SelectedValue == "Atmosphere")
                {
                    PressureTo.Text = (fromAsDouble * 0.00131579).ToString() + " atm";
                }
                else if (FromListPressure.SelectedValue == "Atmosphere" && ToListPressure.SelectedValue == "Pascal")
                {
                    PressureTo.Text = (fromAsDouble * 101325).ToString() + " Pa";
                }
                else if (FromListPressure.SelectedValue == "Atmosphere" && ToListPressure.SelectedValue == "Bar")
                {
                    PressureTo.Text = (fromAsDouble / 0.986923).ToString() + " bar";
                }
                else if (FromListPressure.SelectedValue == "Atmosphere" && ToListPressure.SelectedValue == "Torr")
                {
                    PressureTo.Text = (fromAsDouble / 0.00131579).ToString() + " torr";
                }


            }
            catch (FormatException)
            {
                PressureResponse.Text = "Error! Please Enter a Valid Value! E.g. 5, 5.55";
            }
        }

        protected void btnPressureReset_Click(object sender, EventArgs e)
        {
            PressureTo.Text = "";
            PressureFrom.Text = "";
            PressureResponse.Text = "";
            FromListPressure.SelectedIndex = 0;
            ToListPressure.SelectedIndex = 0;
        }

        protected void FromListPressure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToListPressure.Items.FindByValue("Pascal").Attributes.Add("style", "display: normal");
            ToListPressure.Items.FindByValue("Bar").Attributes.Add("style", "display: normal");
            ToListPressure.Items.FindByValue("Torr").Attributes.Add("style", "display: normal");
            ToListPressure.Items.FindByValue("Atmosphere").Attributes.Add("style", "display: normal");

            if (FromListPressure.SelectedValue == "Pascal")
            {
                ToListPressure.Items.FindByValue("Pascal").Attributes.Add("style", "display: none");
            }
            if (FromListPressure.SelectedValue == "Bar")
            {
                ToListPressure.Items.FindByValue("Bar").Attributes.Add("style", "display: none");
            }
            if (FromListPressure.SelectedValue == "Torr")
            {
                ToListPressure.Items.FindByValue("Torr").Attributes.Add("style", "display: none");
            }
            if (FromListPressure.SelectedValue == "Atmosphere")
            {
                ToListPressure.Items.FindByValue("Atmosphere").Attributes.Add("style", "display: none");
            }
        }

        protected void EnergyListFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnergyListTo.Items.FindByValue("Joule").Attributes.Add("style", "display: normal");
            EnergyListTo.Items.FindByValue("ElectronVolt").Attributes.Add("style", "display: normal");
            EnergyListTo.Items.FindByValue("Calorie").Attributes.Add("style", "display: normal");

            if (EnergyListFrom.SelectedValue == "Joule")
            {
                EnergyListTo.Items.FindByValue("Joule").Attributes.Add("style", "display: none");
            }
            if (EnergyListFrom.SelectedValue == "ElectronVolt")
            {
                EnergyListTo.Items.FindByValue("ElectronVolt").Attributes.Add("style", "display: none");
            }
            if (EnergyListFrom.SelectedValue == "Calorie")
            {
                EnergyListTo.Items.FindByValue("Calorie").Attributes.Add("style", "display: none");
            }
            
        }

        protected void btnEnergyCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string from = EnergyFrom.Text;
                double fromAsDouble = Convert.ToDouble(from);

                if (EnergyListFrom.SelectedValue == "Joule" && EnergyListTo.SelectedValue == "ElectronVolt")
                {
                    EnergyTo.Text = (fromAsDouble * 6.241509479607718e+18).ToString() + " eV";
                }
                else if (EnergyListFrom.SelectedValue == "Joule" && EnergyListTo.SelectedValue == "Calorie")
                {
                    EnergyTo.Text = (fromAsDouble * 0.2388458966274959).ToString() + " Cal";
                }
                else if (EnergyListFrom.SelectedValue == "ElectronVolt" && EnergyListTo.SelectedValue == "Joule")
                {
                    EnergyTo.Text = (fromAsDouble / 6.241509479607718e+18).ToString() + " J";
                }
                else if (EnergyListFrom.SelectedValue == "ElectronVolt" && EnergyListTo.SelectedValue == "Calorie")
                {
                    EnergyTo.Text = (fromAsDouble * 3.826732898633801e-20).ToString() + " Cal";
                }
                else if (EnergyListFrom.SelectedValue == "Calorie" && EnergyListTo.SelectedValue == "Joule")
                {
                    EnergyTo.Text = (fromAsDouble / 0.2388458966274959).ToString() + " J";
                }
                else if (EnergyListFrom.SelectedValue == "Calorie" && EnergyListTo.SelectedValue == "ElectronVolt")
                {
                    EnergyTo.Text = (fromAsDouble / 3.826732898633801e-20).ToString() + " eV";
                }
                
            }
            catch (FormatException)
            {
                EnergyResponse.Text = "Error! Please Enter a Valid Value! E.g. 5, 5.55";
            }
        }

        protected void btnEnergyReset_Click(object sender, EventArgs e)
        {
            EnergyTo.Text = "";
            EnergyFrom.Text = "";
            EnergyResponse.Text = "";
            EnergyListFrom.SelectedIndex = 0;
            EnergyListTo.SelectedIndex = 0;
        }

       

        protected void angleSwap_Click(object sender, EventArgs e)
        {
            int b = this.FromList.SelectedIndex;
            this.FromList.SelectedIndex = this.ToList.SelectedIndex;
            this.ToList.SelectedIndex = b;
        }

        protected void massSwap1_Click(object sender, EventArgs e)
        {
            int b = this.MassFromList.SelectedIndex;
            this.MassFromList.SelectedIndex = this.MassToList.SelectedIndex;
            this.MassToList.SelectedIndex = b;
        }

        protected void energySwap_Click(object sender, EventArgs e)
        {
            int b = this.EnergyListFrom.SelectedIndex;
            this.EnergyListFrom.SelectedIndex = this.EnergyListTo.SelectedIndex;
            this.EnergyListTo.SelectedIndex = b;
        }

        protected void lenghtSwap_Click(object sender, EventArgs e)
        {
            int b = this.FromListLenght.SelectedIndex;
            this.FromListLenght.SelectedIndex = this.ToListLenght.SelectedIndex;
            this.ToListLenght.SelectedIndex = b;
        }

        protected void timeSwap_Click(object sender, EventArgs e)
        {
            int b = this.DropDownListFrom.SelectedIndex;
            this.DropDownListFrom.SelectedIndex = this.DropDownListTo.SelectedIndex;
            this.DropDownListTo.SelectedIndex = b;
        }

        protected void pressureSwap_Click(object sender, EventArgs e)
        {
            int b = this.FromListPressure.SelectedIndex;
            this.FromListPressure.SelectedIndex = this.ToListPressure.SelectedIndex;
            this.ToListPressure.SelectedIndex = b;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            angleReset_Click(null, null);
            btnEnergyReset_Click(null, null);
            btnLenghtReset_Click(null, null);
            ButtonMassReset_Click(null, null);
            btnReset_Click(null, null);
            btnPressureReset_Click(null, null);
        }

        
    }

      

        

    }

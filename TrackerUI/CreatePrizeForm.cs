using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.model;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingform;

        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            callingform = caller; 
        }

        private void btn_CreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    txt_PlaceName.Text,
                    txt_PlaceNumber.Text,
                    txt_PrizeAmount.Text,
                    txt_PrizePercentage.Text); 

            

                
                GlobalConfigure.Connection.CreatePrize(model);

                callingform.PrizeComplete(model);

                this.Close();

                //txt_PlaceName.Text = "";
                //txt_PlaceNumber.Text = "";
                //txt_PrizeAmount.Text = "0";
                //txt_PrizePercentage.Text = "0";

            }
            else
            {
                MessageBox.Show("This form had invalid info. Please check it and try again");
            }


        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber =  int.TryParse(txt_PlaceNumber.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if(txt_PlaceName.Text.Length == 0)
            {
                output = false;
            }


            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(txt_PrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(txt_PrizePercentage.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }



            return output;
        }


    }
}

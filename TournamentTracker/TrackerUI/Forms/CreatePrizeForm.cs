using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerUI.Requesters;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        readonly IPrizeRequester callingForm;
        public CreatePrizeForm(IPrizeRequester caller)
        {
            callingForm = caller;
            InitializeComponent();
        }
        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new(
                    0,
                    int.Parse(PlaceNumberValue.Text),
                    PlaceNameValue.Text,
                    decimal.Parse(PrizeAmountValue.Text),
                    double.Parse(PrizePercentageValue.Text)
                );
                    
                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);
                Close();
            }
        }
        private bool ValidateForm()
        {
            string Output = "";

            bool IsValidPlaceNumber = int.TryParse(PlaceNumberValue.Text, out int PlaceNumber);

            if (IsValidPlaceNumber == false)
            {
                Output = "Please input a valid Place Number!";
            }

            else if (PlaceNumber < 1)
            {
                Output = "Place number must be > 0.";
            }

            else if (PlaceNameValue.Text.Length == 0)
            {
                Output = "Please input a place name.";
            }

            bool IsValidPrizeAmount = decimal.TryParse(PrizeAmountValue.Text, out decimal PrizeAmount);
            bool IsValidPrizePercentage = double.TryParse(PrizePercentageValue.Text, out double PrizePercentage);

            if (IsValidPrizeAmount == false)
            {
                Output = "Input a valid Prize Amount";
            }
            else if (IsValidPrizePercentage == false)
            {
                Output = "Input a valid Prize Percentage";
            }

            else if (PrizeAmount == 0 && PrizePercentage == 0)
            {
                Output = "Enter at least one prize parameter (percentage or amount)";
            }

            else if (PrizePercentage < 0 || PrizePercentage > 100)
            {
                Output = "Prize percentage must be positive < 100";
            }

            if (Output.Length > 0)
            {
                MessageBox.Show(Output);
                return false;
            }

            return true;
        }
    }
}

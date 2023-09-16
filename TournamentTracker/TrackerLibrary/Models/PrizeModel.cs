namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public string PrizeName
        {
            get { return $"{PlaceName}: {PrizeAmount}"; }
        }

        public PrizeModel(int Id, int PlaceNumber, string PlaceName, decimal PrizeAmount, double PrizePercentage)
        {
            this.Id = Id;
            this.PlaceNumber = PlaceNumber;
            this.PlaceName = PlaceName;
            this.PrizeAmount = PrizeAmount;
            this.PrizePercentage = PrizePercentage;
        }
    }
}

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string CellphoneNumber { get; set; }
        public string FullName 
        { 
            get { return $"{FirstName} {LastName}"; } 
        }

        public PersonModel(int Id, string FirstName, string LastName, string EmailAdress, string CellphoneNumber)
        {
            this.Id = Id ;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CellphoneNumber = CellphoneNumber; 
            this.EmailAdress = EmailAdress;
        }
    }
}

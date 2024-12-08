public class Electrician : Contractor
{
    public Electrician(string name, string phoneNumber, string email, string street1, string city, string state, string zip, string street2 = "", string website = "", int rating = 0) : base(name, phoneNumber, email, street1, city, state, zip, street2, website, rating) 
    {
        
    }
}
public class Contractor 
{
    private string _name;
    private string _phoneNumber;
    private string _email;
    private string _street1;
    private string _street2;
    private string _city;
    private string _state;
    private string _zip;
    private string _website;
    private int _rating;

    public Contractor(string name, string phoneNumber, string email, string street1, string city, string state, string zip, string street2 = "", string website = "", int rating = 0)
    {
        _name = name;
        _phoneNumber = phoneNumber;
        _email = email;
        _street1 = street1;
        _street2 = street2;
        _city = city;
        _state = state;
        _zip = zip;
        _website = website;
        _rating = rating;
    }


}
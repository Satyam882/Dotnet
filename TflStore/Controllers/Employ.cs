
public class Employ{

    public string Firstname{get;set;}
    public string Lastname{get;set;}
    public string ContactNumber{get;set;}
    public string Email{get;set;}
     public string Password{get;set;}


     public Employ(string Firstname,string Lastname,string ContactNumber,string Email,string Password){
        this.Firstname=Firstname;
        this.Lastname=Lastname;
        this.ContactNumber=ContactNumber;
        this.Email=Email;
        this.Password=Password;
     }
     

}
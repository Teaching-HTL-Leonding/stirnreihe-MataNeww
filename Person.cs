namespace Stirnreihe.Data;

public class Person
{
    public string FirstName {get; set;} 
    public string LastName{get; set;}
    public int Height{get; set;}

    public override string ToString()
    {
        return $"{FirstName} , {LastName} ({Height})";
    }
}

public class PersonModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public int Age { get; set; }
    
  
    
    public string FullName
    {
        get
        {
            // Include age in the display
            return $"{FirstName} {LastName}, Age: {Age}";
        }
    }
}
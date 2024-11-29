namespace Patikafy;

public class Singer
{
    public string Name { get; set; }

    //birden fazla müzik türü olabileceği için genre propertysini liste olarak tanımladım
    public List<string> Genre
    {
        get; 
        
        set;
    }
    
    public int Year { get; set; }
    
    public int Sales { get; set; }
}
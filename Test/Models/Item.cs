using System.ComponentModel.DataAnnotations;

namespace Test.Models;

public class Item
{
    public string Name { get; set; }


    [Key]
    public int Id { get; set; }
    
}
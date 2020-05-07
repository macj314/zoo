namespace Zoo
{
  public class Zoo
  {
    public class Enclosure
    {

    }
    public class Animal
    {
      public string Species { get; set; }
      public string Name { get; set; }
      public int Age { get; set; }
      public Animal(string species, string name, int age)
      {
        Species = species;
        Name = name;
        Age = age;
      }
    }
  }
}
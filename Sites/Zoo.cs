namespace Zoo.Sites
{
  public class Enclosures
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Enclosures(string species, string name, int age)
    {
      Species = species;
      Name = name;
      Age = age;
    }
    public string DisplayAnimal()
    {
      return "Species: " + Species + ", Name: " + Name + ", Age: " + Age;
    }
    public class Animal
    {

    }
  }
}
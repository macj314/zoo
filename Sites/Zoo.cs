using System;
using System.Collections.Generic;

namespace Zoo.Sites
{
  public class Enclosure
  {
    public string eName {get; set;}
    public Enclosure(string ename)
    {
      EName = ename;
    }
    public Dictionary<Animal> fillEnclosure()
    {
      
    }
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
      public string DisplayAnimal()
      {
        return "Species: " + Species + ", Name: " + Name + ", Age: " + Age;
      }
    }
}
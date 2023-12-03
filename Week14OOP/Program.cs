Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();  
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfhapines != 5)
{
    myDog.Bark();
}

myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfhapines; 

    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfhapines = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfhapines
    {
        get { return _levelOfhapines;}
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfhapines++;
    }  
    
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}
using static System.Console;

var animalA = new Dog();
var animalB = new Fish();
var animalC = new Bird();

animalA.Move();
animalB.Move();
animalC.Move();

class Animal
{
    // แสดงข้อความ Move สำหรับทุกชนิดของ Animal
    public virtual void Move()
    {
        WriteLine("The animal moves.");
    }
}

class Dog : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Running on the ground.");
    }
}

class Fish : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Swimming in the water.");
    }
}

class Bird : Animal
{
    public override void Move()
    {
        WriteLine($"{this.GetType().Name}: Flying in the air.");
    }
}

using System;

abstract class Animal
{
    protected string Family = "";
    protected bool Living;
    protected int Danger;
    protected int Size;
    protected bool Amphibious;
    protected bool Nocturnal;
    protected string Diet = "";
    protected bool Cute;

    public abstract string Biology();

    public abstract void Movement();

}


// Mammal family 
abstract class Mammals : Animal
{
    public bool hasStripes = true;

    public void Bite()
    {
        Console.WriteLine("The zebra here aren't afraid to bite" + "\n");
    }
}

// These concrete classes override the virtual Growl method from their parent class
// They also have access to the other class properties: hasFur
class Zebra : Mammals, IBite, IClimb
{
    protected int ls;

    public int Lifespan
    {
        get { return ls; }
        set { ls = value; }
    }

    public Zebra()
    {
        this.Family = "Equidae";
        this.Living = true;
        this.Danger = 4;
        this.Size = 5;
        this.Amphibious = false;
        this.Nocturnal = false;
        this.Diet = "herbivore";
        this.Cute = false;
    }

    public int Life(int l)
    {
        this.Lifespan = l; // using set on the Lifespan property
        Console.WriteLine("A Zebra's lifespan is " + this.Lifespan + "\n"); // using get on the Lifespan property
        return this.Lifespan;
    }

    public override string Biology()
    {
        return " Zebras Home of the " + this.Family + " Family, these creatures have a " + this.Danger + " rating and are of " + this.Size + " on the CodeSchool Size charts. Amphibious: " + this.Amphibious + ". Nocturnal: " + this.Nocturnal + ". Diet: " + this.Diet + ". Cute: " + this.Cute;
    }

    public override void Movement()
    {
        Console.WriteLine("Zebras are fast " + "\n");
    }

    public new void Bite() // Fix: Changed to 'new' to explicitly hide the inherited member
    {
        Console.WriteLine("Zebra will bite, stay away!" + "\n");
    }

    public void Climb()
    {
        Console.WriteLine("Zebras don't climb." + "\n");
    }
}


class MountainZebra: Zebra, IBite, IClimb
{
    protected int ls;

    public int Lifespan
    {
        get { return ls; }
        set { ls = value; }
    }

    public MountainZebra()
    {
        this.Family = "Equidae";
        this.Living = true;
        this.Danger = 4;
        this.Size = 5;
        this.Amphibious = false;
        this.Nocturnal = false;
        this.Diet = "herbivore";
        this.Cute = false;
    }

    public int Life(int l)
    {
        this.Lifespan = l; // using set on the Lifespan property
        Console.WriteLine("A  mountain Zebra's lifespan is " + this.Lifespan + "\n"); // using get on the Lifespan property
        return this.Lifespan;
    }

    public override string Biology()
    {
        return " Mountain Zebras Home of the " + this.Family + " Family, these creatures have a " + this.Danger + " rating and are of " + this.Size + " on the CodeSchool Size charts. Amphibious: " + this.Amphibious + ". Nocturnal: " + this.Nocturnal + ". Diet: " + this.Diet + ". Cute: " + this.Cute;
    }

    public override void Movement()
    {
        Console.WriteLine("Mountain are Endure tough eviromrents  " + "\n");
    }

    public new void Bite() // Fix: Changed to 'new' to explicitly hide the inherited member
    {
        Console.WriteLine(" Mountain Zebras are agile " + "\n");
    }

    public void Climb()
    {
        Console.WriteLine(" mountins Zebras  climb." + "\n");
    }
}












class Tiger : Mammals, IGrowl, IClimb
{
    public Tiger()
    {
        this.Family = "Panthera";
        this.Living = true;
        this.Danger = 8;
        this.Size = 4;
        this.Amphibious = false;
        this.Nocturnal = false;
        this.Diet = "carnivore";
        this.Cute = true;
    }

    public override string Biology()
    {
        return "Tiger is home of the " + this.Family + " Family, these creatures have a " + this.Danger + " rating and are of " + this.Size + " on the Zoo Size charts. Amphibious: " + this.Amphibious + ". Nocturnal: " + this.Nocturnal + ". Diet: " + this.Diet + ". Cute: " + this.Cute;
    }

    public override void Movement()
    {
        Console.WriteLine("Tiger is FAST AF" + "\n");
    }

    public void Growl()
    {
        Console.WriteLine("RAWR!" + "\n");
    }

    public void Climb()
    {
        Console.WriteLine("Tiger climbs trees " + "\n");
    }
}



class whiteTiger : Tiger, IGrowl, IClimb
{
    public whiteTiger()
    {
        this.Family = "Panthera";
        this.Living = true;
        this.Danger = 8;
        this.Size = 4;
        this.Amphibious = false;
        this.Nocturnal = false;
        this.Diet = "carnivore";
        this.Cute = true;
    }

    public override string Biology()
    {
        return " white Tiger is home of the " + this.Family + " Family, these creatures have a " + this.Danger + " rating and are of " + this.Size + " on the Zoo Size charts. Amphibious: " + this.Amphibious + ". Nocturnal: " + this.Nocturnal + ". Diet: " + this.Diet + ". Cute: " + this.Cute;
    }

    public override void Movement()
    {
        Console.WriteLine("white tiger are bigger" + "\n");
    }

    public  void Growl()
    {
        Console.WriteLine("white are rare" + "\n");
    }

    public void Climb()
    {
        Console.WriteLine("White Tiger climbs trees " + "\n");
    }
}
class Turtle : Mammals, IHibernate, IClimb
{
    public Turtle()
    {
        this.Family = "Pleurodires";
        this.Living = true;
        this.Danger = 1;
        this.Size = 2;
        this.Amphibious = false;
        this.Nocturnal = false;
        this.Diet = "herbivore";
        this.Cute = true;
    }

    public override string Biology()
    {
        return "Turtles home of the " + this.Family + " Family, these creatures have a " + this.Danger + " rating and are of " + this.Size + " on the CodeSchool Size charts. Amphibious: " + this.Amphibious + ". Nocturnal: " + this.Nocturnal + ". Diet: " + this.Diet + ". Cute: " + this.Cute;
    }

    public override void Movement()
    {
        Console.WriteLine("Slow rolling!!!" + "\n");
    }

    public void Growl()
    {
        Console.WriteLine("Turtles don't growl" + "\n");
    }

    public void Hibernate()
    {
        Console.WriteLine("Nite nite" + "\n");
    }

    public void Climb()
    {
        Console.WriteLine("Turtles don't climb" + "\n");
    }
}

// Composition Example via Interfaces
// Interfaces pass on Methods (functions) to classes
// Classes can have as many interfaces as needed, but only 1 parent class
interface IHibernate
{
    void Hibernate();
}

interface IClimb
{
    void Climb();
}

interface IBite
{
    void Bite();
}

interface IGrowl
{
    void Growl();
}


abstract class Water
{
    
    protected string FamilyOne = "";
    protected bool LivingOne;

    protected int DangerOne;

    protected int SizeOne;

    protected bool AmphibiousOne;

    protected bool NocturnalOne;

    protected string DietOne = "";

    protected bool CuteOne;

    public abstract string Bio();

    public abstract void Mover();


}



abstract class SeaCreatures: Water
{
    public bool liveInWater = true;
    // public virtual void Growl()
    // {
    //     Console.WriteLine("growl");
    // }
    public void swim()
    {
        Console.WriteLine(" sea creatures are excellence swimmers");
    }
}



class Whale: SeaCreatures,  ISonar ,  IWhaleLang
{
    protected int lss;
    public int LifespanOne 
    {
        get { return lss; }
        set { lss = value; }
    }
    public Whale() 
    {
        this.FamilyOne = "Equidae";
        this.LivingOne = true;
        this.DangerOne = 2;
        this.SizeOne = 10;
        this.AmphibiousOne = false;
        this.NocturnalOne = false;
        this.DietOne = "herbivore";
        this.CuteOne = false;
    }
    public int Life(int l) 
    {
        this.LifespanOne = l; //using set on the Lifespan property
        Console.WriteLine("a Whale  Life span is " + this.LifespanOne + "\n"); //using get on the Lifespan property
        return this.LifespanOne;
    }
    public override string Bio()
    {
        return "Whale Home of the  " + this.FamilyOne + " Family, these creatures have a " + this.DangerOne + " rating because  and are of " + this.SizeOne + " on the CodeSchool Size charts. Amphibious: " + this.AmphibiousOne + ". Nocturnal: " + this.NocturnalOne + ". Diet: " + this.DietOne + ". Cute: " + this.CuteOne;
    }
    public override void Mover()
    {
        Console.WriteLine("Whales are Good swimmers " + "\n");
    }
    public void Sonar()
    {
        //call this in program whal.Sonar
        Console.WriteLine("Whales Have sonar " + "\n");
    }

    public void whaleLang(){

         Console.WriteLine("Whales has a language " + "\n");

    }
}

class Seal: SeaCreatures, ISleep 
{
    public Seal () 
    {
        this.FamilyOne = "Panthera";
        this.LivingOne = true;
        this.DangerOne = 5;
        this.SizeOne = 7;
        this.AmphibiousOne = false;
        this.NocturnalOne = false;
        this.DietOne = "carnivore";
        this.CuteOne = true;
    }

    public override string Bio()
    {
        return "Seal is home of the  " + this.FamilyOne + " Family, these creatures have a " + this.DangerOne + " rating and are of " + this.SizeOne + " on the Zoo Size charts. Amphibious: " + this.AmphibiousOne + ". Nocturnal: " + this.NocturnalOne + ". Diet: " + this.DietOne + ". Cute: " + this.CuteOne;
    }
    public override void Mover()
    {
        Console.WriteLine(" Seal Are Gymnastic swimmers" + "\n");
    }
    public void Roar()
    {
        Console.WriteLine("Seal sings  the beatiful " + "\n");
    }

    public void Sleep(){

         Console.WriteLine("Seal  Climbs trees " + "\n");

    }
}


//

class Shark: SeaCreatures, ISleep , ITackle, IRoar
{
    public Shark() 
    {
        this.FamilyOne = "Pleurodires";
        this.LivingOne = true;
        this.DangerOne = 1;
        this.SizeOne = 2;
        this.AmphibiousOne = false;
        this.NocturnalOne = false;
        this.DietOne = "herbivore";
        this.CuteOne = true;
    }

    public override string Bio()
    {
        return "Shark home of the" + this.FamilyOne + " Family, these creatures have a " + this.DangerOne + " rating and are of " + this.SizeOne + " on the CodeSchool Size charts. Amphibious: " + this.AmphibiousOne + ". Nocturnal: " + this.NocturnalOne + ". Diet: " + this.DietOne + ". Cute: " + this.CuteOne;
    }
    public override void Mover()
    {
        Console.WriteLine("Swims Straight !!!" + "\n");
    }
    public void  Roar()
    {
        Console.WriteLine(" Growling is the last thing you need to worry about if it close " + "\n");
    }
    public void Sleep() 
    {
        Console.WriteLine("Nite nite" + "\n");
    }

    public void Tackle(){

         Console.WriteLine("Sharks hits there pray head on " + "\n");

    }
}

//Composition Example via Interfaces
//Interfaces pass on Methods (functions) to classes
//Classes can have as many interfaces as needed, but only 1 parent class
interface ISleep
{
    void Sleep();

}

interface ITackle 
{
    void Tackle();
}

interface IRoar
{
    void Roar();
}


interface ISonar
{
    void Sonar();
}

interface IWhaleLang  
{
    void whaleLang();
}
/* function return types in C#
//void doesn't return anything
void someOtherFunction() {
    Console.WriteLine("");
}

the named type has to be returned
int anotherFunction()
{
    return 1;
}
bool anothernotherFunc()
{
    return false;
}

//js example - no named type
function someFunction() {
    return 'a';
}
*/






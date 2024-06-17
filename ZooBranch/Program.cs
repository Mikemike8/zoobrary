// public


// The type or member can be accessed by any other code in the same assembly or another assembly that references it.

// private
// The type or member can only be accessed by code in the same class or struct.

// protected
// The type or member can only be accessed by code in the same class or struct, or in a derived class.

// private protected (added in C# 7.2)
// The type or member can only be accessed by code in the same class or struct, or in a derived class from the same assembly, but not from another assembly.

// internal
// The type or member can be accessed by any code in the same assembly, but not from another assembly.

// protected internal
// The type or member can be accessed by any code in the same assembly, or by any derived class in another assembly.


// namespace ZooBranch;

﻿// using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net.Http;
// using System.Threading;
// using System.Threading.Tasks;


namespace ZooBranch;

class Program
{
    internal void NonStatic()
    {
        Console.WriteLine("");
    }
    internal static void Main(string[] args)
    {
        MammalsMethods();
        /*
        Method practice
        Console.WriteLine("Hello, World!");
        Aloha();
        //CodeCrew.CSGraduates();
        var newObject = new CodeCrew();
        newObject.CSGraduates();
        //Private function is unusable outside of the class
        //newObject.CodeSchool();
        */
    }

    //Introductory inheritance usage
    static void MammalsMethods()
    {
        //Can't create an object/instance from an abstract class
        //Bear bear = new Bear();
        Zebra zee = new Zebra();
        Turtle turk = new Turtle();
        Tiger tie = new Tiger();
        whiteTiger WT = new whiteTiger();
        MountainZebra MT = new MountainZebra();
       
       // Sea creatures
        Whale whal = new Whale();
        Shark Shar = new Shark();
        Seal  Sea = new Seal();




        Console.WriteLine(whal.Bio() + "\n");
        whal.Mover();
        whal.Sonar();
        whal.whaleLang();
        Console.WriteLine("Whales are interesting" + "\n");


        Console.WriteLine(Sea.Bio() + "\n");
        Sea.Sleep();
        Sea.Roar();
        Sea.Mover();
        Console.WriteLine("Seals are Cool" + "\n");

        
        Console.WriteLine(" Next Zoo Animal............................" + "\n");

        Console.WriteLine( "\n");

        Console.WriteLine( "\n");



         Console.WriteLine(Shar.Bio() + "\n");
        Shar.Sleep();
        Shar.Roar();
        Shar.Tackle();
        Console.WriteLine(Shar.liveInWater);
        






        // Next Family  .................................



        //bear.Growl();
        Console.WriteLine(turk.Biology() + "\n");
        turk.Movement();
        turk.Growl();
        turk.Climb();
        Console.WriteLine("Turtles are the best" + "\n");

        
        Console.WriteLine(" Next Zoo Animal............................" + "\n");

        Console.WriteLine( "\n");

        Console.WriteLine( "\n");


        
       Console.WriteLine(WT.Biology() + "\n");
        WT.Movement();
        WT.Growl();
        WT.Climb();
         Console.WriteLine(" White tiger Zoo Animal..........................................." + "\n");


        //Each kind of zeebra has access to the properties it inherits from zebra
       

        Console.WriteLine(tie.Biology() + "\n");
        tie.Movement();
        tie.Growl();
        tie.Climb();
        Console.WriteLine("Tiger are assassins" + "\n");

        Console.WriteLine(" Last Zoo Animal..........................................." + "\n");


        Console.WriteLine( "\n");
        Console.WriteLine( "\n");
        
        Console.WriteLine(zee.Biology() + "\n");
        MT.Movement();
        MT.Bite();
        MT.Climb();
        Console.WriteLine("Has fur ");
    


        
        Console.WriteLine(zee.Biology() + "\n");
        zee.Movement();
        zee.Bite();
        zee.Climb();
        Console.WriteLine(zee.hasStripes);
    }

    // public static void Aloha() 
    // {
    //     Console.WriteLine("Greetings from Hawaii");
    // }
}

























// class StaticExample 
// {
//     void ExampleCalls()
//     {
//         //Static Method Calls
//         Program.Main([]);
//         Program.Aloha();
        
//         //NonStatic Method Call
//         var newInstance = new Program();
//         newInstance.NonStatic();
//     }

// }
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace HelloWorld
{
    public static class Hello
    {

        // main method with parameter called args which is type of string
        // method = void; returns nothing
        static void Main(string[] args)
        {

            // create instance of Write Class and name it writer
            // formula is klas naem space instance name equals to new Klasnameparanthesis and semikolon

            Write writer = new Write();

            // run method AskName to promt user and get WName
            writer.AskName();

            // greet user after promting them
            Console.WriteLine("Hello, " + writer.Name + "!");
        }
    }
}

// accessing WName without creating an instance of Write class in the same namespace
// in Write class:
//     public static string WName = ""

// in Hello class:
//     string name =  Write.Wname


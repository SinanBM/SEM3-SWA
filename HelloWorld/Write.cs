namespace HelloWorld
{
    // a class to ask users' name and store it in variable WName
    public class Write
    {

        // store name privately after reading it from the console.
        private string name = "";

        // store name in Name for public use
        public string Name => name;

        // A method to prompt users for their name
        public void AskName()
        {
            Console.WriteLine("What's your name?");
            // read the name from the console and assign it to WName
            name = (Console.ReadLine() ?? "").Trim();

            // check if name is empty or whitespace and promt user for a valid name.
            while (name == "")
            {
                Console.WriteLine("Please enter a valid name");
                name = (Console.ReadLine() ?? "").Trim();
            }

            // Capitalize first letter, lowercase the rest
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            
        }
    }
}

/* BREIF
 * 
 * Create an array of 3 names. Ask the user which number to select. When the 
 * user gives you a number, return that name. Make sure to check for invalid 
 * numbers.
 *
 */
string[] firstNames = new string[] { "Corey", "Smith", "Jones" };
string inputStatus;
bool exitStatus = false;

do
{
    Console.Write("The array holds 3 names. Type 1, 2 or 3 and press enter: ");
    string indexStr = Console.ReadLine();
    int.TryParse(indexStr, out int index);
    int newIndex = index - 1;

    if (newIndex >= 0 && newIndex <= 3)
    {
        Console.WriteLine($"The name you selected was: {firstNames[newIndex]}");
    }
    else
    {
        Console.WriteLine("Index was out of range, or doesn't exist");
    }


    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Type Exit to close, or press ENTER to continue");
    inputStatus = Console.ReadLine();
    if (inputStatus.ToLower() == "exit")
    {
        exitStatus = true;
    }

} while (exitStatus == false);
// while tsükkel - töötab kuni mingi tingimus on täidetud
Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool - true or false

while (loopActive) //while kestab kuni tingimus on true
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false; //kui tingimus on tõene, lõpeb while-tsükkel ära.
        break; //lõpetab while-tsükli töö ära
    }
    else
    {
        Console.WriteLine("Oops! Try again");
    }
}
Console.WriteLine("Have a nice day!");


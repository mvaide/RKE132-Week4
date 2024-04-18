
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while(loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess, enter a number 1-3:");
    int userNumber = int.Parse(Console.ReadLine());
}
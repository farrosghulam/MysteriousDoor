string secretCode = "1992";
string attempt = "";

int tries = 3;

while (attempt != secretCode && tries > 0)
{
    Console.WriteLine("Enter the secret code to unlock the door:");
    attempt = Console.ReadLine();
    tries--;
    if (attempt != secretCode)
    {
        Console.WriteLine($"Wrong code! You have {tries} tries left.");
    }
    else
    {
        Console.WriteLine("The door is unlocked! Congratulations!");
    }
}

if (tries == 0)
{
    Console.WriteLine("You've run out of tries. The door remains locked.");
}

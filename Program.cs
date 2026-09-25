string secretCode = "1992";
string attempt = "";

while (attempt != secretCode)
{
    Console.WriteLine("Enter the secret code to unlock the door:");
    attempt = Console.ReadLine();
}

Console.WriteLine("The door is unlocked! Congratulations!");    
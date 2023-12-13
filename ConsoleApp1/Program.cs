
void Coins(int a, int b, int c, int total)
{
    if (a == b || b == c || a == c) 
    {
        Console.WriteLine($"Dice rolled: {a} + {b} + {c} = {total}");
        Console.WriteLine("You win 6  coins"); 
        Casino.coins += 6;
    }
    else if (total >= 15)
    {
        Console.WriteLine("You won 2 coins");
        Casino.coins += 2;
    }
    
    else
    {
        Console.WriteLine("You lose 1 coin");
        Casino.coins -= 1;
    }
    
    
    Console.WriteLine($"Coins: {Casino.coins}");
}

Random dice = new Random();
int roll = dice.Next(1, 9);
int roll1 = dice.Next(1, 9);
int roll2 = dice.Next(1, 9);   
int total = roll + roll1 + roll2;
Console.WriteLine($"Dice rolled: {roll} + {roll1} + {roll2} = {total}");
Coins(roll, roll1, roll2, total);
Coins(roll, roll1, roll2, total);
Coins(roll, roll1, roll2, total);


class Casino
{
    public static int coins = 10;
}
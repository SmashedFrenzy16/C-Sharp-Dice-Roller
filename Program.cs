// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

Console.ForegroundColor = ConsoleColor.DarkRed;

int genNum;

int howManyDice;

bool go = true;

Dictionary<Int128, string> dice = new Dictionary<Int128, string>();

dice.Add(1, "-----\n|   |\n| o |\n|   |\n-----\n");
dice.Add(2, "-----\n|o  |\n|   |\n|  o|\n-----\n");
dice.Add(3, "-----\n|o  |\n| o |\n|  o|\n-----\n");
dice.Add(4, "-----\n|o o|\n|   |\n|o o|\n-----\n");
dice.Add(5, "-----\n|o o|\n| o |\n|o o|\n-----\n");
dice.Add(6, "-----\n|o o|\n|o o|\n|o o|\n-----\n");

Random diceNum = new Random();

while(go = true)
{

    Console.Write("Enter in how many dice you want to roll: ");

    howManyDice = (int)Convert.ToInt64(Console.ReadLine());

    for (int i = 0; i < howManyDice; i++)
    {

        genNum = diceNum.Next(1, 7);

        Console.WriteLine(dice[genNum]);

    }

    Console.Write("Do you want to go again (y/n)?: ");

    if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
    {
        go = true;

    } else
    {
        go = false;
    }
}

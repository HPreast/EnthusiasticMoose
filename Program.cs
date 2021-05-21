﻿using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();


MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");


Main();

void Main()
{
    Question("Is Canada Real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    Question("Are you enthusiastic?", "Yay!", "You should try it");
    Question("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    Question("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
}



void Question(string question, string trueAnswer, string falseAnswer)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(trueAnswer);
    }
    else
    {
        MooseSays(falseAnswer);
    }
}



void MooseSays(string message)
{
    Console.WriteLine($@"
                                           _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }
    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}


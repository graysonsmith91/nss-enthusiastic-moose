// using System;

// Main();

// void Main()
// {
//     Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();

//     // Let the moose speak!
//     MooseSays("H I, I'M  E N T H U S I A S T I C !");
//     MooseSays("I really am enthusiastic");

//     // Questions for the Moose
//     string[] canadaQuestion = { "Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!" };
//     string[] enthusiasticQuestion = { "Are you enthusiastic?", "Yay!", "You should try it!" };
//     string[] loveCSharpQuestion = { "Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will..." };
//     string[] secretQuestion = { "Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!" };

//     // Ask a question
//     Question(canadaQuestion);
//     Question(enthusiasticQuestion);
//     Question(loveCSharpQuestion);
//     Question(secretQuestion);
// }


// void Question(string[] questionArray)
// {
//     bool isTrue = MooseAsks(questionArray[0]);
//     if (isTrue)
//     {
//         MooseSays(questionArray[1]);
//     }
//     else
//     {
//         MooseSays(questionArray[2]);
//     }
// }

// void MooseSays(string message)
// {
//     Console.WriteLine($@"
//                                       _.--^^^--,
//                                     .'          `\
//   .-^^^^^^-.                      .'              |
//  /          '.                   /            .-._/
// |             `.                |             |
//  \              \          .-._ |          _   \
//   `^^'-.         \_.-.     \   `          ( \__/
//         |             )     '=.       .,   \
//        /             (         \     /  \  /
//      /`               `\        |   /    `'
//      '..-`\        _.-. `\ _.__/   .=.
//           |  _    / \  '.-`    `-.'  /
//           \_/ |  |   './ _     _  \.'
//                '-'    | /       \ |
//                       |  .-. .-.  |
//                       \ / o| |o \ /
//                        |   / \   |    {message}
//                       / `^`   `^` \
//                      /             \
//                     | '._.'         \
//                     |  /             |
//                      \ |             |
//                       ||    _    _   /
//                       /|\  (_\  /_) /
//                       \ \'._  ` '_.'
//                        `^^` `^^^`
//     ");
// }


// bool MooseAsks(string question)
// {
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower();

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }



using System;
// using System.Collections.Generic;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose!");
    Console.WriteLine("---------------------------");
    Console.WriteLine();

    // Let the moose speak!
    // MooseSays("Please ask me a question");

    Answer();
}


void Answer()
{
    bool isTrue = AskMoose();
    if (isTrue)
    {
        string[] possibleAnswers = {
          "As I see it, yes.",
          "Ask again later.",
          "Better not tell you now.",
          "Cannot predict now.",
          "Concentrate and ask again.",
          "Don’t count on it.",
          "It is certain.",
          "It is decidedly so.",
          "Most likely.",
          "My reply is no.",
          "My sources say no.",
          "Outlook not so good.",
          "Outlook good.",
          "Reply hazy, try again.",
          "Signs point to yes.",
          "Very doubtful.",
          "Without a doubt.",
          "Yes.",
          "Yes – definitely.",
          "You may rely on it."
        };

        Random r = new Random();
        int answerIndex = r.Next(0, 19);
        string answer = possibleAnswers[answerIndex];
        MooseSays(answer);
    }
    else
    {

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


bool AskMoose()
{
    Console.Write("Please ask me a question: ");
    string question = Console.ReadLine();

    while (question == "")
    {
        Console.Write("Please ask me a question: ");
        question = Console.ReadLine();
    }

    if (question != "")
    {
        return true;
    }
    else
    {
        return false;
    }
}
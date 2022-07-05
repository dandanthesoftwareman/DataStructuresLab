
bool runProgram = true;
string input = "";

while (runProgram)
{
    try
    {
        Console.WriteLine("Please enter a word you would like reversed");
        input = Console.ReadLine();
        if (input.Any(Char.IsDigit))
        {
            throw new Exception("Please refrain from using numbers");
        }
        else if (input.Any(Char.IsSymbol))
        {
            throw new Exception("Please refrain from using symbols");
        } 
        else
        {
            Console.WriteLine(wordReverse(input));
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    while(true)
    {
        Console.WriteLine("Reverse again? y/n");
        string choice = Console.ReadLine().ToLower();
        if (choice == "y")
        {
            break;
        }
        else if (choice == "n")
        {
            Console.WriteLine("Goodbye!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please type y/n");
        }
    }
}

static string wordReverse(string sentence)
{
    string reversed = "";
    Stack<char> wordStack = new Stack<char>();

    foreach (char c in sentence)
    {
        wordStack.Push(c);
    }

    foreach (char c in wordStack)
    {
        reversed += c;
    }

    string result = "";
    string[] wordsReverseOrder = reversed.Split(' ');
    for (int i = wordsReverseOrder.Length - 1; i >= 0; i--)
    {
        result += wordsReverseOrder[i] + " ";
    }
    return result;
}
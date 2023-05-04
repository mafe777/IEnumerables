using IEnumerables.logic;

int option;
do
{
    option = Menu();
    switch (option)
    {
        case 1: theList(); break;
        case 2: theDictionary(); break;
        case 3: theLinkedList(); break;
        case 4: theAnagrams(); break;

        default: break;
    }
} while (option != 0);

void theAnagrams()
{
    Console.Write("Enter the first word: ");
    string word1 = Console.ReadLine()!.ToLower();
    Console.Write("Enter the second word: ");
    string word2 = Console.ReadLine()!.ToLower();
    var areanagrams = new Anagrams (word1, word2);
    areanagrams.IsAnagram();
    Console.WriteLine(areanagrams);
}

void theLinkedList()
{
    throw new NotImplementedException();
}

void theDictionary()
{
    throw new NotImplementedException();
}

void theList()
{
    throw new NotImplementedException();
}

int Menu()
{
    Console.WriteLine(" *-- IENUMERABLES--*   ");
    Console.WriteLine("      1. list");
    Console.WriteLine("      2. Dictionary");
    Console.WriteLine("      3. Linked List");
    Console.WriteLine("      4. Anagrams");
    Console.WriteLine("      0. Exit");
    Console.Write("     Choose the option:  ");
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}
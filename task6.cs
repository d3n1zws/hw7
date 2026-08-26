string word = Console.ReadLine();
OnlyLetter(word);
void OnlyLetter(string word)
{
    foreach (char c in word)
    {
        if (!char.IsLetter(c))
        {
            Console.WriteLine("ancaq herfden ibaret deyil");
            return;
        }
    }
    Console.WriteLine("ancaq herfden ibaretdir");
}
string word = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Repeat(word,n));
string Repeat(string word, int n)
{
    string newword = "";
    for (int i = 0; i < n; i++)
    {
        newword += word;
    }
    return newword;
}
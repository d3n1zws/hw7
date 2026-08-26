string word = Console.ReadLine();
word = word.ToLower();
char c = word[0];
c = char.ToUpper(c);
word = c + word.Substring(1);
Console.WriteLine(word);
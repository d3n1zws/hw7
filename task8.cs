int n = int.Parse(Console.ReadLine());
string[] arr = new string[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine();
    arr[i] = arr[i].Substring(0, arr[i].IndexOf(' '));
    Console.WriteLine(arr[i]);
}
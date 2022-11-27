string [] addNewItem(string [] array, string item)
{
    if (array.Length == 0)
    {
        string [] result = new string [1] {item};
        return result;
    }
    else 
    {
        string [] result = new string [array.Length + 1];
        array.CopyTo(result, 0);
        result [array.Length] = item;
        return result;
    }
    
}

string [] str = {"hello" , "2", "world", ":-)", "23"};
string [] str1 = {};
for (int i = 0; i < str.Length; i++)
{
    if (str[i].Length <= 3) str1 = addNewItem(str1, str[i]);
}
Console.WriteLine($"Lenght {str1.Length}");
Console.WriteLine("Result array: ");

for ( int i = 0; i < str1.Length; i++)
{
    Console.Write($"{str1[i]} ");
}
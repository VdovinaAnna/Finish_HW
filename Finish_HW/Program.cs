string[] symbols1 = new string[5] {"157", "2", "hello", "world", ";)"};
string[] symbols2 = new string[symbols1.Length];


void FillArray(string[] symbols1, string[] symbols2)
{
    int count = 0;
    for (int i = 0; i < symbols1.Length; i++)
    {
    if(symbols1[i].Length <= 3)
        {
        symbols2[count] = symbols1[i];
        count++;
        }
}
}
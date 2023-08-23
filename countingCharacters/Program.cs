//Dictionary<char, int> word = new Dictionary<char, int>();

string myString = "catcatdog";
char[] charactersInString = myString.ToCharArray();



while (charactersInString.Length > 0)
{
    int integersInString = 0;
    for (int i = 0; i < charactersInString.Length; i++)
    {
        if (charactersInString[0] == charactersInString[i])
        {
            Console.Write(charactersInString[i] + " : ");
            integersInString++;
        }
    }
    Console.WriteLine(integersInString);
}


Console.ReadLine();
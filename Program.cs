
    // Convert string to char array.
   /* string sentence = "MartinDevs";
    char[] charArr = sentence.ToCharArray();
    foreach (char ch in charArr)
    {
        Console.WriteLine(ch);*/



string reverseThisString = "Hi! My Name is MartinDevs";

//Convert string to a char array
char[] charactersInString = reverseThisString.ToCharArray();

//Loop on all the elements in the array
for (int i = 0, j = charactersInString.Length - 1; i < j; i++, j--)
{
    //swap i with j
    charactersInString[i] = reverseThisString[j];
    charactersInString[j] = reverseThisString[i];
}

Console.WriteLine(new string(charactersInString));

// See https://aka.ms/new-console-template for more information


static void bubbleSortString(char[] x, int n)
{
    //var arr = x.ToCharArray();
    char temp;

     // Sorting strings using bubble sort
    for (int j = 0; j < n - 1; j++)
    {
        for (int i = j + 1; i < n; i++)
        {
            if (x[j].CompareTo(x[i]) > 0)
            {
                temp = x[j];
                x[j] = x[i];
                x[i] = temp;
            }
        }
    }
}

static string reverseCharacterArray(char[] x, int n)
{
    char[] arr = new char[n];
    String newString;

    for(int i = 0; i < (n-1); i++)
    {

        arr[arr.Length-1 - i] = x[i];
    }

    newString = new String(arr);

    return newString;
}

static bool palindromeCheck(string x)
{
    var xArray = x.ToCharArray();


    var reverseXArray = reverseCharacterArray(xArray, xArray.Length);


    x = new String(xArray);
    String y = new String(reverseXArray);

    if (x==y)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

static bool anigramCheck(string x, string y)
{

    x = x.ToLower();
    y = y.ToLower();
    var xArray = x.ToCharArray();
    var yArray = y.ToCharArray();

    // Use bubble sort to sort strings
    bubbleSortString(xArray, x.Length);
    bubbleSortString(yArray, y.Length);

    // Create new strings from array of sorted characters
    x = new String(xArray);
    y = new String(yArray);

    // if/else statement to check if x == y
    if(x == y){
     return true;
    }
    else
    {
        return false;
    }
}


// Request for the first String
Console.Write("Please enter string 1: ");
String stringOne = Console.ReadLine();

// Request for the second String
Console.Write("Please enter string 2: ");
String stringTwo = Console.ReadLine();

if(palindromeCheck(stringOne)){
    Console.WriteLine("This is a palindrome!");
}
else
{
    Console.WriteLine($"Sorry, {stringOne} is not a palindrome");
}

if(palindromeCheck(stringTwo)){
    Console.WriteLine("This is a palindrome!");
}
else
{
    Console.WriteLine($"Sorry, {stringTwo} is not a palindrome");
}


if(anagramCheck(stringOne, stringTwo)){
    Console.WriteLine($"{stringOne} & {stringTwo} are anagrams!");
}
else
{
    Console.WriteLine($"Sorry, {stringOne} & {stringTwo} are not  anagrams");
}
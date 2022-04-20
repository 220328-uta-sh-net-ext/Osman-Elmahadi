
// C# program to check whether two
// strings are anagrams of each other
using System;
using System.Collections;
class GFG {
 
    /* function to check whether two
strings are anagram of each other */
    public static bool areAnagram(ArrayList str1,
                                  ArrayList str2)
    {
        // Get lengths of both strings
        int s1 = str1.Count;
        int s2 = str2.Count;
 
        // If length of both strings is not
        // same, then they cannot be anagram
        if (s1 != s2) {
            return false;
        }
 
        // Sort both strings
        str1.Sort();
        str2.Sort();
 
        // Compare sorted strings
        for (int i = 0; i < s1; i++) {
            if (str1[i] != str2[i]) {
                return false;
            }
        }
 
        return true;
    }
 
    // Driver Code
    public static void Main(string[] args)
    {
        // create and initialize new ArrayList
        ArrayList str1 = new ArrayList();
        str1.Add('d');
        str1.Add('a');
        str1.Add('n');
        str1.Add('g');
        str1.Add('e');
        str1.Add('r');
        // create and initialize new ArrayList
        ArrayList str2 = new ArrayList();
        str2.Add('g');
        str2.Add('a');
        str2.Add('r');
        str2.Add('d');
        str2.Add('e');
        str2.Add('n');
        // Function call
        if (areAnagram(str1, str2)) {
            Console.WriteLine("The two strings are"
                              + " anagram of each other");
        }
        else {
            Console.WriteLine("The two strings are not"
                              + " anagram of each other");
        }
    }
}

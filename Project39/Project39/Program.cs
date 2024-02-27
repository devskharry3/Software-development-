using System;
using System.Text;

//IsPalindrome returns a tuple of two values
//the function name is "IsPalindrome"
//the bool is going to tell us whether the inserted string is a Palindrome or not 
//and the integeer is going to tell us the kength of the string if it is a palindrome
// and it output "0" if it is not a palindrome at all
(bool, int) IsPalindrome(string thestr) {
    string teststr;

    //Convert the string to upper-case
    //This helps us to ignore the case and will unify all the letters
    //1st step:
    teststr = thestr.ToUpper();
    /*
    in this code then I am going to use a string builder to strip out all the punctuation and
    white space from the input string,so this loop processes each character in the string and adds
    it to the StringBuilder if it's not punctuation and it's not white space.

    in the next step, I then convert the StringBuilder content to a finished string.So at this point
    the string has been stripped to punctuation and white space and it's all uppercase leaving only
    the characters.-> This is the string that the rest of the function uses to determine
    whether it's a palindrome or not.So the way the code does this is by
    comparing each chracter pair, starting at the beginning and end of the string, and then working its way in
    */

    //2nd step:
    // Use a StringBuilder to strip out all the punctuation
    //we use a foreach loop here to examine each character of the string one by one
    var sb = new StringBuilder();
    foreach(char c in teststr) {
        //Add characters to the builder if not punctuation or white space
        if(!char.IsPunctuation(c) && !char.IsWhiteSpace(c)) {
            sb.Append(c);
        }
    }

    //3rd step:
    //convert the builder to the finished string
    teststr = sb.ToString();

    //4th step
    //compare characters starting at beginning and end of string
    int i=0, j=teststr.Length-1;
    //if the indexes cross each other, then we're done
    while(i<= j){
        //if the character at each index doesn't match,it's not a palindrome
        if(teststr[i] !=teststr[j]) {
            return(false, 0);
        }
        //update the counters and try again
        i++;
        j--;
    }
    //if we reach this point, we must have a palindrome
    return(true,thestr.Length);
}
//this part of the code just deals with the input from the user and "exit" keyword to
//end the program
string inputstr="";
(bool b, int l) result;
Console.WriteLine("Let's begin");
while (inputstr != "exit") {
    inputstr = Console.ReadLine();
    if (inputstr != "exit") {
        result = IsPalindrome(inputstr);
        Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");

    }
}
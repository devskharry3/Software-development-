
// Declare a character variable 'ch'
char ch = 'y';

// Declare a string variable 'letterType' and initialize it as "Consonant"
string letterType = "Consonant";

// Check if the character is a vowel by searching for it in the string "AEIOUEIOU"
// If the character is found in the string, update 'letterType' to "Vowel"
if("AEIOUEIOU".Contains(ch)) {
    letterType = "Vowel";
}

// Print the result
Console.WriteLine("The character " + ch + " is a " + letterType);

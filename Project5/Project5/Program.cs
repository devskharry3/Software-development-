int? intValue = null; // Use int? to make it nullable
float? floatValue = 7.5f; // Use float? to make it nullable
string stringValue = null;
int defaultValue = 10;
float defaultFloatValue = 3.14f;
string defaultStringValue = "Hello";

// Task 1: Use the null-coalescing operator to assign a default value of 10 to the intValue variable if it is null
intValue = intValue ?? defaultValue;

// Task 2: Use the null coalescing assignment operator to update the floatValue variable with a default value of 3.14f if it is null
floatValue ??= defaultFloatValue;

// Task 3: Use the null-coalescing operator to assign the stringValue variable a default value of "Hello" if it is null
stringValue = stringValue ?? defaultStringValue;

// Output the updated values
Console.WriteLine($"intValue: {intValue}"); 
Console.WriteLine($"floatValue: {floatValue}"); 
Console.WriteLine($"stringValue: {stringValue}"); 


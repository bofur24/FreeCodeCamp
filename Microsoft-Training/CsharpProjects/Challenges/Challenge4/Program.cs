/*
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; }}
// convert it back to a string
string new_message = new string(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/



/*
This program will reverse the order of the messge
and print out the amount o appears in the message.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] Message = originalMessage.ToCharArray();

Array.Reverse(Message);

int letterCount = 0;
foreach (char i in Message)
 { 
    if (i == 'o') 
    { 
        letterCount++; 
    }
 }

String newMessage = new string(Message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

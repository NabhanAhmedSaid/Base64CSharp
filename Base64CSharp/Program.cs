

using System.Text;

Console.WriteLine("Welcome to app\n" +
    "1. encoded message \n" +
    "2. decoded message \n");
int input = Int32.Parse(Console.ReadLine());

if (input ==1)
{
    Console.WriteLine("Enter your message");
    var message = Console.ReadLine();
    var messageBytes = Encoding.UTF8.GetBytes(message);
    var encodedMessage = Convert.ToBase64String(messageBytes);
    Console.WriteLine(encodedMessage);
}
if (input ==2)
{
    Console.WriteLine("Enter the encoded " +
        "Message");
    var encodedMessage = Console.ReadLine();
    var decodedBytes = Convert.FromBase64String(encodedMessage);
    var originalMessage = Encoding.UTF8.GetString(decodedBytes);
    Console.WriteLine(originalMessage);
}
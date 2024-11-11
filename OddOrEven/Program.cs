// Palume kasutajal sisestada numbri.
Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());
// Kontrollime kas kasutaja sisestatud arv on paaris või paaritu ja anname vastava tagasiside.
int result = userNum % 2;
Console.WriteLine(result);
if (result != 0) // != on eitus
{ Console.WriteLine("User number is odd."); }
else
{ Console.WriteLine("User number is even."); }

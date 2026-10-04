/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
Console.Write("Enter IP: ");
string ipv4Input = Console.ReadLine()??"";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

ValidateLength();
ValidateZeroes();
ValidateRange();

if (validLength && validZeroes && validRange)
{
    Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}





void ValidateLength() 
{
    
}
void ValidateZeroes() { }
void ValidateRange() { }

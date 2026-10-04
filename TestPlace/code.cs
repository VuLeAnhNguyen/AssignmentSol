string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    DisplayEmail(i, corporate);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    DisplayEmail(i, external, externalDomain);
}

void DisplayEmail(int i , string[,] corp, string domain = "contoso.com" )
{
    string email = (corp[i,0].Substring(0,2) + corp[i,1] ).ToLower() +"@"+ domain;
    Console.WriteLine(email);
}
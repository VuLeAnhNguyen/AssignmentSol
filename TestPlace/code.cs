string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};


PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);
void RandomizeAnimals()
{
    Random rand = new();
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = rand.Next(i, pettingZoo.Length);
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }
}
string[,] AssignGroup(int groups =6)
{
    string[,] result = new string[groups, pettingZoo.Length / groups];
    int s = 0;
    for (int i = 0; i < groups; i++)
    {
        for (int j=0; j<pettingZoo.Length/groups; j++)
        {
            result[i, j] = pettingZoo[s++];
        }
    }
    return result;
}
void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}
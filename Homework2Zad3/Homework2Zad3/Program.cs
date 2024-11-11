int doorNum = 0;

Console.Write("How many doors would you like?: ");

try
{
    doorNum = int.Parse(Console.ReadLine());
}
catch (FormatException) 
{
    Console.WriteLine("Thats not a number!");
    return;
}

for (int i = 1; i <= doorNum; i++)
{
    Console.Write("            " +
        "___________\r\n           " +
        "|  _______  |\r\n           " +
       $"| |   {i}   | |\r\n           " +
        "| |       | |\r\n           " +
        "| |_______| |\r\n           " +
        "|  ___ ___()|\r\n           " +
        "| |   |   | |\r\n           " +
        "| |   |   | |\r\n           " +
        "| |   |   | |\r\n           " +
        "| |   |   | |\r\n           " +
        "| |___|___| |\r\n          " +
        " |___________|\n");
}

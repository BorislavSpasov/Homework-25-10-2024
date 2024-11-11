int nCols, nRows, col, row;

nCols = int.Parse(Console.ReadLine());
if (!(nCols >= 1 && nCols <= 1000))
{
    Console.WriteLine("The number of columns must be >= 1 and <= 1000");
    return;
}
nRows = int.Parse(Console.ReadLine());
if (!(nRows >= 1 && nRows <= 1000))
{
    Console.WriteLine("The number of rows must be >= 1 and <= 1000");
    return;
}
col = int.Parse(Console.ReadLine());
if (!(col >= 1 && col <= nCols))
{
    Console.WriteLine($"The number of the column you are sitting at must be >= 1 and <= {nCols}");
    return;
}
row = int.Parse(Console.ReadLine());
if (!(row >= 1 && row <= nRows))
{
    Console.WriteLine($"The number of the row you are sitting at must be >= 1 and <= {nRows}");
    return;
}

nCols = nCols - col + 1;
nRows -= row;

int peopleDisturbed = nRows * nCols;

Console.WriteLine($"People that you will potentially disturb: {peopleDisturbed}");
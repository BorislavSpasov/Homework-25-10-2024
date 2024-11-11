string dna = Console.ReadLine();

char[] dnaCharArray = dna.ToCharArray();
foreach (char rna in dnaCharArray)
{
    Char rnaUpper = Char.ToUpper(rna);
    if (rnaUpper == 'G') Console.Write("C");
    else if (rnaUpper == 'C') Console.Write("G");
    else if (rnaUpper == 'T') Console.Write("A");
    else if (rnaUpper == 'A') Console.Write("U");
}
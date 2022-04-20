// See https://aka.ms/new-console-template for more information
Console.Title = "CSV to SQL Insert Tool";
Console.WriteLine("CSV to SQL Insert Tool\n");
string filePath;

if (args.Length<1 || (filePath = string.Join(" ", args)) == "help" || (filePath) == "-h")
{
    Console.WriteLine(
        "CSV to SQL Insert Tool\n" +
        "By: Brendan McShane (https://github.com/bman46)\n\n" +
        "Usage:\n" +
        "CSV2SQLInsert.exe (path to CSV file)\n" +
        "Note that the output will include title row.\n\n" +
        "Output Format:\n" +
        "('title1','title2'),\n" +
        "('cell1row1','cell2row1'),\n" +
        "('cell1row2','cell2row2');"
    );
    return;
}

using (var reader = new StreamReader(filePath))
{
    string final = "";
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        final += "(";
        String[] fields = line.Split(',');
        foreach(string field in fields)
        {
            final += "'" + field + "',";
        }
        final=final.TrimEnd(',');
        final += "),\n";
    }
    final=final.TrimEnd(',', '\n');
    final += ";";
    Console.WriteLine("Output:\n");
    Console.WriteLine(final);
}
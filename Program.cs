Console.WriteLine("Enter the size : ");
string? n = Console.ReadLine();
int num = int.Parse(n);
string s = "";
for(int i=0;i<num;i++)
{
    for(int k=0;k<num-i;k++)
    {
        s += " ";
    }

    for(int j=0;j<=2*i;j++)
    {
        s += "*";
    }
    s += "\n";
}
for(int i=num;i>=0;i--)
{
    for(int k=num-i;k>0;k--)
    {
        s += " ";
    }

    for(int j=0;j<=2*i;j++)
    {
        s += "*";
    }
    s += "\n";
}
Console.WriteLine(s);
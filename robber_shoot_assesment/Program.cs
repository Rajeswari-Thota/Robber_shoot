Console.WriteLine("Enter No of robbers: ");
int n = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter the robber with whom sam will start shooting: ");
int S = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter the gap between robbers: ");
int gap = Convert.ToInt16(Console.ReadLine());

int[] robbers = new int[n];
int Index = S - 1;
int ShotsCompleted = 0;

for (int i = 0; i < n; i++)
{
    robbers[i] = i + 1;
}


while (n != 0)
{
    if (Index >= n)
    {
        Index = Index % n;
    }

    Console.WriteLine($"Target = {robbers[Index]} , {++ShotsCompleted} shots completed");

    for (int i = Index; i < n - 1; i++)
    {
        robbers[i] = robbers[i + 1];
    }
    n--;
    Index += gap;
}

Console.WriteLine(ShotsCompleted + " shots taken");



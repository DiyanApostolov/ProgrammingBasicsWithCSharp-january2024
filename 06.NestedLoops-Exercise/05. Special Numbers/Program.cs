int n = int.Parse(Console.ReadLine());

for (int j = 1; j <=9; j++)
{
    for (int l = 1; l <= 9; l++)
    {
        for (int k = 1; k <= 9; k++)
        {
            for (int i = 1; i <= 9; i++)
            {
                if (n%j == 0 && 
                    n%l == 0 && 
                    n%k == 0 && 
                    n%i == 0)
                    Console.Write($"{j}{l}{k}{i} ");
            }
        }
    }
}


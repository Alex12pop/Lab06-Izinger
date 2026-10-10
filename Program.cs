// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
int n = 1;
while (n <= 5)
{
    Console.WriteLine(n);
    n++;
}
int answer;
do
{
    Console.Write("Введите число больше 0: ");
    answer = Convert.ToInt32(Console.ReadLine());
}
while (answer <= 0);
for (int i = 1; i <= 10; i++) 
{
    if (i == 3) continue;
    if (i == 7) break;
    Console.WriteLine(i);
}

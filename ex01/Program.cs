int Degree(int numb1, int numb2)
{
    int result = 1;
    for (int i = 0; i < numb2; i++) result *= numb1;
    return result;
}
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Your number is: " + Degree(num1, num2));
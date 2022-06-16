//Задание 4
//Пользователь /*вводит шестизначное число.*/ После чего 
//пользователь вводит номера разрядов для обмена цифр. 
//Например, если пользователь ввёл один и шесть — это 
//значит, что надо обменять местами первую и шестую 
//цифры.
//Число 723895 должно превратиться в 523897.
//Если пользователь ввел не шестизначное число тре-
//буется вывести сообщение об ошибке.

int k;
do
{
    Console.WriteLine("Enter a six-digit number.");
    string numS = Console.ReadLine();
    if (numS.Length != 6)
    {
        Console.WriteLine("Errore - not six-digit number.");
    }
    else
    {
        Console.WriteLine("Enter first number digit.");
        int d1 = int.Parse(Console.ReadLine());
        d1 -= 1;
        Console.WriteLine("Enter first second digit.");
        int d2 = int.Parse(Console.ReadLine());
        d2 -= 1;
        char[] numC = numS.ToCharArray();
        var temp = numC[d1];
        numC[d1] = numC[d2];
        numC[d2] = temp;
        numS = new string(numC);
        int num = Convert.ToInt32(numS);
        Console.WriteLine(num);
    }
    Console.WriteLine("Input key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;
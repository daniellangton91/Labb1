// See https://aka.ms/new-console-template for more information


int[] numbers = new int[] { 1, 2, 3, 4, 5 };
int sum = 0;

void subtractNumbers(int[] numbers)
{
   
    foreach (int number in numbers)
    {
        int tmp = number;
        sum = sum - tmp;
    }

    Console.WriteLine(sum);
}

subtractNumbers(numbers);
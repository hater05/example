﻿// вид 1
void Method1()
{
    Console.WriteLine("a");
}
// Method1();




// вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
    Console.WriteLine(msg);
    i++;
   }
}
// Method21("текст", count: 4);




// вид3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);


// вид4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }


string Method4(int count, string text)
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}


// string res = Method4(10, "a");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



string text = "– Я думаю, – сказал князь, улыбаясь, – что," 
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// kjhb

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    
    return result;
}

// string newtext = Replace(text, ' ', '|');
// Console.WriteLine(newtext); 

// Console.WriteLine();

// newtext = Replace(text, 'к', 'К');
// Console.WriteLine(newtext); 

// Console.WriteLine();

// newtext = Replace(text, 'с', 'С');
// Console.WriteLine(newtext); 




int[] arr = { 1, 4, 6, 2, 6, 3, 6, 8 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
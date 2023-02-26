string[] StrToArray(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    string[] num = new string[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        num[index] = Convert.ToString(temp);
        index++;
    }
    return num;
}

void Print(string[] arr)
{
    System.Console.WriteLine("[" + string.Join(" ", arr) + "]");
}

string[] ArrayOfStrWith3Elem(string[] input)
{
    string[] arr = new string[input.Length];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            arr[index] = input[i];
            index++;
        }
        else
        {
            index++;
        }
    }
    return arr;
}

Console.Write("Введите слова через запятую без пробела: ");
string[] firstArray = StrToArray(Console.ReadLine());
Print(firstArray);
string[] finalArray = ArrayOfStrWith3Elem(firstArray);
Print(finalArray);

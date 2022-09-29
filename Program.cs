string[] arrOne =  {"hello", "2", "world", ":>)"};
int countFirst = CountStringLessThreeChar(arrOne);
string[] resultOne =  FillResultArray(arrOne,countFirst);


string[] arrTwo = {"1234", "1567", "-2", "computer sclence"};
int countSecond  = CountStringLessThreeChar(arrTwo);
string[] resultTwo = FillResultArray(arrTwo,countSecond);


string[] arrThird = {"Russia", "Denmark", "Kazan"};
int countThird = CountStringLessThreeChar(arrThird);
string[] resultThird = FillResultArray(arrThird, countThird);

void PrintArr(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int CountStringLessThreeChar(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] FillResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

PrintArr(resultOne);
PrintArr(resultTwo);
PrintArr(resultThird);
// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
 
// Создаем метод для вывода на печать массива строк

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
	{
        Console.Write(array[i] + " ");
	}	
    Console.WriteLine("");
}

// Создаем метод для непосредственной реализации задачи

string[] SampleArray(string[] arrayInput)   // В качестве аргумента принимаем массив, который нужно отсортировать.
                                            // Вопрос о происхождении массива данным методом не рассматривается.
{
    int len = arrayInput.Length; // Определяем длину массива 
    int amountValid = 0; // вводим счетчик элементов, соответствующих условиям выборки
    for (int i = 0; i <= (len-1); i++)
    {
        if(arrayInput[i].Length <= 3) amountValid +=1;  // Проверка соответствию условию выборки
                                                        // и подсчет элементов, удовлетворяющих условию
    }

    string[] arrayResult = new string[amountValid]; //Создание нового массива для элементов,
                                                    // попадающих в выборку
    int stopIndex = 0;  // Переменная, позволяющая двигаться по новому массиву и завершающая работу
                        // программы сразу по его заполнению
    for (int i = 0; i <= (len-1); i++)
    {
        if(stopIndex < amountValid) //Проверяем, все ли элементы выборки перенесены в новый массив
        {
            if(arrayInput[i].Length <= 3)
            {
                arrayResult[stopIndex] = arrayInput[i];
                stopIndex +=1;
            }
        }
        else break; // Досрочное прерывание программы в случае переноса в итоговый массив всех элементов,
                    // удовлетворяющих условию.
    }
    return arrayResult;
}

// Тестирование программы
string[] arrayInput = {"Russia", "Denmark", "Kazan"};
PrintArray(arrayInput);
PrintArray(SampleArray(arrayInput));

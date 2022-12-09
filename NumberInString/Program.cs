//«Подчитать количество чисел в строке,
//найти сумму и вставить после каждой
//цифры ее дополнение до 10»

string test = "круто1 7вау ог2онь протокол5";//Тестовая строка
string input = test;

int countDigit = 0;//Счетчик цифр
//Перебираем строку по символьно
for (int i = 0; i < input.Length; i++)
{
	//Если символ цифра
	if (char.IsDigit(input[i]))
	{
		countDigit++;
		//Парсим символ к int
		int digit = int.Parse(input[i].ToString());
		//Встовляем "дополнение до 10" в следующую позицию
		input = input.Insert(i + 1, (10 - digit).ToString());
		i++;//Прибовляем индекс символа, чтобы цикл перескочил добавленную цифру
	}
}

Console.WriteLine("Строка: {0}\nКоличество цифр {1}",input, countDigit);
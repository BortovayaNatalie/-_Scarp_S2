<b>Задача : </b>

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

<b>Описание алгоритма решения: </b>

Вводим функции для проверки строки, с ограничением количества знаков <= 3. Затем функцию парсинга списка, используя функцию для проверки строки. Вводим функцию, убирающую лишний символ новой строки из строки, его содержащей.

Затем вводим функцию Main, которая сначала проверяет наличие введенных на старте выполнения алгоритма аргументов. Если аргументы введены на старте, то копируем их в массив, а затем проводится их парсинг, строки форматируются и подаются на вывод. Если аргументы на старте выполнения алгоритма не введены, то проводится запрос ввода строк. В конце ввода предлагается ввести пустую строку. Считываем ввод, убираем символ пустой строки, проводим парсинг строк, форматирование вывода. 

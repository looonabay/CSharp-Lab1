# CSharp-Lab1
# [Аббасова] [Айнур] [ИТ-4] Лабораторная №1

# Задание 1. Методы

## Задача 1
### Текст задачи
Дана сигнатура метода: `public double Fraction(double x)`
Необходимо реализовать метод таким образом, чтобы он возвращал только дробную часть числа x.

### Алгоритм решения
Чтобы найти дробную часть числа, сначала нужно убрать из него целую часть с помощью перевода в тип `(int)`. Затем эта целая часть вычитается из исходного числа, и полученная разница возвращается в ответе.

### Тестирование
<img width="167" height="92" alt="image" src="https://github.com/user-attachments/assets/aaab09e3-5e8e-4428-8216-077e2ecbfce0" />
<img width="162" height="91" alt="image" src="https://github.com/user-attachments/assets/ef872f75-2b37-46e1-bcbf-a94d093662f3" />
<img width="181" height="90" alt="image" src="https://github.com/user-attachments/assets/19361541-91c2-439d-b999-503b68cd7eb7" />


## Задача 2 
### Текст задачи
Дана сигнатура метода: `public int CharToNum(char x)`
Метод принимает символ x, который представляет собой один из "0123456789". Необходимо реализовать метод таким образом, чтобы он преобразовывал символ в соответствующее число.

### Алгоритм решения
У каждого символа в компьютере есть свой номер (ASCII-код), и у символа '0' этот номер равен 48. Так как цифры в таблице идут по порядку от 0 до 9, метод вычитает из кода переданного символа номер 48 (код нуля). Полученная разность и будет нужным числом.

### Тестирование
<img width="144" height="85" alt="image" src="https://github.com/user-attachments/assets/6df6bb38-4ffa-469f-87fd-2027b36c0b6a" />
<img width="156" height="91" alt="image" src="https://github.com/user-attachments/assets/d0613c71-ca7d-4323-adb4-dc198b250784" />
<img width="140" height="84" alt="image" src="https://github.com/user-attachments/assets/a1ec9405-650f-4f33-9ad1-d0c8d86124c5" />


## Задача 3 
### Текст задачи
Дана сигнатура метода: `public bool Is2Digits(int x)`
Необходимо реализовать метод таким образом, чтобы он принимал число x и возвращал `true`, если оно двузначное.

### Алгоритм решения
Метод проверяет, входит ли число в границы двузначных чисел: от 10 до 99 для положительных или от -99 до -10 для отрицательных. Если число попадает в один из этих промежутков, метод возвращает `true`.

### Тестирование
<img width="167" height="90" alt="image" src="https://github.com/user-attachments/assets/42575d08-8b9d-4e35-abc3-93c5d17921b7" />
<img width="162" height="88" alt="image" src="https://github.com/user-attachments/assets/4cd7b1cc-fb26-4b53-af9c-8b4c365a6955" />
<img width="153" height="94" alt="image" src="https://github.com/user-attachments/assets/6280886b-d5c9-4973-8158-2562050271ae" />


## Задача 4 
### Текст задачи
Дана сигнатура метода: `public bool IsInRange(int a, int b, int num)`
Метод принимает левую и правую границу (a и b) некоторого числового диапазона. Необходимо реализовать метод таким образом, чтобы он возвращал `true`, если num входит в указанный диапазон (включая границы).

### Алгоритм решения
Так как мы не знаем заранее, какое из чисел `a` или `b` больше, метод проверяет два варианта: лежит ли число между `a` и `b` или же между `b` и `a`. Если хотя бы один вариант подходит, возвращается `true`.

### Тестирование
<img width="179" height="127" alt="image" src="https://github.com/user-attachments/assets/bda14b5f-7c46-462c-bf89-47993862a421" />
<img width="196" height="176" alt="image" src="https://github.com/user-attachments/assets/dbae7c19-aecb-4303-b2e6-dc8d2aa2de53" />
<img width="187" height="180" alt="image" src="https://github.com/user-attachments/assets/90ab523d-c1ce-4c10-b233-a8bdf2cc50b9" />


## Задача 5 
### Текст задачи
Дана сигнатура метода: `public bool IsEqual(int a, int b, int c)`
Необходимо реализовать метод таким образом, чтобы он возвращал `true`, если все три полученных методом числа равны.

### Алгоритм решения
Метод сначала сравнивает первое число со вторым, а затем второе с третьим. Если в обоих случаях числа одинаковые, значит, все три числа равны между собой.

### Тестирование
<img width="193" height="129" alt="image" src="https://github.com/user-attachments/assets/ec88f2c5-87f3-48c1-b530-1ca86a9f4d0f" />
<img width="189" height="137" alt="image" src="https://github.com/user-attachments/assets/0194e8b4-38bc-4a8d-a883-3a4e5adf6273" />
<img width="187" height="136" alt="image" src="https://github.com/user-attachments/assets/b1725bc7-1cab-4411-8291-3a6de9947299" />


# Задание 2. Условия

## Задача 1 
### Текст задачи
Дана сигнатура метода: `public int Abc(int x)`
Необходимо реализовать метод таким образом, чтобы он возвращал модуль числа x.

### Алгоритм решения
С помощью проверки `if` проверяется знак числа. Если число меньше нуля (отрицательное), метод меняет его знак на плюс и возвращает. Если число больше или равно нулю, оно возвращается без изменений.

### Тестирование
<img width="156" height="95" alt="image" src="https://github.com/user-attachments/assets/359588f7-91ee-4879-a8d3-bd75c04ee383" />
<img width="138" height="95" alt="image" src="https://github.com/user-attachments/assets/4f599580-5f9f-4eb3-a91d-deb127548cd9" />
<img width="162" height="93" alt="image" src="https://github.com/user-attachments/assets/f6f8f42b-b6ff-4fe3-9e37-b3730c170b02" />


## Задача 2 
### Текст задачи
Дана сигнатура метода: `public bool Is35(int x)`
Необходимо реализовать метод таким образом, чтобы он возвращал `true`, если число x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то вернуть надо `false`.

### Алгоритм решения
Сначала проверяется главное исключение: если число делится без остатка и на 3, и на 5 одновременно, метод сразу возвращает `false`. В остальных случаях проверяется, делится ли оно хотя бы на одно из этих чисел.

### Тестирование
<img width="163" height="93" alt="image" src="https://github.com/user-attachments/assets/6039a76e-14c2-4008-9248-2eadc4b162f6" />
<img width="171" height="93" alt="image" src="https://github.com/user-attachments/assets/8e30f329-ae9f-40db-97ea-c039d540bcbd" />
<img width="143" height="93" alt="image" src="https://github.com/user-attachments/assets/1acd5c8c-6ac1-4ee6-9f1a-3fae3b3435f1" />


## Задача 3
### Текст задачи
Дана сигнатура метода: `public int Max3(int x, int y, int z)`
Необходимо реализовать метод таким образом, чтобы он возвращал максимальное из трех полученных методом чисел.

### Алгоритм решения
1. За самое большое число сначала принимается первое число.
2. Затем второе число сравнивается с самым большим. Если оно оказывается больше, то запоминается оно.
3. Точно так же сравнивается третье число, и при необходимости значение обновляется.
4. Метод возвращает самое большое из найденных чисел.

### Тестирование
<img width="160" height="134" alt="image" src="https://github.com/user-attachments/assets/a3cf7332-c9b8-44d2-a210-0adb4ff2d2b2" />
<img width="160" height="138" alt="image" src="https://github.com/user-attachments/assets/d3180289-8218-42bb-b8ab-a30eddcde578" />
<img width="164" height="136" alt="image" src="https://github.com/user-attachments/assets/dfbdaae9-d5de-435d-a4e3-dc58f5e533b8" />


## Задача 4 
### Текст задачи
Дана сигнатура метода: `public int Sum2(int x, int y)`
Необходимо реализовать метод таким образом, чтобы он возвращал сумму чисел x и y. Однако, если сумма попадает в диапазон от 10 до 19, то надо вернуть число 20.

### Алгоритм решения
Метод считает сумму двух чисел и проверяет, попадает ли ответ в диапазон от 10 до 19 включительно. Если попадает, то метод возвращает 20, а если нет — обычную посчитанную сумму.

### Тестирование
<img width="187" height="106" alt="image" src="https://github.com/user-attachments/assets/90e2bea6-1eec-4af8-89e8-fea7865503b1" />
<img width="183" height="115" alt="image" src="https://github.com/user-attachments/assets/51f18b52-b252-4558-baf3-5caeddf32ab7" />
<img width="177" height="111" alt="image" src="https://github.com/user-attachments/assets/69590a6d-d279-4e98-866a-0866e0ea818c" />


## Задача 5 
### Текст задачи
Дана сигнатура метода: `public string Day(int x)`
Метод принимает число x, обозначающее день недели. Необходимо реализовать метод с использованием `switch`, чтобы он возвращал название дня недели или "это не день недели".

### Алгоритм решения
Используется переключатель `switch`. Каждой цифре от 1 до 7 подставляется свое название дня недели (от понедельника до воскресенья). Для любого другого числа срабатывает стандартный блок, который возвращает текст "это не день недели".

### Тестирование
<img width="266" height="92" alt="image" src="https://github.com/user-attachments/assets/cc3dfdc6-d0ce-4106-906c-67cc37a44add" />
<img width="267" height="88" alt="image" src="https://github.com/user-attachments/assets/9e688341-2a1a-4ee5-b017-ed7ddca861e7" />
<img width="265" height="93" alt="image" src="https://github.com/user-attachments/assets/56d18318-c4ee-41ab-956c-3795c6f2995a" />



# Задание 3. Циклы

## Задача 1 
### Текст задачи
Дана сигнатура метода: `public string ListNums(int x)`
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в которой будут записаны все числа от 0 до x (включительно).

### Алгоритм решения
Создается пустая строка. Через цикл от 0 до указанного числа каждое текущее значение прибавляется к этой строке вместе с пробелом. В конце убирается лишний пробел в самом хвосте строки.

### Тестирование
<img width="160" height="89" alt="image" src="https://github.com/user-attachments/assets/bd1e4ec8-c431-4efe-b21c-877601c42e53" />
<img width="154" height="91" alt="image" src="https://github.com/user-attachments/assets/a46dd02a-2420-43f5-8c93-412a708b137b" />
<img width="161" height="95" alt="image" src="https://github.com/user-attachments/assets/86590b7c-31d7-44b3-a1b6-4e2db54a221a" />


## Задача 2 
### Текст задачи
Дана сигнатура метода: `public string Chet(int x)`
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в которой будут записаны все четные числа от 0 до x (включительно) без использования `if`.

### Алгоритм решения
Чтобы не использовать проверки через `if`, цикл начинает считать с 0 и на каждом шаге прибавляет к счетчику сразу по 2. Каждое полученное четное число записывается в строку через пробел, пока не дойдет до нужного предела.

### Тестирование
<img width="141" height="90" alt="image" src="https://github.com/user-attachments/assets/76826240-e6c9-4eb8-b9b3-6430e0250dab" />
<img width="134" height="95" alt="image" src="https://github.com/user-attachments/assets/356341db-be61-4f62-a0a5-05ec2862844e" />
<img width="130" height="69" alt="image" src="https://github.com/user-attachments/assets/97a4ec2d-26f9-4525-8370-5218959d7aed" />


## Задача 3 
### Текст задачи
Дана сигнатура метода: `public int NumLen(long x)`
Необходимо реализовать метод таким образом, чтобы он возвращал количество знаков в числе x.

### Алгоритм решения
Создается счетчик цифр, равный 0. В цикле число делится на 10 (это каждый раз убирает последнюю цифру), а счетчик увеличивается на 1. Цикл работает, пока число не станет равным нулю, после чего возвращается итоговое количество цифр.

### Тестирование
<img width="156" height="96" alt="image" src="https://github.com/user-attachments/assets/f1140f15-98b5-4535-b135-2c3645ff4717" />
<img width="165" height="92" alt="image" src="https://github.com/user-attachments/assets/154abfd3-94f9-4d20-955e-9059bac9fd4e" />
<img width="171" height="93" alt="image" src="https://github.com/user-attachments/assets/884eb886-dcf8-4c6a-83f7-6b8a995d2005" />


## Задача 4 
### Текст задачи
Дана сигнатура метода: `public void Square(int x)`
Необходимо реализовать метод таким образом, чтобы он выводил на экран квадрат из символов ‘*’ размером x на x.

### Алгоритм решения
Используются два цикла: внешний цикл считает количество строк, а внутренний — выводит в одну строку нужные звездочки одну за другой без перехода на новую строчку. Перевод на новую строку делается только после того, как вся текущая строка заполнена.

### Тестирование
<img width="271" height="203" alt="image" src="https://github.com/user-attachments/assets/5a325f78-37b1-485e-9262-86bad22cce0e" />
<img width="222" height="135" alt="image" src="https://github.com/user-attachments/assets/264dfced-e4db-4b21-9a78-3c15b933c5ca" />
<img width="219" height="80" alt="image" src="https://github.com/user-attachments/assets/a8992ffd-3e16-4cc8-ab58-2431de406f61" />


## Задача 5 
### Текст задачи
Дана сигнатура метода: `public void RightTriangle(int x)`
Необходимо реализовать метод таким образом, чтобы он выводил на экран треугольник из символов ‘*’ высотой x, выровненный по правому краю.

### Алгоритм решения
Чтобы треугольник был сдвинут вправо, в начале каждой строки печатаются пробелы, а затем звездочки:
1. Внешний цикл отсчитывает номер строки.
2. Первый внутренний цикл печатает пробелы для отступа слева.
3. Второй внутренний цикл сразу после пробелов печатает звездочки.
4. После этого делается переход на новую строчку.

### Тестирование
<img width="237" height="155" alt="image" src="https://github.com/user-attachments/assets/740d9885-523d-4552-873e-7140fd8188af" />
<img width="235" height="182" alt="image" src="https://github.com/user-attachments/assets/fd8d158b-4d9d-445f-8e64-04f6b80d22bf" />
<img width="256" height="93" alt="image" src="https://github.com/user-attachments/assets/ed5a5e9e-e400-413a-8aea-676ae7126b48" />



# Задание 4. Массивы

## Задача 1 
### Текст задачи
Дана сигнатура метода: `public int FindFirst(int[] arr, int x)`
Необходимо реализовать метод таким образом, чтобы он возвращал индекс первого вхождения числа x в массив arr (или -1, если элемента нет).

### Алгоритм решения
Запускается цикл, который идет по массиву от начала к концу. Как только находится элемент, равный искомому числу, метод сразу возвращает его номер (индекс). Если цикл закончился, а число так и не нашли, возвращается -1.

### Тестирование
<img width="237" height="155" alt="image" src="https://github.com/user-attachments/assets/25f6f583-121c-4673-b16b-365ba1b24801" />
<img width="258" height="223" alt="image" src="https://github.com/user-attachments/assets/75c4f70a-f081-4f8c-ac47-446d27f4c063" />
<img width="231" height="224" alt="image" src="https://github.com/user-attachments/assets/17b6939d-7fa5-4521-a298-2ea0b70478c9" />


## Задача 2 
### Текст задачи
Дана сигнатура метода: `public int MaxAbs(int[] arr)`
Необходимо реализовать метод таким образом, чтобы он возвращал наибольшее по модулю значение массива arr.

### Алгоритм решения
1. За начальное самое большое значение берется самый первый элемент массива.
2. В цикле проверяются все остальные элементы массива.
3. Модуль каждого следующего элемента сравнивается с модулем текущего максимума.
4. Если новый элемент по модулю оказывается больше, метод запоминает именно его (сохраняя его настоящий знак).
5. В конце работы цикла возвращается найденный элемент.

### Тестирование
<img width="246" height="179" alt="image" src="https://github.com/user-attachments/assets/8941942c-4e09-42c2-a2f5-e89667cc6784" />
<img width="238" height="176" alt="image" src="https://github.com/user-attachments/assets/e5c15545-1984-4131-9710-b3382d2680dd" />
<img width="230" height="177" alt="image" src="https://github.com/user-attachments/assets/b775d4c8-d905-4d1c-b8ff-8b4e31a49331" />


## Задача 3 
### Текст задачи
Дана сигнатура метода: `public int[] Add(int[] arr, int[] ins, int pos)`
Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, состоящий из элементов arr, в позицию pos которого вставлены элементы массива ins.

### Алгоритм решения
1. Создается новый массив, размер которого равен сумме длин двух исходных массивов.
2. Первым циклом скопируются элементы из первого массива до места вставки.
3. Вторым циклом на место вставки записываются все элементы из второго массива.
4. Третьим циклом дописываются оставшиеся элементы первого массива в самый конец.
5. Готовый массив возвращается в качестве ответа.

### Тестирование
<img width="262" height="333" alt="image" src="https://github.com/user-attachments/assets/20b79d8b-e02b-43ff-8c21-00580dd39314" />
<img width="266" height="312" alt="image" src="https://github.com/user-attachments/assets/974e2ee1-45a7-4b80-86e6-82644c4ac0f7" />
<img width="279" height="372" alt="image" src="https://github.com/user-attachments/assets/31ff5dd5-1384-4b4f-aaba-0b580864f67e" />


## Задача 4 
### Текст задачи
Дана сигнатура метода: `public int[] ReverseBack(int[] arr)`
Необходимо реализовать метод таким образом, чтобы он возвращал новый массив, в котором значения массива arr записаны задом наперед.

### Алгоритм решения
Создается новый массив такого же размера. В цикле элементы копируются из исходного массива в новый задом наперед: элемент с самого конца старого массива переносится на первое место в новом массиве, и так по порядку до самого конца.

### Тестирование
<img width="255" height="179" alt="image" src="https://github.com/user-attachments/assets/e58522f4-b3d5-47f8-aac1-aa3a82199065" />
<img width="259" height="137" alt="image" src="https://github.com/user-attachments/assets/dafefc26-9e9f-4411-8d90-e7044815bfe3" />
<img width="232" height="199" alt="image" src="https://github.com/user-attachments/assets/29fb307a-9a58-49c1-89f8-9086ec1c3340" />


## Задача 5 
### Текст задачи
Дана сигнатура метода: `public int[] FindAll(int[] arr, int x)`
Необходимо реализовать метод таким образом, чтобы он возвращал новый массив со всеми индексами вхождений числа x в массив arr.

### Алгоритм решения
Решение выполняется в два простых шага:
1. За первый проход по массиву считается, сколько раз в нем встречается нужное число. Это необходимо, чтобы узнать точный размер для нового массива.
2. Создается новый массив нужного размера, и за второй проход в него записываются номера (индексы) всех найденных элементов.
3. Заполненный массив номеров возвращается.

### Тестирование
<img width="241" height="291" alt="image" src="https://github.com/user-attachments/assets/f6a26d54-c1f8-4742-837d-69af868f5024" />
<img width="253" height="223" alt="image" src="https://github.com/user-attachments/assets/01030e06-808d-45e9-842d-ebfe358f6d07" />
<img width="235" height="214" alt="image" src="https://github.com/user-attachments/assets/43576743-8d14-452f-9389-2d3cfeca262b" />


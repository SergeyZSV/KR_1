# Решение задачи

## Условие 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### _Примеры_ 
- ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
- ["1234", "1567", "-2", "computer science"] -> ["-2"]
- ["Russia", "Denmark", "Kazan"] -> [ ]

## Решение
1. __Введение переменных__

Вводятся переменные:

- *lenFirstArray* - длина данного по условию массива
- *lenResultArray* - длина результирующего массива (изначально равна 0)
- *index* - индекс элементов первоначально массива (изначально 0)
- *jndex* - индекс элементов результирующего массива (изначально 0)

2. __Введение массива__

Вводится данный по условию задачи массив:

- *firstArray*

3. __Определяется длина результирующего массива__

- *ResultArrayLenght* - метод для определения длины результирующего массива

Значение длины массива присваивается переменной *lenResultArray*.

4. __Введение результирующего массива__

- *resultArray* - результирующий массив, длина которого равна *lenResultArray* (найдена методом *ResultArrayLenght*)

5. __Заполнение результирующего массива__

- *FillResultArray* - метод для заполнения результирующего массива элементами первоначального, которые подходят под условие задачи

6. __Вывод массивов__

- *PrintArray* - метод для вывода массива

Выводим первоначальный и результирующий массивы.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishLearning
{
    class Interface
    {

        public void StartMenu()
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Эта программа поможет тебе расширить свой словарный запас английского языка.");
            Console.WriteLine();
            Console.WriteLine("Нажми любую клавишу для продолжения.");
            Console.ReadKey();
        }

        public int MainMenu(Library lib)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Сейчас ты знаешь {lib.Count()} слов(а).");
                Console.WriteLine();
                Console.WriteLine("1. Добавить новое слово");
                Console.WriteLine("2. Повторение");
                Console.WriteLine("3. Посмотреть все твои слова");
                Console.WriteLine("4. Выход");
                Console.WriteLine();
                Console.WriteLine("Введи цифру соответствующую пункту меню:");

                var inpup = Console.ReadLine();

                if (inpup.Equals("1"))
                {
                    return 1;
                }
                else if (inpup.Equals("2"))
                {
                    return 2;
                }
                else if (inpup.Equals("3"))
                {
                    return 3;
                }
                else if (inpup.Equals("4"))
                {
                    return 4;
                }
            }
        }

        public Library NewWordMenu(Library lib)
        {
            var words = new List<Word>();
            var inputTest = true;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Отмена");
                Console.WriteLine("Введи слово на английском:");
                var inputName = Console.ReadLine();
                if (inputName.Equals("1")) return lib;
                Console.WriteLine("Введи его перевод:");
                var inputValue = Console.ReadLine();
                if (inputValue.Equals("1")) return lib;

                var word = new Word(WordFormatter.ToStandart(inputName), WordFormatter.ToStandart(inputValue));
                lib.Add(word);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Слово добавлено!");
                    Console.WriteLine("1. Вернуться в главное меню");
                    Console.WriteLine("2. Добавить еще");

                    var input = Console.ReadLine();
                    inputTest = true;
                    if (input.Equals("1")) return lib;
                    if (input.Equals("2")) inputTest = false;
                }
                while (inputTest == true);
            }

        }
        public void ConsolidationMenu(Library lib)
        {
            var counts = 0;

            Console.Clear();
            Console.WriteLine("Программа будет показывать тебе английские слова.");
            Console.WriteLine("Твоя задача - перевести их на русский.");
            Console.WriteLine("Нажми любую клавишу, чтобы начать:");
            Console.ReadKey();

            for (int i = 1; i <= lib.Count(); i++)
            {
                Console.Clear();
                Console.WriteLine($"Переведи слово: {lib[i].Name}.");
                var value = Console.ReadLine();
                value = WordFormatter.ToStandart(value);
                if (value.Equals(lib[i].Value))
                {
                    counts++;
                    Console.Clear();
                    Console.WriteLine("Правильно!");
                    Console.WriteLine(lib[i]);
                    Console.WriteLine();
                    Console.WriteLine("Нажми любую клавишу, для продолжения");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Не правильно!");
                    Console.WriteLine("Нажми любую клавишу, для продолжения");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine($"Отлично! Ты правильно перевел {counts} слов(а) из {lib.Count()}!");
            Console.WriteLine("Нажми любую клавишу, для возврата в главное меню.");
            Console.ReadKey();
        }
        public Library LibraryMenu(Library lib)
        {
            var inputTest = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Вернуться в главное меню");
                Console.WriteLine("2. Удалить слово");
                Console.WriteLine();

                for (int i = 0; i <= lib.Count(); i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine($"   {lib[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"{i}. {lib[i]}");
                    }
                }

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1": { return lib; }


                    case "2": { lib = DeleteMenu(lib); break; }
                    default: { break; }
                }
            }
            while (inputTest == true);
            return lib;
        }
        public Library DeleteMenu(Library lib)
        {
            var inputTest = false;
            var buffer = 0;

            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("0. Отмена");
                    Console.WriteLine("Введи номер слова:");
                    var inputIndex = Console.ReadLine();

                    if (inputIndex.Equals("0")) return lib;
                    else if (Int32.TryParse(inputIndex, out buffer))
                    {
                        lib.Remove(lib[buffer]);
                        inputTest = true;
                    }
                }
                while (inputTest == false);


                Console.Clear();
                Console.WriteLine("Слово удалено!");
                Console.WriteLine("Нажмите любую клавишу для возврата.");
                Console.ReadKey();
                return lib;
            }

        }


    }
}


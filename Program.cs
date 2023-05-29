using System;
using System.Collections.Generic;

namespace AgeSort
{
    // Person構造体の定義
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            // 入力を受け取るループ
            while (true)
            {
                Console.Write("名前と年齢をカンマで区切って入力してください。（Ctrl+Zで終了）: ");
                string input = Console.ReadLine();

                if (input == null)
                {
                    break;
                }

                string[] inputArray = input.Split(',');
                if (inputArray.Length != 2)
                {
                    Console.WriteLine("無効な入力です。名前と年齢をカンマで区切って入力してください。");
                    continue;
                }

                string name = inputArray[0].Trim();
                int age;
                if (!int.TryParse(inputArray[1].Trim(), out age))
                {
                    Console.WriteLine("年齢は数値で入力してください。");
                    continue;
                }

                Person person = new Person { Name = name, Age = age };
                people.Add(person);
            }

            // 年齢でソート
            people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));

            // 結果を表示
            Console.WriteLine("\n年齢順にソートされた結果:");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Age:D2} {person.Name}");
            }
        }
    }
}

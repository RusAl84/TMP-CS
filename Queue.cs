using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMP_CS
{
    internal class Queue
    {
        private List<int> queue;

        public Queue()
        {
            queue = new List<int>();
        }

        public int Count()
        {
            return queue.Count;
        }

        // Добавляем в конец
        public void Push(int newValue)
        {
            queue.Add(newValue);
        }

        // Извлекаем из начала
        public int Pop()
        {
            int result = queue[0];
            queue.RemoveAt(0);

            return result;
        }

        // Показываем значение первого элемента
        public int Show()
        {
            return queue[0];
        }

        // Получение элемента очереди по i-ой позиции
        public int Get(int pos)
        {
            for (int i = 0; i < pos; ++i)
                Push(Pop());

            int result = Show();

            for (int i = pos; i < queue.Count; ++i)
                Push(Pop());

            return result;
        }

        // Установка нового элемента на i-ую позицию
        public void Set(int pos, int newValue)
        {
            for (int i = 0; i < pos; ++i)
                Push(Pop());

            queue[0] = newValue;

            for (int i = pos; i < queue.Count; ++i)
                Push(Pop());
        }

        // Отображение очереди в консоли
        public void Print()
        {
            foreach (int item in queue)
                Console.WriteLine(item);
            Console.WriteLine("---------");
        }
    }
}

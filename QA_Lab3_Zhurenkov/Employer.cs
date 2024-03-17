using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3_Zhurenkov
{   /*!
     \brief Класс Работа для работы с суммой зарплаты и коэффициентом квалификации
     */
    class Employer
    {
        private string name;
        public string Name { get { return name; } }
        private Work work1 = new Work();
        private Work work2 = new Work();
        private Work work3 = new Work();

        /*! Инициализация всех полей
        \param work1 Инициализация Работы 1
        \param work2 Инициализация Работы 2
        \param work3 Инициализация Работы 3
         */
        public void Init(string name1, Work work12, Work work23, Work work34)
        {
            name = name1;
            work1 = work12;
            work2 = work23;
            work3 = work34;
        }
        /*! Функция ввода информации про работодателя и работы с клавиатуры
         */
        public void Read()
        {
            Console.WriteLine("Введите имя работодателя: ");
            name = Console.ReadLine();
            work1.Read();
            work2.Read();
            work3.Read();
        }
        /*! Функция вывода на экран всех полей работ
         */
        public void Display()
        {
            Console.WriteLine($"Работодатель: {name}");
            Console.WriteLine("Работа 1: ");
            work1.Display();
            Console.WriteLine("Работа 2: ");
            work2.Display();
            Console.WriteLine("Работа 3: ");
            work3.Display();
        }

        /*! Метод сложения всех ЗП. Складывает 3 работы
         * \return Общая сумма выплат всех ЗП
         * \code
         *  return work1.CalculatePayment() + work2.CalculatePayment() + work3.CalculatePayment()
         * \endcode
         */
        public double CalculateTotalPayments()
        {
            return work1.CalculatePayment() + work2.CalculatePayment() + work3.CalculatePayment();
        }

        /*! Метод вычисления самой оплачиваемой работы из 3 работ.
         * \return Самая высоко оплачиваемая работа
         * \code
         *  if (payment2 > payment1 && payment2 > payment3)
            {
                mostExpensive = work2;
            }
            else if (payment3 > payment1 && payment3 > payment2)
            {
                mostExpensive = work3;
            }

            return mostExpensive;
         * \endcode
         */
        public Work MostExpensiveWork()
        {
            Work mostExpensive = work1;
            double payment1 = work1.CalculatePayment();
            double payment2 = work2.CalculatePayment();
            double payment3 = work3.CalculatePayment();

            if (payment2 > payment1 && payment2 > payment3)
            {
                mostExpensive = work2;
            }
            else if (payment3 > payment1 && payment3 > payment2)
            {
                mostExpensive = work3;
            }

            return mostExpensive;
        }
    }
}

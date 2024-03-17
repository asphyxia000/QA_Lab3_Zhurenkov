using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3_Zhurenkov
{
    /*!
     \brief Класс Работа для работы с суммой зарплаты и коэффициентом квалификации
     */
    class Work
    {
        private double salary;
        private double k = 1.1;
        /*!
         \brief Инициализация всех полей
        \param salary Заработная плата
        \param k Коэффициент квалификации
         */
        public void Init(double salary1, double k1)
        {
            salary = salary1;
            k = k1;
        }
        /*! Функция ввода с клавиатуры
         */
        public void Read()
        {
            Console.WriteLine("Введите заработную плату: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        /*! Функция вывода на экран всех полей ЗП
         */
        public void Display()
        {
            Console.WriteLine($"Заработная плата: {salary}, Коэффициент квалификации: {k}");
        }
        /*!
         * \return Сумма выплаты 
         * \code
         *  return salary*k
         * \endcode
         */
        public double CalculatePayment()
        {
            return salary * k;
        }
    }
}

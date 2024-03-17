using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Lab3_Zhurenkov
{
    /*!
	\author Zhurenkov D.A.
	\version 1.6
	\date Март 2024 года
	\brief Главный класс, демонстрирующий работу с объектами класса Work,Employer и их методами

     * Картинки для примера работы с Doxygen:
   <p>
    \image{inline} html wallhaven-jxwwe5.png width=300 height=300
    \image{inline} html wallhaven-zyz2lw.png width=300 height=300
        */
    class Program
    {
        
        static void Main(string[] args)
        {
            Employer employer = new Employer();
            Work work1 = new Work();
            Work work2 = new Work();
            Work work3 = new Work();

            Console.WriteLine("Введите детали для Работы 1:");
            work1.Read();

            Console.WriteLine("Введите детали для Работы 2:");
            work2.Read();

            Console.WriteLine("Введите детали для Работы 3:");
            work3.Read();

            Console.WriteLine("Введите имя работодателя: ");
            string employerName = Console.ReadLine();

            employer.Init(employerName, work1, work2, work3);

            employer.Display();

            double totalPayments = employer.CalculateTotalPayments();
            Console.WriteLine($"Общие выплаты для всех сотрудников: {totalPayments}");

            Work mostExpensiveWork = employer.MostExpensiveWork();
            Console.WriteLine("Самая дорогая работа: ");
            mostExpensiveWork.Display();
        }
    }
}


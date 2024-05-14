using System;

class Program
{
    delegate string GetNextDayDelegate();

    static void Main()
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentDayIndex = 0;

        GetNextDayDelegate getNextDay = () =>
        {
            string nextDay = daysOfWeek[currentDayIndex];
            currentDayIndex = (currentDayIndex + 1) % daysOfWeek.Length;
            return nextDay;
        };

        for (int i = 0; i < 7; i++) // Продемонстрируем вызов делегата несколько раз
        {
            string nextDay = getNextDay();
            Console.WriteLine(nextDay);
        }
    }
}

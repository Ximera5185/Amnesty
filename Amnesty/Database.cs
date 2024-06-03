using System;
using System.Collections.Generic;

namespace Amnesty
{
    internal class Database
    {
        private List<Criminal> _criminals = new List<Criminal>();

        public Database() 
        {
            AddCriminalToList();
        }

        public void ShowCriminals() 
        {
            foreach (Criminal criminal in _criminals)
            {
                Console.WriteLine($"{criminal.FullName} {criminal.Сrime}");
            }

            Console.WriteLine();
        }
        
        public void ClearCriminals() 
        {
            string valueCrime = "Антиправительственное";

            for (int i = _criminals.Count -1; i != 0 ; i--)
            {
                if (_criminals[i].Сrime == valueCrime)
                {
                    _criminals.RemoveAt(i);
                }
            }
        }

        private void AddCriminalToList() 
        {
            _criminals.Add(new Criminal("Пупкин Василий Игоревич","Угон"));
            _criminals.Add(new Criminal("Попов Руслан Игоревич", "Антиправительственное"));
            _criminals.Add(new Criminal("Роков Иван Романович", "Антиправительственное"));
            _criminals.Add(new Criminal("Гаврюк Константин Леонидович", "Антиправительственное"));
            _criminals.Add(new Criminal("Старк Вячеслав Игоревич", "Разбой"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomValueGenerator.View;

namespace RandomValueGenerator.Model
{
    public class DataModel : IModelView, IModelController
    {
        private List<IObserverInterface> m_Observers = new List<IObserverInterface>();

        private int m_RandomValue;

        private IDatabaseAdapter m_DataBase = null;

        public DataModel(IDatabaseAdapter dataBase)
        {
            m_DataBase = dataBase;
        }

        public void registerObserver(IObserverInterface observer)
        {
            m_Observers.Add(observer);
        }

        public void removeObserver(IObserverInterface observer)
        {
            m_Observers.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (IObserverInterface o in m_Observers)
            {
                o.update();
            }
        }

        public void RequestGenerateValue()
        {
            Random rnd = new Random();
            
            m_DataBase.SaveRandomValue(rnd.Next(0, 1000));

            notifyObserver();
        }

        public int GetRandomValue()
        {
            return m_DataBase.GetRandomValue();
        }
    }
}

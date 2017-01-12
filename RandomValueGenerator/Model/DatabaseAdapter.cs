using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValueGenerator.Model
{
    public class DatabaseAdapter : IDatabaseAdapter
    {
        int m_DataBasePlaceHolder;

        public DatabaseAdapter()
        {

        }

        public int GetRandomValue()
        {
            // put your Database here
            return m_DataBasePlaceHolder;
        }

        public void SaveRandomValue(int value)
        {
            // put your Database here
            m_DataBasePlaceHolder = value;
        }
    }
}
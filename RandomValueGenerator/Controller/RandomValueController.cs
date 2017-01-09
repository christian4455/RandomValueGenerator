using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomValueGenerator.Model;

namespace RandomValueGenerator.Controller
{
    public class RandomValueController : IController
    {
        private IModelController m_Model;

        public RandomValueController(IModelController model)
        {
            m_Model = model;
        }

        public void RequestGenerateValue()
        {
            m_Model.RequestGenerateValue();
        }
    }
}

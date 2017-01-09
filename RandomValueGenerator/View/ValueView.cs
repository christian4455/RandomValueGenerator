using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RandomValueGenerator.Controller;
using RandomValueGenerator.Model;

namespace RandomValueGenerator.View
{
    public partial class ValueView : Form, IObserverInterface
    {
        private IController m_Controller;
        private IModelView m_Model;

        // TODO maybe we should inject the controller completly with constructor injection
        public ValueView(IModelView modelView, IModelController modelController)
        {
            InitializeComponent();

            m_Model = modelView;

            m_Model.registerObserver(this);

            m_Controller = new RandomValueController(modelController);
        }

        public void update()
        {
            resultText.Text = m_Model.GetRandomValue().ToString();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            m_Controller.RequestGenerateValue();
        }
    }
}

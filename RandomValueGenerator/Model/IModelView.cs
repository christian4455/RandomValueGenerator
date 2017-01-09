using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomValueGenerator.Model
{
    public interface IModelView : IObservableInterface
    {
        int GetRandomValue();
    }
}

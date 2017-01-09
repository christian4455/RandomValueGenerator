using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RandomValueGenerator.View;

namespace RandomValueGenerator.Model
{
    public interface IObservableInterface
    {
        void registerObserver(IObserverInterface observer);
        void removeObserver(IObserverInterface observer);
        void notifyObserver();
    }
}

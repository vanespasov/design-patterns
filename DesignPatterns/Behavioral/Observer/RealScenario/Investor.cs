using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.RealScenario
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor : IObserver
    {
        private string _name;
        private Stock _stock;

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(ISubject subject)
        {
            _stock = subject as Stock;

            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2:C}", _name, _stock.Symbol, _stock.Price);
        }

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}

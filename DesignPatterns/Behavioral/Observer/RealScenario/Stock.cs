using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.RealScenario
{
    public class Stock : ISubject
    {
        private string _symbol;
        private double _price;
        private List<IObserver> _investors = new List<IObserver>();
                
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }        

        public string Symbol
        {
            get { return _symbol; }
        }
                
        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Attach(IObserver investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IObserver investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IObserver investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer.RealScenario
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BO
{
    public abstract class FunctionBuilding : Building
    {
        public List<Action> Actions()
        {
            return new List<Action>();
        }
    }
}

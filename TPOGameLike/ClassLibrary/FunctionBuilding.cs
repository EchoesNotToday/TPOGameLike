using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class FunctionBuilding : Building
    {
        public List<Action> Actions()
        {
            return new List<Action>();
        }
    }
}

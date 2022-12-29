using System;
using System.Collections;
using System.Collections.Generic;

namespace ArtificialIntelligence
{
    public abstract class Formula
    {
        public abstract bool Evaluate();
        public abstract IEnumerable<Variable> Variables();
    }
}

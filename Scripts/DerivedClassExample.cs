using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class DerivedClassExample : AbstractBaseClass
    {
        public override void PerformAction()
        {
            UnityEngine.Debug.Log("PerformAction is implemented in the derived class.");
        }
    }
}

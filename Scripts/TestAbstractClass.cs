using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample obj = new DerivedClassExample();
            obj.PerformAction();
            obj.PrintInfo();
        }
    }
}

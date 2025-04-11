using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        void Start()
        {
            Action log = () => Debug.Log("Hello from Action delegate!");
            log();

            Func<int, int> square = x => x * x;
            Debug.Log("Square: " + square(5));

            Predicate<int> isEven = n => n % 2 == 0;
            Debug.Log("Is 4 even? " + isEven(4));
        }
    }
}

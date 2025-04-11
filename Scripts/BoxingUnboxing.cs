using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        void Start()
        {
            int health = 100;
            object boxed = health;       // boxing
            int unboxed = (int)boxed;    // unboxing
            unboxed += 20;

            Debug.Log("Original: " + health);
            Debug.Log("Boxed: " + boxed);
            Debug.Log("Unboxed and modified: " + unboxed);
        }
    }
}


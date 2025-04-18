using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        void Start()
        {
            SetPosition(new Vector3(0, 1, 0))
                .SetRotation(new Vector3(45, 0, 0))
                .SetScale(new Vector3(2, 2, 2));
        }

        MethodChainingExample SetPosition(Vector3 pos)
        {
            transform.position = pos;
            return this;
        }

        MethodChainingExample SetRotation(Vector3 rot)
        {
            transform.eulerAngles = rot;
            return this;
        }

        MethodChainingExample SetScale(Vector3 scale)
        {
            transform.localScale = scale;
            return this;
        }
    }
}

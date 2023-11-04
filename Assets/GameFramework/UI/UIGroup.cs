using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.UI
{
    public abstract class UIGroup
    {
        string _name;
        int _depth;

        public UIGroup(string name, int depth)
        {
            _name = name;
            _depth = depth;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.UI
{
    public abstract class UIFrom : MonoBehaviour
    {
        private UIFrom _parentFrom;

        public void SetParentPanel(UIFrom u)
        {
            _parentFrom = u;
        }

        public virtual void Init() { }
        public virtual void Open(params object[] arr) { }
        public virtual void Close() { }
        public virtual void OnPause() { }
        public virtual void OnResume() { }
    }
}

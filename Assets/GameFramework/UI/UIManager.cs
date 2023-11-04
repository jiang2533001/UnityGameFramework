using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework.UI
{
    public class UIManager : MonoBehaviour
    {
        const string RESOURCE_PATH = "";

        Dictionary<string, UIFrom> _uiPanelDic = new Dictionary<string, UIFrom>();


        public void Open<T>(params object[] arr) where T : UIFrom
        {
            var name = typeof(T).Name;
            
            if (!_uiPanelDic.TryGetValue(name, out var panel))
            {
                panel = Create(name);
                _uiPanelDic[name] = panel;
            }

            panel.Open(arr);
            
        }

        UIFrom Create(string name)
        {
            var prefab = Resources.Load(RESOURCE_PATH + name);
            var panel = Instantiate((GameObject)prefab, this.transform).GetComponent<UIFrom>();
            panel.Init();

            return panel;
        }
    }
}

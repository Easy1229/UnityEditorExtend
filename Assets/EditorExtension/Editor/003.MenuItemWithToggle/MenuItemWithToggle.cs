using UnityEngine;
using UnityEditor;

namespace EditorExtension
{
    public class MenuItemWithToggle
    {
        private static bool isChecked = false;
        [MenuItem("EditorExtension/001.MenuItem/SetToggle")]
        static void Toggle()
        {
            isChecked = !isChecked;
            Menu.SetChecked("EditorExtension/001.MenuItem/SetToggle",isChecked);
            if (isChecked)
            {
                Debug.Log("激活");  
            }
            else
            {
                Debug.Log("关闭");   
            }
            
        }
    }
}
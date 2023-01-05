using System;
using UnityEditor;
using UnityEngine;

namespace EditorExtension
{
    public class MenuItemExample
    {
        [MenuItem("EditorExtension/001.MenuItem/GetDataTime")]
        private static void GetDataTime()
        {
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month; 
            int day = DateTime.Today.Day;
            Debug.Log($"今天的日期是{year}年-{month}月-{day}日");
        }
        [MenuItem("EditorExtension/001.MenuItem/OpenURL")]
        private static void OpenURl()
        {
            Application.OpenURL("www.unity.cn");
        }
    }
}

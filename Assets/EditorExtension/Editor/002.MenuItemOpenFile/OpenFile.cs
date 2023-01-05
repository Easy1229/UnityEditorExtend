using UnityEditor;
using UnityEngine;

namespace EditorExtension
{
    public class OpenFile
    {
        [MenuItem("EditorExtension/002.MenuItemOpenFile/OpenFile")]
        private static void OpenDataFile()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
        }
        
        [MenuItem("EditorExtension/002.MenuItemOpenFile/OpenLocalFile")]
        private static void OpenLocalFile()
        {
            EditorUtility.RevealInFinder(Application.dataPath.Replace("Assets","Doc"));
        }
    }
}
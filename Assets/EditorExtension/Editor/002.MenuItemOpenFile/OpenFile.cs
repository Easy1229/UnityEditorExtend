using UnityEditor;
using UnityEngine;

namespace EditorExtension
{
    public class OpenFile
    {
        [MenuItem("EditorExtension/001.MenuItem/OpenFile")]
        private static void OpenDataFile()
        {
            EditorUtility.RevealInFinder(Application.persistentDataPath);
        }
        
        [MenuItem("EditorExtension/001.MenuItem/OpenLocalFile")]
        private static void OpenLocalFile()
        {
            EditorUtility.RevealInFinder(Application.dataPath.Replace("Assets","Doc"));
        }
    }
}
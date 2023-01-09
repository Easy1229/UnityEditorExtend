# Unity编辑器扩展案例
Unity编辑器版本:**2021.3.15**,
下载地址：[Unity Hub](https://unity.cn/releases)


###  001.简单MenuItem实现
`MenuItem("Path");`
```csharp
  [MenuItem("EditorExtension/001.MenuItem/GetDataTime")]
  private static void GetDataTime()
  {
    int year = DateTime.Today.Year;
    int month = DateTime.Today.Month;
    int day = DateTime.Today.Day;
    Debug.Log($"今天的日期是{year}年-{month}月-{day}日");
  }
```


  ### 002.使用MenuItem打开自定义文件目录
`EditorUtility.RevealInFinder(string Path);`
```csharp
[MenuItem("EditorExtension/001.MenuItem/OpenLocalFile")]
private static void OpenLocalFile()
{
    //将默认打开的文件夹替换为自定义的文件夹
    EditorUtility.RevealInFinder(Application.dataPath.Replace("Assets","Doc"));
}
```

### 003.设置可以被勾选的MenuItem
`Menu.SetChecked(string menuPath, bool isChecked)`
```csharp
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
```
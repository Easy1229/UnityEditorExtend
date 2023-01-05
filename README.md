# Unity编辑器扩展案例
Unity编辑器版本:**2021.3.15**,
下载地址：[Unity Hub](https://unity.cn/releases)


- 001.简单MenuItem实现\
`MenuItem("Path")`
```
  `[MenuItem("EditorExtension/001.MenuItem/GetDataTime")]
  private static void GetDataTime()
  {
    int year = DateTime.Today.Year;
    int month = DateTime.Today.Month;
    int day = DateTime.Today.Day;
    Debug.Log($"今天的日期是{year}年-{month}月-{day}日");
  }
```

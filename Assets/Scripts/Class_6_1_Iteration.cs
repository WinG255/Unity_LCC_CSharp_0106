using UnityEngine;

/// <summary>
/// 反覆運算陳述式：迴圈
/// for、foreach、do 與 while
/// </summary>
public class Class_6_1_Iteration : MonoBehaviour 
{
    
    private void Awake()
    {
        #region 迴圈 while、do、for
        //迴圈請在一次性事件內使用 Awake、Start
        //while 迴圈：當bool = true 時會持續執行
        //while (bool) { 程式區塊 }
        //無限迴圈：bool 一直是 true 
        //宣告區域變數 i = 0

        int i = 0;
        i = 5; //測試 while 與 do 的差異
        //當 i < 5 執行 { }
        while (i < 5)
        {
            Debug.Log($"<color=#f33>while 迴圈： i = {i}</color>");
            i++;
        }

        //do 迴圈：
        //do { 程式區塊 } while (bool)
        int j = 0;
        j = 5; //測試 while 與 do 的差異
        do
        {
            Debug.Log($"<color=#f79>do 迴圈，j = {j}</color>");
            j++;
        }
        while (j < 5);

        //for 迴圈：
        //for (初始值;bool;選代器) { 程式區塊 }
        for (int k = 0; k < 5; k++)
        {
            Debug.Log($"<color=#f78>for 迴圈，k = {k}</color>");
        }
        #endregion

        //foreach 迴圈
        //資料結構：陣列、清單等等
        //foreach(資料類型 資料名稱 in 資料結構) { 程式區塊 }
        //拆成每個字元
        string dialogue = "嗨，你好，我是 NPC~";
        foreach (var text in dialogue)
        {
            Debug.Log($"<color=#f63>{text}</color>");
        }
    }
}

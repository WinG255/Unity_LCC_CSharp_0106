using System.Collections.Generic;
using UnityEngine;
using WinG.Tools;

public class Class_16_DataStruct : MonoBehaviour
{

    private void Awake()
    {
        #region 清單
        #endregion

        #region 堆疊
        #endregion

        #region 佇列
        #endregion

        //LinkefList 鍵結串列
        string[] skillsArray = new string[] { "火球", "冰錐" };
        LinkedList<string> skills = new LinkedList<string>();
        LogLinkedList<string>(skills);
        skills.AddLast("落雷");
        LogLinkedList<string>(skills);
        skills.AddLast("岩石");
        LogLinkedList<string>(skills);

        //在火球後面添加一個毒霧
        LinkedListNode<string> skillFire = skills.Find("火球");
        skills.AddAfter(skillFire, "毒霧");
        //在火球前面添加一個瞬移
        skills.AddBefore(skillFire, "瞬移");
        LogLinkedList<string>(skills);

        SortedSet<int> counts = new SortedSet<int> { 9, 2, 80, 1 };
        LogSortedSet<int>(counts);
        counts.Add(77);
        counts.Add(123);
        counts.Add(9);
        LogSortedSet<int>(counts);
        LogSystem.LogWithColor($"最大：{counts.Max}", "#f33");
        LogSystem.LogWithColor($"最小：{counts.Min}", "#f33");

        SortedSet<int> lv= new SortedSet<int> { 7,3,75,123,5,80};
        //交集與差集
        counts.IntersectWith(lv);
        LogSortedSet<int>(counts);
        counts.ExceptWith(lv);
        LogSortedSet<int>(counts);

        SortedSet<int> counts1 = new SortedSet<int> { 9,2,80,1};
        SortedSet<int> counts2 = new SortedSet<int> { 9, 2, 80, 1 };

        //保持排序並且不會有重複的鍵
        SortedList<string, int> board = new SortedList<string, int>();
        board.Add("KID", 90);
        board.Add("Kevin", 85);
        board.Add("Cherry", 85);
        //board.Add("Cherry",77);
        LogSortedList<string, int>(board);

        //SortedList 與 SortedDictionary 的差異
        //1.SortedList 是使用陣列方式儲存，比較省記憶體空間
        //2.SortedDictionary 是使用樹狀結構方式儲存，比較占記憶體空間
        //3.SortedList 可以使用索引值存取[0]
        LogSystem.LogWithColor($"排行榜第一筆：{board.Keys[0]}", "#f93");
        //LogSystem.LogWithColor($"排行榜第一筆：{scores.Keys[0]}", "#f93");

        //4. SortedList 大量資料增減時比較占記移體
    }

    private void LogStack<T>(Stack<T> stack)
    {

    }
    private void LogQueue<T>(Queue<T> queue)
    {

    }
    private void LogLinkedList<T>(LinkedList<T> linkedList)
    {
        foreach(var item in linkedList)
        {
            LogSystem.LogWithColor(item, "#fa3");
        }
        LogSystem.LogWithColor("----------------------", "#fff");
    }
    private void LogSortedSet<T>(SortedSet<T> stack)
    {

    }

    private void LogDictionary<T, U>(Dictionary<T, U> dict)
    {
        foreach (var item in dict)
        {
            LogSystem.LogWithColor($"卡牌的編號：{item.Key}", "#3f3");
            LogSystem.LogWithColor($"卡牌的編號：{item.Value}", "#3f3");
        }
        LogSystem.LogWithColor("----------------------", "#faa");
    }

    private void LogSortedList<T,U>(SortedList<T,U> list)
    {
        foreach (var item in list)
        {
            LogSystem.LogWithColor($"{item.Key}的分數{item.Value}", "#77f");
        }
        LogSystem.LogWithColor("----------------------", "#fff");
    }

    private void LogSortedDictionary<T,U>(SortedDictionary<T,U> dict)
    {
        foreach (var item in dict)
        {
            LogSystem.LogWithColor($"{item.Key} 的分數 {item.Value}", "#77f");
        }
        LogSystem.LogWithColor("----------------------", "#fff");
    }
}

using JetBrains.Annotations;
using UnityEngine;

/// <summary>
/// 方法
/// 中文：方法、函式、函數、功能
/// 英文：function、method(Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour 
{
    private void Awake()
    {
        #region 方法基本語法與參數呼叫練習
        //呼叫方法：方法沒有呼叫不會執行
        //方法名稱();
        FirstFunction();
        UseSkill("一陽指", 20);
        SpawnEnemy();
        SpawnEnemy("史萊姆");

        Fire(550);
        Fire(700, "閃光煙花");

        ByeItem(); //不帶參數，使用預設值
        //只帶其中一個參數，ex:數量
        //ByeItem(30); //錯誤寫法
        ByeItem(count: 30);//正確寫法，指定參數名稱
        ByeItem("藍水", 10);
        #endregion

        //把當果放到區域變數內
        float n = Square(9);
        Debug.Log($"<color= #a33>9的平方{n}</color>");
        //把傳回方法當作該傳回類型使用
        Debug.Log($"<color= #a33>9的平方{Square (7)}</color>");

        Debug.Log($"<color=#6f3>BMI:{BMI(1.67f,58)}</color>");
                
    }

    //框選要整理的程式 Ctrl+ks > #region 快速完成程式碼片段
    #region 方法基本語法與參數
    //方法：
    //包含一系列程式區塊
    //方法語法：
    //修飾詞 傳回資料類型 方法名稱(參數1,參數2...) { 程式區塊 }
    //方法命名習慣：Unity 習慣使用大寫開頭命名方法
    //void 無傳回：使用此方法不會有傳回資料

    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    private void UseSkill(string skill, float mp)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}，減少魔力：{mp}</color>");
    }

    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人:{enemy}</color>");
    }


    //非必要參數(有預設值)需在所有必要參數(沒預設值)之後
    //private void Fire(string fire ="子彈",int speed) //>> private void Fire(int speed,string fire ="子彈")
    //{
    //    Debug.Log($"<color=#f33>發射物件:{fire}，速度：{speed}</color>");
    //}

    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#33f>發射物件:{fire}，速度：{speed}</color>");
    }

    private void ByeItem(string item = "紅水", int count = 20)
    {
        Debug.Log($"<color=#3f3>購買商品:{item}，購買數量：{count}</color>");
    } 
    #endregion
    
    //傳回方法：傳回類型不是void，呼叫該方法會獲得結果
    private float Square(float num)
    {
        return num * num ;
    }


    #region BMI計算
    /// <summary>
    /// 
    /// </summary>
    /// <param name="height">身高：公尺</param>
    /// <param name="weight">體重：公斤</param>
    /// <returns></returns>
    float BMI(float height, float weight)
    {
        return weight / Square(height);
    } 
    #endregion

    //名稱不能重覆，類別、變數與方法
    //方法多載 function overload
    //參數類型或數量不同
    void Move()
    {
        Debug.Log("移動中");
    }

    void Move(float speed)
    {
        Debug.Log($"移動中，速度：{speed}");
    }
}

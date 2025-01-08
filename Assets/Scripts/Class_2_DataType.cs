using UnityEngine;

//三條斜線是摘要(xml語言)，用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識 C# 資料類型
/// </summary>
public class Class_2_DataType : MonoBehaviour 
{
    //變數語法：
    //修飾詞，資料類型，變數名稱，指定，預設值
    //四大常用資料類型：
    //(1)整數：沒有小數點的數值 << int
    //(2)浮點數：有小數點的數值 << float
    //(3)文字：需使用雙引號 << string
    //(4)布林值：true / false << bool
    public int count = 5;
    public float moveSpeed = 2.5f; //需加後綴 f (大小寫均可)
    public float turnSpeed = 2.7F;
    public string character = "Name";
    public bool isDead = false;
    public bool gameOver = true;
}

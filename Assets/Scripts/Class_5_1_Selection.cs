using UnityEngine;
using UnityEngine.UIElements;

//不同命名空間通用，用using 加入

//用時間處理事件
//Invoke
//Timer
//Async
//Coroutine

//命名空間
//將類別分類，類似倉庫概念
//不同命名空間可以有相同名稱類別
//namespace 命名空間名稱 { 內容 } 
namespace MyNamespace
{
    /// <summary>
    /// 選取陳述式 Selectioin Statement
    /// 1.if 判斷式
    /// 2.switch 判斷式
    /// </summary>
    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField,Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"),Range(0,100)]
        private int Score = 100;
        [SerializeField, Header("武器")]
        private string weapon;
        [SerializeField, Header("血量"), Range(0, 100)]
        private int blood = 100;

        private void Awake()
        {
            //if 判斷式
            //if (布林值) { 陳述式 }
            if (true)
            {
                Debug.Log("當布林值為 true，會執行這裡。");
            }

            //快速完成：輸入 if 選取 if 陳述式按 enter  或tab
            if (false)
            {
                Debug.Log("當布林值為 false，不會執行這裡，且會有警告。");
            }
        }

        //更新事件：一秒鐘執行約60次 (60FPS)
        private void Update()
        {
            //常用快捷鍵
            //1.格式化(排版) Ctrl + KD
            //2.程式碼片段 Ctrl + KS，選region

            #region 判斷式 if
            Debug.Log("<color=#79f>更新事件</color>");

            //if isOpen = True, 顯示門開了
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            //else isOpen = false, 顯示門關了
            else
            {
                Debug.Log("<color=#f93>門關了</color>");
            }



            if (Score >= 60)
            {
                Debug.Log("<color=#3f3>課程及格</color>");
            }
            else if (Score >= 40)
            {
                Debug.Log("<color=#f96>不及格，可補考</color>");
            }
            else if (Score >= 20)
            {
                Debug.Log("<color=#f9a>不及格，可補考+交作業</color>");
            }
            else
            {
                Debug.Log("<color=#f33>課程被當</color>");
            }
            #endregion

            #region 判斷式 switch
            //switch 判斷式
            //switch (要判斷的值) { 陳述式 }
            //快速完成：switch + tab * 2
            switch (weapon)
            {
                //case 值：
                //當判斷的值等於值時會執行這裡
                //break; 跳出判斷式
                //如果武器等於小刀，攻擊力等於20
                case "蝴蝶刀":
                    //不加break，會一直往下執行，直到遇到break;
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力：20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力：10</color>");
                    break;
                case "屠龍刀":
                    Debug.Log("<color=#ff3>攻擊力：999</color>");
                    break;
                //else
                default:
                    Debug.Log("<color=#ff3>該武器無法使用</color>");
                    break;

            }
            #endregion


            #region 練習
            if (blood >= 80)
            {
                Debug.Log("<color=#fff>血量安全</color>");
            }
            else if (blood >= 60)
            {
                Debug.Log("<color=#fff>健康狀態有狀況</color>");
            }
            else if (blood >= 40)
            {
                Debug.Log("<color=#fff>警告，快喝水</color>");
            }
            else if (blood >=10)
            {
                Debug.Log("<color=#fff>快死掉了</color>");
            }
            else if (blood == 0)
            {
                Debug.Log("<color=#fff>你已經死了</color>");
            }

            switch (blood) 
            {
                case >= 80:
                    Debug.Log("<color=#aff>血量安全</color>"); 
                    break;
                case >= 60:
                    Debug.Log("<color=#aff>健康狀態有狀況</color>"); 
                    break;
                case >= 40:
                    Debug.Log("<color=#aff>警告，快喝水</color>"); 
                    break;
                case >= 10:
                    Debug.Log("<color=#aff>快死掉了</color>"); 
                    break;
                case 0:
                    Debug.Log("<color=#aff>你已經死了</color>"); 
                    break;
            }
            #endregion
        }
    }
}

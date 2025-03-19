using UnityEngine;
using WinG.Tools;

/// <summary>
/// 委派
/// </summary>
public class Class_19_Delegate : MonoBehaviour 
{
    #region 複習可當參數的變數與元組
    private void Awake()
    {
        Cure(10);
        Card(("史萊姆", 7));
    }
    //將float當作參數
    private void Cure(float cure)
    {
        LogSystem.LogWithColor($"治療的值:{cure}", "#3f3");
    }
    //將元組當作參數
    private void Card((string name, int index) card)
    {
        LogSystem.LogWithColor($"卡片:{card.name} | {card.index}", "#3f3");
    }
    #endregion

    //1.宣告委派:簽章(傳回與參數)
    //宣告一個無傳回與無參數的委派
    private delegate void DelegateMethod();

    //2.目標方法:簽章必需與委派相同
    private void Test()
    {
        LogSystem.LogWithColor("測試", "#f3f");
    }

    private void Talk()
    {
        LogSystem.LogWithColor("HELLO!", "#f39");
    }

    private void MagicCard()
    {
        LogSystem.LogWithColor("招喚小兵", "#3f3");
    }

    //3.宣告變數存放方法(預設空值)
    private DelegateMethod delegateMethod;

    //4.呼叫委派
    private void Start()
    {
        delegateMethod = Test; //將方法 test 存放到變數 delegateMethod
        delegateMethod += Talk; //多播委派:一個委派存放多個方法，相同簽章
        delegateMethod += MagicCard;
        delegateMethod -= Test;
        delegateMethod(); //呼叫委派
    }

    //委派：將方法當作參數
    
}

using UnityEngine;
using WinG.Tools;

/// <summary>
/// 類別與結構的差異
/// </summary>
public class Class_8_3_ClassAndStruct : MonoBehaviour
{
    private void Awake()
    {
        //3.空值：類別可以空值，但結構不行
        Class_8_3_Class class1=new Class_8_3_Class ();//有實例化
        Class_8_3_Class class2 = null; //空值

        Class_8_3_Struct struct1 = new Class_8_3_Struct (); //有實例化
        //Class_8_3_Struct struct2 = null; //空值  //不能指定為null

        LogSystem.LogWithColor(class1.ToString (),"#f96");
        //LogSystem.LogWithColor(class2.ToString(), "#f96");
        LogSystem.LogWithColor(struct1.ToString(), "#f96");
        //LogSystem.LogWithColor(struct2.ToString(), "#f96");
    }

    private void Start()
    {
        //var 不指定類別，可以儲存所有資料
        var testClass = new  Class_8_4_Class ("我是類別");
        var testStruct = new Class_8_4_Struct("我是結構");

        var testClass2 = new Class_8_4_Class("我是類別2");
        var testStruct2 = new Class_8_4_Struct("我是結構2");

        LogSystem.LogWithColor(testClass.name , "#79f");
        LogSystem.LogWithColor(testClass2.name, "#79f");
        LogSystem.LogWithColor(testStruct.name, "#79f");
        LogSystem.LogWithColor(testStruct2.name, "#79f");

        testClass2 = testClass;  //傳址：這時候的class與class2指向同一個地址
        testStruct2 = testStruct; //傳值：這時候的struct 與 struct2 指向同一個值

        //修改 class 或 class2 資料都會被同步
        testClass.name = "類別";
        LogSystem.LogWithColor(testClass.name, "#79f");
        LogSystem.LogWithColor(testClass2.name, "#79f");

        //修改 struct 或 struct2 資料都會被同步
        testStruct.name = "結構";
        LogSystem.LogWithColor(testStruct.name, "#79f");
        LogSystem.LogWithColor(testStruct2.name, "#79f");
    }
}
/// <summary>
/// 類別：
/// 1.繼承：允許繼承
/// 2.建構子：可以有多個建構子
/// 4.資料類型：參考型別 Reference Type
/// </summary>
public class Class_8_3_Class : MonoBehaviour
{
    public Class_8_3_Class ()
    {

    }

    public Class_8_3_Class(int test)
    {

    }
}

/// <summary>
/// 結構：
/// 1.結構：不允許繼承
/// 2.建構子：不能有無參數建構子
/// </summary>
public struct Class_8_3_Struct
{
    //public Class_8_3_Struct()
    //{

    //}

    public Class_8_3_Struct(int test)
    {

    }
}
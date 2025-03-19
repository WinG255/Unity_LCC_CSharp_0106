using UnityEngine;
using UnityEngine.UIElements;
using WinG.Tools;

/// <summary>
/// �e��
/// </summary>
public class Class_19_Delegate : MonoBehaviour 
{
    #region �Ʋߥi��Ѽƪ��ܼƻP����
    private void Awake()
    {
        Cure(10);
        Card(("�v�ܩi", 7));
    }
    //�Nfloat��@�Ѽ�
    private void Cure(float cure)
    {
        LogSystem.LogWithColor($"�v������:{cure}", "#3f3");
    }
    //�N���շ�@�Ѽ�
    private void Card((string name, int index) card)
    {
        LogSystem.LogWithColor($"�d��:{card.name} | {card.index}", "#3f3");
    }
    #endregion

    //1.�ŧi�e��:ñ��(�Ǧ^�P�Ѽ�)
    //�ŧi�@�ӵL�Ǧ^�P�L�Ѽƪ��e��
    private delegate void DelegateMethod();
    private delegate float Calculate(float numA, float numB);
    private delegate void DelagateCombine<T>(T a);

    //2.�ؼФ�k:ñ�����ݻP�e���ۦP
    #region �L�Ǧ^�P�L�ѼƤ�k
    private void Test()
    {
        LogSystem.LogWithColor("����", "#f3f");
    }

    private void Talk()
    {
        LogSystem.LogWithColor("HELLO!", "#f39");
    }

    private void MagicCard()
    {
        LogSystem.LogWithColor("�۳�p�L", "#3f3");
    }
    #endregion

    //+
    private float Add(float numA, float numB)
    {
        float result = numA + numB;
        LogSystem.LogWithColor(result, "#7ff");
        return numA + numB;
    }

    //-
    private float Sub(float numA, float numB)
    {
        float result = numA - numB;
        LogSystem.LogWithColor(result, "#7ff");
        return numA + numB;
    }

    //*
    private float Mul(float numA, float numB)
    {
        float result = numA * numB;
        LogSystem.LogWithColor(result, "#7ff");
        return numA + numB;
    }

    private void Combine<T>(T a)
    {
        LogSystem.LogWithColor(a, "#ff3");
    }

    //3.�ŧi�ܼƦs���k(�w�]�ŭ�)
    private DelegateMethod delegateMethod;
    private Calculate calculate;
    private DelagateCombine<float> delateCombineFloat;
    private DelagateCombine<int> delateCombineInt;

    //4.�I�s�e��
    private void Start()
    {
        #region �򥻩e��
        delegateMethod = Test; //�N��k test �s����ܼ� delegateMethod
        delegateMethod += Talk; //�h���e��:�@�өe���s��h�Ӥ�k�A�ۦPñ��
        delegateMethod += MagicCard;
        delegateMethod -= Test;
        delegateMethod(); //�I�s�e��
        #endregion

        #region 
        calculate += Add;
        calculate += Sub;
        calculate += Mul;
        calculate(10, 3);
        calculate(100, 70);
        calculate(50, 3);

        CalcuteNum(Sub, 3, 7); //�N��k��ѼƶǤJ
        #endregion

        delateCombineFloat = Combine<float>;
        delateCombineFloat(3.5f);
        delateCombineInt = Combine<int>;
        delateCombineInt(999);
    }

    //�e���G�N��k��@�Ѽ�
    private void CalcuteNum(Calculate calculate,float a,float b)
    {
        var result = calculate(a, b);
        //LogSystem.LogWithColor(result, "#ff3");
    }
}

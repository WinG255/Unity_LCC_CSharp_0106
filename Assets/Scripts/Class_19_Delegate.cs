using UnityEngine;
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

    //2.�ؼФ�k:ñ�����ݻP�e���ۦP
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

    //3.�ŧi�ܼƦs���k(�w�]�ŭ�)
    private DelegateMethod delegateMethod;

    //4.�I�s�e��
    private void Start()
    {
        delegateMethod = Test; //�N��k test �s����ܼ� delegateMethod
        delegateMethod += Talk; //�h���e��:�@�өe���s��h�Ӥ�k�A�ۦPñ��
        delegateMethod += MagicCard;
        delegateMethod -= Test;
        delegateMethod(); //�I�s�e��
    }

    //�e���G�N��k��@�Ѽ�
    
}

using UnityEngine;

/// <summary>
/// ���O Class
/// </summary>
public class Class_8_1_Class:MonoBehaviour
{
    //���O�G
    //�Ψөw�q�@�Ӫ���H�ΥL�Ҿ֦�����ƻP�\��(����)

    private void Awake()
    {
        //��Ҥ� NPC ���x�s�b npcJack �ܼƤ�
        Class_8_1_NPC npcJack = new Class_8_1_NPC (); 
        Class_8_1_NPC  npcKID = new Class_8_1_NPC ("KID","�A�n");

        npcJack.LogName();
        npcKID.LogName();
        npcKID.Talk();
    }
}

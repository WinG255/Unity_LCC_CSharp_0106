using UnityEngine;

/// <summary>
/// NPC
/// </summary>
public class Class_8_1_NPC
{
    private string name;
    private string dialogue;
    private string skill;
    private int hp;

    //�غc�l�G�S���Ǧ^�����A�W�ٻP���O�ۦP�����}��k
    //�w�]�غc�l�G�S���Ѽ�
    public Class_8_1_NPC ()
    {
        Debug.Log("<color=#373>�w�]�غc�l</color>");
    }

    public Class_8_1_NPC(string _name,string _dialogue)
    {
        name = _name;
        dialogue = _dialogue;
        Debug.Log("<color=#373>���Ѽƪ��w�]�غc�l</color>");
    }

    public Class_8_1_NPC(string _name,string _skill, int _hp)
    {
        name = _name;
        skill = _skill;
        hp = _hp;
        Debug.Log($"<color=#f33>npc�W�١G{name}�A�ޯ�W�١G{skill}�A��q�G{hp}</color>");
    }

    public void LogName()
    {
        Debug.Log($"<color=#373>NPC���W�١G{name}</color>");

    }
    public void Talk()
    {
        Debug.Log($"<color=#373>{dialogue}</color>");

    }
}

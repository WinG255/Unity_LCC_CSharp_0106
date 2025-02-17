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

    //建構子：沒有傳回類型，名稱與類別相同的公開方法
    //預設建構子：沒有參數
    public Class_8_1_NPC ()
    {
        Debug.Log("<color=#373>預設建構子</color>");
    }

    public Class_8_1_NPC(string _name,string _dialogue)
    {
        name = _name;
        dialogue = _dialogue;
        Debug.Log("<color=#373>有參數的預設建構子</color>");
    }

    public Class_8_1_NPC(string _name,string _skill, int _hp)
    {
        name = _name;
        skill = _skill;
        hp = _hp;
        Debug.Log($"<color=#f33>npc名稱：{name}，技能名稱：{skill}，血量：{hp}</color>");
    }

    public void LogName()
    {
        Debug.Log($"<color=#373>NPC的名稱：{name}</color>");

    }
    public void Talk()
    {
        Debug.Log($"<color=#373>{dialogue}</color>");

    }
}

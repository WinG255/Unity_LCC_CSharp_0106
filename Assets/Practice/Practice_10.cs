using UnityEngine;
using WinG.Tools;

public class Practice_10 : MonoBehaviour 
{
    private void Awake()
    {
        Potion redWater = new Potion();
        Potion blueWater = new Potion();
        Equipment helmet = new Equipment();

        redWater.Use("紅水");
        blueWater.Use("藍水", 100);
        helmet.Use("頭盔");
    }
}

public class Props
{
    public string name;

    public virtual void Use(string name)
    {
        LogSystem.LogWithColor($"使用道具{name}", "#9f9");
    }
}

public class Potion:Props
{
    public void Use(string name,int mp)
    {
        LogSystem.LogWithColor($"使用道具{name}，回復魔力{mp}", "#9f9");
    }
}

public class Equipment:Props
{
    public override void Use(string name)
    {
        LogSystem.LogWithColor($"已裝備{name}", "#9f9");
    }
}
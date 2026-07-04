using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Main Blade")]
public class MainBlade : Beys
{
    public bool DontNeedReched;

    public bool IsUx, IsExpend, IsBx, IsCx;

    public bool NeedLockChip, NeedAssit, NeedOver;

    public override string NameP()
    {
        return namePart;
    }

    public override int IDBey()
    {
        return ID;
    }

    public override TypeBey Type()
    {
        return typeBey;
    }

    public override bool TurnLeft()
    {
        return Turnleft;
    }

    public override TypePart TypeP()
    {
        return typePart;
    }
}
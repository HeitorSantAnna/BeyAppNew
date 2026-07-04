using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Bit")]
public class Bit : Beys
{
    public bool IsSimple;

    public TypeBit typeBit;

    public override string NameP()
    {
        return namePart;
    }

    public override TypeBey Type()
    {
        return typeBey;
    }

    public override int IDBey()
    {
        return ID;
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

public enum TypeBit
{
    Normal,
    Free,
    High,
    Under,
    Gear,
    Low,
    Trans
}
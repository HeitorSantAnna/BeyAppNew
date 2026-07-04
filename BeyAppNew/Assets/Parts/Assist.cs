using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Assist Blade")]
public class Assist : Beys
{
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
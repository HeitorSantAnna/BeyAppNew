using UnityEngine;

[CreateAssetMenu(menuName = "BeysParts/Reched")]
public class Reched : Beys
{
    public Number number;

    public Height height;

    public override string NameP()
    {
        return $"{number}-{height}";
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

public enum Number
{
    Zero = 0,
    Um = 1,
    Dois = 2,
    Três = 3,
    Quatro = 4,
    Cinco = 5,
    Seis = 6,
    Sete = 7,
    Nove = 9
}

public enum Height
{
    QuarentaCinco = 45,
    Cinquenta = 50,
    CinquentaCinco = 55,
    Sessenta = 60,
    SessantaCinco = 65,
    Setenta = 70,
    SetentaCinto = 75,
    Oitenta = 80,
    OitentaCinco = 85
}
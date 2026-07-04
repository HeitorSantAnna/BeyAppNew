using UnityEngine;

[CreateAssetMenu(fileName = "Beys", menuName = "Scriptable Objects/Beys")]
public abstract class Beys : ScriptableObject
{
    public string namePart;

    public Sprite sprite;

    public int ID;

    public TypeBey typeBey;

    public TypePart typePart;

    public bool Turnleft;

    public abstract string NameP();

    public abstract TypeBey Type();

    public abstract int IDBey();

    public abstract bool TurnLeft();

    public abstract TypePart TypeP();
}

public enum TypeBey
{
    Attack,
    Defense,
    Balance,
    Stamina,
}

public enum TypePart
{
    Chip,
    Assist,
    Over,
    Main,
    Simple,
    Double
}
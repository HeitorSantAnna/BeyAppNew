using UnityEngine;

[CreateAssetMenu(fileName = "Bits", menuName = "Scriptable Objects/Bits")]
public class Bits : ScriptableObject
{
    public string nameBit;

    public string ID;

    public TypeBit typeBit;

    public Mach machBit;

    public Sprite bitImage;

    public GameObject bitModel;
}

public enum TypeBit
{
    Attack,
    Defense,
    Stamina,
    Balance
}

public enum Mach
{
    Normal,
    Free,
    Gear,
    Under,
    High,
    Disc,
    Wall,
    Low,
}
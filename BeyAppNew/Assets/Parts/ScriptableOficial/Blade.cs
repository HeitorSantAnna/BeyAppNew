using UnityEngine;

[CreateAssetMenu(fileName = "Blade", menuName = "Scriptable Objects/Blade")]
public class Blade : ScriptableObject
{
    public string nameBlade;

    public Sprite imageBlade;

    public GameObject ModelBlade;

    public string ID;

    public TypeBlade type;

    public Generation generation;

    public bool IsExpend;

    public bool TurnLeft;
}

public enum TypeBlade
{
    Attack,
    Defense,
    Stamina,
    Balance
}

public enum Generation
{
    BX,
    UX,
    CX
}
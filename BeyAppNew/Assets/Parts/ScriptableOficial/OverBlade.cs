using UnityEngine;

[CreateAssetMenu(fileName = "OverBlade", menuName = "Scriptable Objects/OverBlade")]
public class OverBlade : ScriptableObject
{
    public string nameOver;

    public string ID;

    public TypeOver type;

    public Sprite overImage;

    public GameObject modelOver;
}

public enum TypeOver
{
    Attack,
    Defense,
    Stamina,
    Balance
}
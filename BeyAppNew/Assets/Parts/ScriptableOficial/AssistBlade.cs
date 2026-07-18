using UnityEngine;

[CreateAssetMenu(fileName = "Assist", menuName = "Scriptable Objects/Assist")]
public class AssistBlade : ScriptableObject
{
    public string nameAssist;

    public string ID;

    public Sprite assistImage;

    public GameObject assistModel;

    public TypeAssist type;
}

public enum TypeAssist
{
    Attack,
    Defense,
    Stamina,
    Balance
}

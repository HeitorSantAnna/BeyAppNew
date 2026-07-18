using UnityEngine;

[CreateAssetMenu(fileName = "Chip", menuName = "Scriptable Objects/Chip")]
public class Chip : ScriptableObject
{
    public string nameChip;

    public bool IsMetal;

    public bool TurnLeft;

    public string ID;

    public Sprite chipeImage;

    public GameObject modelChip;
}

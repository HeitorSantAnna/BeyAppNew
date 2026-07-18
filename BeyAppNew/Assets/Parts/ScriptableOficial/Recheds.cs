using UnityEngine;

[CreateAssetMenu(fileName = "Recheds", menuName = "Scriptable Objects/Recheds")]
public class Recheds : ScriptableObject
{
    public string nameReched;

    public string ID;

    public NumberR rechedN;

    public HeightR rechedH;

    public Sprite rechedImage;

    public GameObject rechedModel;
}

public enum NumberR
{
    Zero = 0,
    Um = 1,
    Dois= 2,
    Três = 3,
    Quatro = 4,
    Cinco = 5,
    Seis = 6,
    Sete = 7,
    Oito = 8,
    Nove = 9,
    Metal
}

public enum HeightR
{
    QuarentaC = 45,
    Cinquenta = 50,
    CinquentaC = 55,
    Sessenta = 60,
    SessentaC = 65,
    Setenta = 70,
    SetentaC = 75,
    Oitenta = 80,
    OitentaC = 85
}
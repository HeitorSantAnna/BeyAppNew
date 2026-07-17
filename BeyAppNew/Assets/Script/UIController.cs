using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    [SerializeField] UIDocument mainDocument;
    [SerializeField] VisualTreeAsset bxDocument, uxDocument, cxDocument;
    [SerializeField] VisualElement mainConteinerElement, bxElement, root;

    bool bxOn = false, cxOn = false, UxOn = false;

    private DropdownField dropBX, dropType, dropNumber, dropHeight, dropTypeBit, dropMach, dropBit, nameBits, droptypeBit;

    private Button search, searchR, searchB;

    private Image imageBey, imageReched, imageBit;

    private GameController gameController;

    private List<Beys> Blade = new List<Beys>();

    private List<Beys> Reched = new List<Beys>();

    private List<Beys> Bits = new List<Beys>();

    private Toggle LSpin;

    private Toggle Expend;

    private Toggle NoReched;

    private bool leftspin, expend, dontreched;

    private Label alert;

    private string rechednumber, rechedheight, typebit, typeMach;

    private void Awake()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        Blade = gameController.BladesBX();

        Reched = gameController.Reched();

        Bits = gameController.Bit();
    }

    void Start()
    {
        root = mainDocument.GetComponent<UIDocument>().rootVisualElement;

        mainConteinerElement = root.Q<VisualElement>("ZoneCreatorBey");

        Button bxButton = root.Q<Button>("BXBeysButton");

        Button exit = root.Q<Button>("ExitButton");

        Button confirm = root.Q<Button>("ConfirmButton");

        bxButton.clicked += () => BXVisual(root);

        exit.clicked += () => PrincipalScene();

        confirm.clicked += () => ConfirmBey();
    }

    void BXVisual(VisualElement root)
    {
        bxOn = true;

        bxDocument.CloneTree(mainConteinerElement);

        dropBX = root.Q<DropdownField>("NameBey");

        dropType = root.Q<DropdownField>("TypeBlede");

        LSpin = root.Q<Toggle>("LeftSpin");

        Expend = root.Q<Toggle>("Expend");

        imageBey = root.Q<Image>("ImageBlade");

        search = root.Q<Button>("Search");

        searchR = root.Q<Button>("SearchR");

        dropNumber = root.Q<DropdownField>("Number");

        dropHeight = root.Q<DropdownField>("Hieght");

        imageReched = root.Q<Image>("ImageReched");

        dropTypeBit = root.Q<DropdownField>("TypeBit");

        dropMach = root.Q<DropdownField>("MachanicsBit");

        NoReched = root.Q<Toggle>("DontNeedReched");

        nameBits = root.Q<DropdownField>("NameBit");

        imageBit = root.Q<Image>("ImageBit");

        searchB = root.Q<Button>("SearchBit");

        alert = root.Q<Label>("Alert");

        droptypeBit = root.Q<DropdownField>("TypeBit"); 

        search.clicked += () => SearchBladeBX();

        searchR.clicked += () => SearchReched();

        searchB.clicked += () => SearchBit();

        dropTypeBit.RegisterValueChangedCallback(ChangeTypeBit);

        dropMach.RegisterValueChangedCallback(ChangeMachBit);

        dropBX.RegisterValueChangedCallback(ChangeImageBlade);

        LSpin.RegisterValueChangedCallback(ChangeSpinBX);

        Expend.RegisterValueChangedCallback(ChangeExpendBX);

        dropNumber.RegisterValueChangedCallback(ChangeNumberReched);

        dropHeight.RegisterValueChangedCallback(ChangeHeight);

        NoReched.RegisterValueChangedCallback(ChangeNeedReched);

        nameBits.RegisterValueChangedCallback(ChangeImageBit);

        for (int i = 0; i < gameController.BladeBxs.Count; i++)
        {
            dropBX.choices.Add($"{gameController.BladeBxs[i].ToString()}");
        }
    }

    void PrincipalScene()
    {
        SceneManager.LoadScene(0);
    }

    void ConfirmBey()
    {
        Debug.Log($"Bey criado");
    }

    void ChangeSpinBX(ChangeEvent<bool> evt)
    {
        leftspin = evt.newValue;
    }

    void ChangeExpendBX(ChangeEvent<bool> evt)
    {
        expend = evt.newValue;
    }

    void ChangeImageBlade(ChangeEvent<string> evt)
    {
        int index = dropBX.choices.IndexOf(evt.newValue);

        if(index >= 0)
        {
            imageBey.sprite = gameController.BladeBxs[index].sprite;
        }
    }

    void ChangeHeight(ChangeEvent<string> evt)
    {
        rechedheight = evt.newValue.ToString();
    }

    void ChangeNumberReched(ChangeEvent<string> evt)
    {
        rechednumber = evt.newValue.ToString();
    }

    void ChangeNeedReched(ChangeEvent<bool> evt)
    {
        dontreched = evt.newValue;
    }

    void ChangeTypeBit(ChangeEvent<string> evt)
    {
        typebit = evt.newValue.ToString();
    }

    void ChangeMachBit(ChangeEvent<string> evt)
    {
        typeMach = evt.newValue.ToString();
    }

    void ChangeImageBit(ChangeEvent<string> evt)
    {
        int index = nameBits.choices.IndexOf(evt.newValue);

        if(index >= 0)
        {
            imageBit.sprite = Bits[index].sprite;
        }
    }

    void SearchBladeBX()
    {
        dropBX.choices.Clear();

        string type = dropType.value;

        for(int i = 0; i < Blade.Count; i++)
        {
            string typebey = Blade[i].typeBey.ToString();

            bool Ls = Blade[i].Turnleft;

            bool Ex = Blade[i].IsExpend;

            if(typebey == type && leftspin == Ls && expend == Ex)
            {
                dropBX.choices.Add($"{Blade[i].namePart.ToString()}");
            }
        }
    }

    void SearchReched()
    {
        if(dropNumber != null && dropHeight != null)
        {
            string TrueName = $"{rechednumber}-{rechedheight}";

            for(int i = 0; i < Reched.Count; i++)
            {
                string namep = Reched[i].namePart.ToString();

                if (namep == TrueName)
                {
                    imageReched.sprite = Reched[i].sprite;
                }
            }
        }
        else
        {
            alert.text = "Marque ambas as opções para aparecer a peça";
        }
    }

    void SearchBit()
    {
        nameBits.choices.Clear();

        string typeBit = droptypeBit.value;

        string machBit = dropMach.value;

        for(int i = 0; i < Bits.Count; i++)
        {
            string tBit = Bits[i].typeBey.ToString();

            string tPart = Bits[i].typePart.ToString();

            if(typeBit == tBit)
            {
                nameBits.choices.Add($"{Bits[i].namePart.ToString()}");
            }
        }

        Debug.Log($"{^nameBits.choices.Count}");
    }
}
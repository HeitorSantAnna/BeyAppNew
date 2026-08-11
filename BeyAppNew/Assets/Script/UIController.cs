using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    [SerializeField] UIDocument mainDocument;
    [SerializeField] VisualTreeAsset bxDocument, uxDocument, cxDocument;
    [SerializeField] VisualElement mainConteinerElement, bxElement, root;

    #region UIToolkit BX references

    private DropdownField dropBX, dropType, dropNumber, dropHeight, dropTypeBit, dropMach, dropBit, nameBits, droptypeBit;

    private Button search, searchR, searchB;

    private Image imageBey, imageReched, imageBit;

    #endregion

    #region UIToolkit CX refernces

    private Button searchL, searchO, searchM, searchA, searchCR, searchCB;

    private Image imageChip, imageOver, imageMain, imageAssist;

    private DropdownField dropTypeLC, dropTypeO, dropTypeM, dropTypeA, dropTypeB, dropMB, dropchip, dropO, dropM, dropA, dropB;

    #endregion

    private GameController gameController;

    #region List Beys Parts

    private List<Blade> Blades= new List<Blade>();

    private List<Recheds> Reched = new List<Recheds>();

    private List<Bits> Bit = new List<Bits>();

    private List<Chip> LChips = new List<Chip>();

    private List<OverBlade> OBlades = new List<OverBlade>();

    private List<AssistBlade> ABlades = new List<AssistBlade>();

    #endregion

    #region Variables

    private Toggle LSpin;

    private Toggle Expend;

    private Toggle NoReched;

    private Toggle Metal;

    private bool leftspin, expend, dontreched, metal;

    #endregion

    private Button bxButton, cxButton, uxButton, exit, confirm;

    private Label alert;

    private string rechednumber, rechedheight, typebit, typeMach;

    private void Awake()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        #region Preencher Listas

        Blades = gameController.Blade();

        Reched = gameController.Reched();

        Bit = gameController.Bit();

        LChips = gameController.LChip();

        OBlades = gameController.OBlade();

        ABlades = gameController.ABlade();

        #endregion
    }

    void Start()
    {
        root = mainDocument.GetComponent<UIDocument>().rootVisualElement;

        mainConteinerElement = root.Q<VisualElement>("ZoneCreatorBey");

        #region Butões principais

        bxButton = root.Q<Button>("BXBeysButton");

        cxButton = root.Q<Button>("CXBeysButton");

        uxButton = root.Q<Button>("UXBeysButton");

        exit = root.Q<Button>("ExitButton");

        confirm = root.Q<Button>("ConfirmButton");

        #endregion

        #region Actions Buttons

        bxButton.clicked += () => BXVisual(root);

        cxButton.clicked += () => CXVisual(root);

        exit.clicked += () => PrincipalScene();

        confirm.clicked += () => ConfirmBey();

        #endregion
    }

    void BXVisual(VisualElement root)
    {
        bxButton.SetEnabled(false);

        cxButton.SetEnabled(false);

        uxButton.SetEnabled(false);

        bxDocument.CloneTree(mainConteinerElement);

        for (int i = 0; i < Blades.Count; i++)
        {
            dropBX.choices.Add($"{Blades[i].nameBlade.ToString()}");
        }

        #region Get GameObjects UIToolkit

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

        #endregion

        #region Search Area

        /*search.clicked += () => SearchBladeBX();

        searchR.clicked += () => SearchReched();

        searchB.clicked += () => SearchBit();*/

        #endregion

        #region Detect change value

        dropTypeBit.RegisterValueChangedCallback(ChangeTypeBit);

        dropMach.RegisterValueChangedCallback(ChangeMachBit);

        dropBX.RegisterValueChangedCallback(ChangeImageBlade);

        LSpin.RegisterValueChangedCallback(ChangeSpinBX);

        Expend.RegisterValueChangedCallback(ChangeExpendBX);

        dropNumber.RegisterValueChangedCallback(ChangeNumberReched);

        dropHeight.RegisterValueChangedCallback(ChangeHeight);

        NoReched.RegisterValueChangedCallback(ChangeNeedReched);

        nameBits.RegisterValueChangedCallback(ChangeImageBit);

        #endregion
    }

    void CXVisual(VisualElement root)
    {
        bxButton.SetEnabled(false);

        cxButton.SetEnabled(false);

        uxButton.SetEnabled(false);

        cxDocument.CloneTree(mainConteinerElement);

        #region Get Elements UIToolkit

        dropTypeLC = root.Q<DropdownField>("TypeLC");

        dropchip = root.Q<DropdownField>("NameChip");

        dropTypeO = root.Q<DropdownField>("TipeOver");

        dropO = root.Q<DropdownField>("NameOver");

        dropTypeM = root.Q<DropdownField>("TypeMainBlade");

        dropM = root.Q<DropdownField>("SearchNameMain");

        dropTypeA = root.Q<DropdownField>("TypeAssist");

        dropA = root.Q<DropdownField>("SearchNameAssist");

        dropNumber = root.Q<DropdownField>("NumberReched");

        dropHeight = root.Q<DropdownField>("Heightreched");

        dropTypeB = root.Q<DropdownField>("TypeBit");

        dropMB = root.Q<DropdownField>("MachBit");

        dropB = root.Q<DropdownField>("SearchNameBit");

        LSpin = root.Q<Toggle>("LeftSpinChip");

        Expend = root.Q<Toggle>("ExpendMain");

        Metal = root.Q<Toggle>("IsMetal");

        imageChip = root.Q<Image>("ImageLockChip");

        imageOver = root.Q<Image>("ImageOver");

        imageMain = root.Q<Image>("ImageMainBlade");

        imageAssist = root.Q<Image>("ImageAssist");

        imageReched = root.Q<Image>("ImageReched");

        imageBit = root.Q<Image>("ImageBit");

        #endregion

        /*#region Search Area Button

        searchL.clicked += () => SearchChip();

        searchO.clicked += () => SearchO();

        searchM.clicked += () => SearchM();

        searchA.clicked += () => SearchA();

        searchCR.clicked += () => SearchRechedCX();

        searchCB.clicked += () => SearchBitCX();

        #endregion*/

        #region Detect Change Values

        LSpin.RegisterValueChangedCallback(ChangeSpinBX);

        Expend.RegisterValueChangedCallback(ChangeExpendBX);

        Metal.RegisterValueChangedCallback(ChangeMetal);

        #endregion
    }

    void PrincipalScene()
    {
        SceneManager.LoadScene(0);
    }

    void ConfirmBey()
    {
        Debug.Log($"Bey criado");
    }

    #region Changes Functions

    void ChangeSpinBX(ChangeEvent<bool> evt)
    {
        leftspin = evt.newValue;
    }

    void ChangeMetal(ChangeEvent<bool> evt)
    {
        metal = evt.newValue;
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
            //imageBey.sprite = Blade[index].sprite;
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
            //imageBit.sprite = Bits[index].sprite;
        }
    }

    #endregion

    /*#region Search Zone BX

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

        string machBit = dropMB.value;

        for(int i = 0; i < Bits.Count; i++)
        {
            string tBit = Bits[i].typeBey.ToString();

            string tPart = Bits[i].typePart.ToString();

            if(typeBit == tBit)
            {
                nameBits.choices.Add($"{Bits[i].namePart.ToString()}");
            }
        }
    }

    #endregion

    #region Search Zone CX

    void SearchChip()
    {
        dropchip.choices.Clear();

        string typeChouse = dropTypeLC.value;

        for(int i = 0; i < LChips.Count; i++)
        {
            string typechip = LChips[i].typeBey.ToString();

            bool Sleft = LChips[i].Turnleft;

            if(typechip == typeChouse && leftspin == Sleft)
            {
                dropchip.choices.Add($"{LChips[i].namePart.ToString()}");
            }
        }
    }

    void SearchO()
    {
        dropO.choices.Clear();

        string typeChouse = dropTypeO.value;

        for(int i = 0; i < OBlades.Count; i++)
        {
            string typeOver = OBlades[i].typeBey.ToString();

            if(typeOver == typeChouse)
            {
                dropO.choices.Add($"{OBlades[i].namePart.ToString()}");
            }
        }
    }

    void SearchM()
    {
        dropM.choices.Clear();

        string typeChouse = dropTypeM.value;

        for(int i = 0; i< MBlades.Count; i++)
        {
            string typeMain = MBlades[i].typeBey.ToString();

            if(typeMain == typeChouse)
            {
                dropM.choices.Add($"{MBlades[i].namePart.ToString()}");
            }
        }
    }

    void SearchA()
    {
        dropA.choices.Clear();

        string typeChouse = dropTypeA.value;

        for(int i = 0; i < ABlades.Count; i++)
        {
            string typeAssist = ABlades[i].namePart.ToString();

            if(typeAssist == typeChouse)
            {
                dropA.choices.Add($"{ABlades[i].namePart.ToString()}");
            }
        }
    }

    void SearchRechedCX()
    {
        if (dropNumber != null && dropHeight != null)
        {
            string TrueName = $"{rechednumber}-{rechedheight}";

            for (int i = 0; i < Reched.Count; i++)
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

    void SearchBitCX()
    {
        dropB.choices.Clear();

        string typeBit = dropTypeB.value;

        string machBit = dropMB.value;

        for (int i = 0; i < Bits.Count; i++)
        {
            string tBit = Bits[i].typeBey.ToString();

            string tPart = Bits[i].typePart.ToString();

            if (tBit == typeBit && tPart == machBit)
            {
                dropB.choices.Add($"{Bits[i].namePart.ToString()}");
            }
        }
    }

    #endregion*/
}
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    [SerializeField] UIDocument mainDocument;
    [SerializeField] VisualTreeAsset bxDocument, uxDocument, cxDocument;
    [SerializeField] VisualElement mainConteinerElement, bxElement, root;

    bool bxOn = false, cxOn = false, UxOn = false;

    private DropdownField drapBX;

    private Image imageBey;

    private GameController gameController;

    private void Awake()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
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

        drapBX = root.Q<DropdownField>("NameBey");

        imageBey = root.Q<Image>("ImageBlade");

        drapBX.RegisterValueChangedCallback(ChangeImage);

        for (int i = 0; i < gameController.BladeBxs.Count; i++)
        {
            drapBX.choices.Add($"{gameController.BladeBxs[i].ToString()}");
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

    void ChangeImage(ChangeEvent<string> evt)
    {
        Debug.Log($"{evt.newValue}");

        int index = drapBX.choices.IndexOf(evt.newValue);

        if(index >= 0)
        {
            imageBey.sprite = gameController.BladeBxs[index].sprite;
        }
    }
}

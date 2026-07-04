using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
//using UnityEngine.AddressableAssets;

public class GameController : MonoBehaviour
{
    [SerializeField] List<Beys> Mainblade = new List<Beys>();

    [SerializeField] List<Beys> Overblade = new List<Beys>();

    [SerializeField] List<Beys> Assistblade = new List<Beys>();

    [SerializeField] List<Beys> UBlade = new List<Beys>();

    [SerializeField] List<Beys> BBlade = new List<Beys>();


    //Aqui vai ficar a parte em que o sistema vai colocar os scriptable objects dentro das listas atraves do addressable
    void Awake()
    {
        //Addressables.LoadAssetsAsync<Beys>("Main", Mblades => BBlade.Add(Mblades)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("UX", bladeu => UBlade.Add(bladeu)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Over", Oblade => Overblade.Add(Oblade)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Assist", Ablade => Assistblade.Add(Ablade)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Main", Mblade => Mainblade.Add(Mblade)).Completed += OnLoaded;
    }

    void OnLoaded(AsyncOperationHandle<IList<Beys>> handle)
    {
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            for(int i = 0; i < Mainblade.Count; i++)
            {
                Debug.Log($"Blade: {Mainblade[i].namePart}");
            }

            for(int i = 0; i < UBlade.Count; i++)
            {
                Debug.Log($"Blade UX: {UBlade[i].namePart}");
            }

            for(int i = 0; i < Assistblade.Count; i++)
            {
                Debug.Log($"Assist Blade: {Assistblade[i].namePart}");
            }

            for(int i = 0; i < Overblade.Count; i++)
            {
                Debug.Log($"Over Blade: {Overblade[i].namePart}");
            }
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

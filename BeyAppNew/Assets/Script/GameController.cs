using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    /*[SerializeField] List<Beys> Mainblade = new List<Beys>();

    [SerializeField] List<Beys> Overblade = new List<Beys>();

    [SerializeField] List<Beys> Assistblade = new List<Beys>();

    public List<Beys> UBlade = new List<Beys>();

    [SerializeField] List<Beys> BBlade = new List<Beys>();*/

    #region Lista das partes dos beys

    //Aqui fica a Blade dos BX
    public List<Beys> BladeBxs = new List<Beys>();

    //Aqui fica a Clade dos UX
    List<Beys> BladeUxs = new List<Beys>();

    //Aqui fica os Lock Chips
    List<Beys> LockChips = new List<Beys>();

    //Aqui fica as Over Blades
    List<Beys> OverBlades = new List<Beys>();

    //Aqui fica as Main Blades
    List<Beys> mainBlades = new List<Beys>();

    //Aqui fica as Assist Blades
    List<Beys> AssistBlades = new List<Beys>();

    //Aqui ficam as Recheds
    List<Beys> Recheds = new List<Beys>();

    //Aqui ficam as Bits
    List<Beys> Bits = new List<Beys>();

    #endregion

    private GameObject gameObjectController;

    private void Start()
    {
        if(gameObjectController == null)
        {
            gameObjectController = this.gameObject;
        }
        else
        {
            Destroy(this);
        }

        DontDestroyOnLoad(gameObjectController);
    }

    //Aqui vai ficar a parte em que o sistema vai colocar os scriptable objects dentro das listas atraves do addressable
    void Awake()
    {
        //Aqui vai chamar as Blades BX
        Addressables.LoadAssetsAsync<Beys>("BX", bladeb => BladeBxs.Add(bladeb)).Completed += OnLoaded;

        //Aqui ficam as Recheds
        Addressables.LoadAssetsAsync<Beys>("Reched", reched => Recheds.Add(reched)).Completed += OnLoaded;

        //Aqui ficam as bits
        Addressables.LoadAssetsAsync<Beys>("Bit", bit => Bits.Add(bit)).Completed += OnLoaded;
        /*Addressables.LoadAssetsAsync<Beys>("Over", Oblade => Overblade.Add(Oblade)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Assist", Ablade => Assistblade.Add(Ablade)).Completed += OnLoaded;
        Addressables.LoadAssetsAsync<Beys>("Main", Mblade => Mainblade.Add(Mblade)).Completed += OnLoaded;*/
    }

    void OnLoaded(AsyncOperationHandle<IList<Beys>> handle)
    {
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    public List<Beys> BladesBX()
    {
        return BladeBxs;
    }

    public List<Beys> Reched()
    {
        return Recheds;
    }

    public List<Beys> Bit()
    {
        return Bits;
    }
}

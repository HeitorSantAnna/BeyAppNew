using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    /*#region Lista das partes dos beys

    //Aqui fica a Blade dos BX
    List<Beys> BladeBxs = new List<Beys>();

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

        //Aqui ficam as LockChips
        Addressables.LoadAssetsAsync<Beys>("Chip", locks => LockChips.Add(locks)).Completed += OnLoaded;

        //Aqui ficam as over Blades
        Addressables.LoadAssetsAsync<Beys>("Over", overs => OverBlades.Add(overs)).Completed += OnLoaded;

        //Aqui ficam as Main Blades
        Addressables.LoadAssetsAsync<Beys>("Main", mains => mainBlades.Add(mains)).Completed += OnLoaded;

        //Aqui ficam as Assist Blades
        Addressables.LoadAssetsAsync<Beys>("Assist", assist => AssistBlades.Add(assist)).Completed += OnLoaded;

        //Aqui ficam as UX Blades
        Addressables.LoadAssetsAsync<Beys>("UX", ux => BladeUxs.Add(ux)).Completed += OnLoaded;
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

    public List<Beys> LChip()
    {
        return LockChips;
    }

    public List<Beys> OBlade()
    {
        return OverBlades;
    }

    public List<Beys> MB()
    {
        return mainBlades;
    }

    public List<Beys> ABlade()
    {
        return AssistBlades;
    }

    public List<Beys> UXBlade()
    {
        return BladeUxs;
    }*/
}

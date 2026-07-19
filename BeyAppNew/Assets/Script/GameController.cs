using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    #region Lista das partes dos beys

    //Aqui fica a Blade dos BX, UX e CX
    List<Blade> Blades = new List<Blade>();

    //Aqui fica os Lock Chips
    List<Chip> LockChips = new List<Chip>();

    //Aqui fica as Over Blades
    List<OverBlade> OverBlades = new List<OverBlade>();

    //Aqui fica as Assist Blades
    List<AssistBlade> AssistBlades = new List<AssistBlade>();

    //Aqui ficam as Recheds
    List<Recheds> Recheds = new List<Recheds>();

    //Aqui ficam as Bits
    List<Bits> Bits = new List<Bits>();

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
        Addressables.LoadAssetsAsync<Blade>("BX", bladeb => Blades.Add(bladeb)).Completed += OnLoadedBlade;

        //Aqui ficam as Recheds
        Addressables.LoadAssetsAsync<Recheds>("Reched", reched => Recheds.Add(reched)).Completed += OnLoadedReched;

        //Aqui ficam as bits
        Addressables.LoadAssetsAsync<Bits>("Bit", bit => Bits.Add(bit)).Completed += OnLoadedBit;

        //Aqui ficam as LockChips
        Addressables.LoadAssetsAsync<Chip>("Chip", locks => LockChips.Add(locks)).Completed += OnLoadedChip;

        //Aqui ficam as over Blades
        Addressables.LoadAssetsAsync<OverBlade>("Over", overs => OverBlades.Add(overs)).Completed += OnLoadedOver;

        //Aqui ficam as Main Blades
        Addressables.LoadAssetsAsync<Blade>("Main", mains => Blades.Add(mains)).Completed += OnLoadedBlade;

        //Aqui ficam as Assist Blades
        Addressables.LoadAssetsAsync<AssistBlade>("Assist", assist => AssistBlades.Add(assist)).Completed += OnLoadedAssist;

        //Aqui ficam as UX Blades
        Addressables.LoadAssetsAsync<Blade>("UX", ux => Blades.Add(ux)).Completed += OnLoadedBlade;
    }

    void OnLoadedAssist(AsyncOperationHandle<IList<AssistBlade>> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    void OnLoadedBlade(AsyncOperationHandle<IList<Blade>> handle)
    {
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    void OnLoadedOver(AsyncOperationHandle<IList<OverBlade>> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    void OnLoadedReched(AsyncOperationHandle<IList<Recheds>> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    void OnLoadedBit(AsyncOperationHandle<IList<Bits>> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    void OnLoadedChip(AsyncOperationHandle<IList<Chip>> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Debug.Log($"Tudo foi carregado");
        }
    }

    public List<Blade> Blade()
    {
        return Blades;
    }

    public List<Recheds> Reched()
    {
        return Recheds;
    }

    public List<Bits> Bit()
    {
        return Bits;
    }

    public List<Chip> LChip()
    {
        return LockChips;
    }

    public List<OverBlade> OBlade()
    {
        return OverBlades;
    }

    public List<AssistBlade> ABlade()
    {
        return AssistBlades;
    }
}

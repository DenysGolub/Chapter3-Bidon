using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class LoadAssetBundle : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadAsset());
    }

    IEnumerator LoadAsset()
    {
        string url = "http://localhost/assetbundles/sword-dlc"; 

        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Failed to load bundle: " + www.error);
            yield break;
        }

        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
        if (bundle == null)
        {
            Debug.LogError("Bundle is null");
            yield break;
        }

        var prefab = bundle.LoadAsset<GameObject>("Dydder_Astro_UTTVM_Sword"); 
        if (prefab != null)
        {
            Instantiate(prefab);
        }
        else
        {
            Debug.LogError("Asset not found in bundle");
        }
    }
}

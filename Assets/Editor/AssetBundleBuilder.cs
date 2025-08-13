using UnityEditor;

public class AssetBundleBuilder
{
    [MenuItem("Custom/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
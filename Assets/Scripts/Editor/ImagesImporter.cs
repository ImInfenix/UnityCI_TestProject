using UnityEngine;
using UnityEditor;

public class ImagesImporter : AssetPostprocessor
{
    void OnPreprocessTexture()
    {
        TextureImporter textureImporter = (TextureImporter)assetImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
        textureImporter.filterMode = FilterMode.Point;
        textureImporter.textureCompression = TextureImporterCompression.Uncompressed;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace BudShopPlayerData
{
    public enum AppearanceType
    {
        HairColor = 0,
        SkinColor = 1,
        Hats = 2
    }

    [CreateAssetMenu]

    public class AppearanceProfile : ScriptableObject
    {
        public Image listImage;
        public GameObject mesh;
        public Material material;
        public string textureID;
        public Texture texture;
        public AppearanceType type;
        public string appearanceName; //hat
        public string specifier; //sombrero
        public int cost;

    }
}

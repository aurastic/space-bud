using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BudShopPlayerData
{
    [CreateAssetMenu]

    public class AppearanceOptions : ScriptableObject
    {
        //lists of different appearance type profiles to instantiate in the panel, connects to panel 

        public List<AppearanceProfile> hats = new List<AppearanceProfile>();
        public List<AppearanceProfile> hairTexts = new List<AppearanceProfile>();
        public List<AppearanceProfile> skinTexts = new List<AppearanceProfile>();


    }
}


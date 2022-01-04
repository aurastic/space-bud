using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BudShopPlayerData
{
    public class PlayerAppearanceManager : MonoBehaviour
    {

        [SerializeField] private AppearanceOptions options;

        private AppearanceProfile currentHairColor;
        private AppearanceProfile currentSkinColor;
        private AppearanceProfile currentHat;

        private void OnEnable()
        {
            ResetAppearance();

        }

        //assigns the appearance to the player, connects with player appearance obect (current so data) and list controller
        public void AssignNewAppearance(AppearanceProfile newAppearanceData) //once list item is selected, go here
        {

            if (newAppearanceData.type == AppearanceType.Hats)
            {
                currentHat.mesh.SetActive(false);
                newAppearanceData.mesh.SetActive(true);
                currentHat = newAppearanceData;

            }

            else if (newAppearanceData.type == AppearanceType.HairColor)
            {
                currentHairColor.material.SetTexture(Shader.PropertyToID(newAppearanceData.textureID), newAppearanceData.texture);
                currentHairColor = newAppearanceData;
            }
            else if (newAppearanceData.type == AppearanceType.SkinColor)
            {
                currentSkinColor.material.SetTexture(Shader.PropertyToID(newAppearanceData.textureID), newAppearanceData.texture);
                currentSkinColor = newAppearanceData;
            }


        }

        public void ResetAppearance()
        {

            currentHairColor = options.hairTexts[0];
            currentHat = options.hats[0];
            currentSkinColor = options.skinTexts[0];
        }
    }

}

//Copyright © 2022 Alex Reid (R.M.P.)

//This file is part of Space Bud.

//Space Bud is free software: you can redistribute it and/or modify it
//under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License,
//or (at your option) any later version.

//Space Bud is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty
//of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public
//License along with Space Bud. If not, see <https://www.gnu.org/licenses/>.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceBudPlayerData
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

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

using UnityEngine.UI;
using UnityEngine;
using SpaceBudCore;

namespace SpaceBudInteraction
{
    public class InteractionVisualCueManager : MonoBehaviour
    {
        
        private Image image;
        [SerializeField] private Sprite unselectedSprite;
        [SerializeField] private Sprite selectedSprite;
        
        private bool isEnabled;

        private void Awake()
        {
            image = GetComponentInChildren<Image>();
        }

        private void OnEnable()
        {
            image.enabled = false;
            isEnabled = false;
            
           
            InteractionEventManager.onSelectionChange += t => ShowSelectionSprite(t);
        }

        private void OnDisable()
        {
            InteractionEventManager.onSelectionChange -= t => ShowSelectionSprite(t);
        }


        public void ShowSelectionSprite(Transform t)
        {
            if(transform == t)
            {
                image.sprite = selectedSprite;
            }
            else
            {
                image.sprite = unselectedSprite;
            }
        }
      

        public void ToggleImage()
        {
            if(isEnabled)
            {
                image.enabled = false;
                isEnabled = false;
            }
            else
            {
                image.enabled = true;
                isEnabled = true;
            }
        }


    }
}



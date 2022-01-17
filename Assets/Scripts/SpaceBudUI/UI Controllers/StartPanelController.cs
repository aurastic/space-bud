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
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class StartPanelController : MonoBehaviour
{
    private Button startButton;
    private bool isGameSceneLoaded;

    private void OnEnable()
    {
        isGameSceneLoaded = false;
        startButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("new-game-button");
        startButton.RegisterCallback<PointerUpEvent>(ev => StartGame());
    }
    private void StartGame()
    {
        if(!isGameSceneLoaded)
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("Entrance Room");

            Debug.Log("loading game");
            isGameSceneLoaded = true;

        }
      

    }

    private void OnDisable()
    {
        startButton.UnregisterCallback<PointerUpEvent>(ev => StartGame());
    }
}

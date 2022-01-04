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

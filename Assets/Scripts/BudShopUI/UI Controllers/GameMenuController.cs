using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using BudShopCore;



namespace BudShopUI
{
    public class GameMenuController : MonoBehaviour
    {
        private Button appearance;
        private Button queue;
        private Button exit;

        [SerializeField] private GameObject appearancePanelObj;
        [SerializeField] private GameObject queuePanelObj;

        private GameObject _gameObject;
        private VisualElement _rootVisualElement;
        private SwitchPanelsStatic _panelSwitcher;

        private void Awake()
        {
            _panelSwitcher = GetComponent<SwitchPanelsStatic>();
            _gameObject = gameObject;
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
        }

        private void OnEnable()
        {  

            appearance = _rootVisualElement.Q<Button>("appearance-button");
            queue = _rootVisualElement.Q<Button>("queue-button");
            exit = _rootVisualElement.Q<Button>("close-game-menu-button");
            appearance.RegisterCallback<ClickEvent>(ev => _panelSwitcher.SwitchPanels(appearancePanelObj, true)); //opens a panel so that there is no access to the gameplay controls until the panel is closed
            queue.RegisterCallback<ClickEvent>(ev => _panelSwitcher.SwitchPanels(queuePanelObj, false));
            queue.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(_gameObject, true));
            exit.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(_gameObject, true));
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }
       
    }

}

using UnityEngine;
using UnityEngine.UIElements;
using BudShopCore;


namespace BudShopUI
{
    public class OverlayUIManager: MonoBehaviour
    {
        [SerializeField] IntegerObject patientCount;
        [SerializeField] IntegerObject fundsCount;

        [SerializeField] private GameObject gameMenu;

        
       

        //ui elements
        private Label patientCountLabel;
        private Label shopFundsLabel;
        private Label shopStateLabel;
        private Button gameMenuButton;

        private SwitchPanelsStatic _panelSwitcher;
        private VisualElement _rootVisualElement;

        private void Awake()
        {
            _panelSwitcher = GetComponent<SwitchPanelsStatic>();
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        }
        private void OnEnable()
        {
            _panelSwitcher.SwitchPanels(gameObject, false);

            patientCountLabel = _rootVisualElement.Q<Label>("new-pt-count");
            shopFundsLabel = _rootVisualElement.Q<Label>("shop-funds-count");
            shopStateLabel = _rootVisualElement.Q<Label>("shop-state-label");


            gameMenuButton = _rootVisualElement.Q<Button>("game-menu-button");


            gameMenuButton.RegisterCallback<ClickEvent>(ev => _panelSwitcher.SwitchPanels(gameMenu, false)); //no unity event needed since click event sends message
            

            UpdateValues();

           
        }

        private void UpdateValues()
        {
            shopFundsLabel.text = "$ " + fundsCount.value.ToString();
            shopStateLabel.text = "TBD";
            patientCountLabel.text = patientCount.value.ToString();
        }
    }
}


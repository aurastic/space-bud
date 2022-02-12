
using UnityEngine.UIElements;
using SpaceBudPlayerData;

namespace SpaceBudUI
{
    public class AppearanceEntryController
    {
        private Label name;
        private VisualElement thumbnail;

        public void SetVisualElements(VisualElement listEntryAsset)
        {
            name = listEntryAsset.Q<Label>("name");
            thumbnail = listEntryAsset.Q<VisualElement>("thumbnail");
        }

        public void SetAppearanceData(AppearanceProfile appearanceData)
        {
            name.text = appearanceData.appearanceName;
            thumbnail.style.backgroundImage = new StyleBackground(appearanceData.listImage);
        }
    }
}


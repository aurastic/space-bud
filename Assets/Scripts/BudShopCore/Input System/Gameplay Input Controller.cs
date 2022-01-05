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

// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controllers/Gameplay Input Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameplayInputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Gameplay Input Controller"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""1abaf7e3-e02d-44bb-bc6f-13d287bcea72"",
            ""actions"": [
                {
                    ""name"": ""Secondary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""e07d3ec8-d172-42ae-bf40-6418264c2188"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Second Finger Touch"",
                    ""type"": ""Button"",
                    ""id"": ""334e81f1-f809-4603-bc24-9372adf11159"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""87c43615-7a65-4ccb-9616-18d5713f14f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Click Position"",
                    ""type"": ""Value"",
                    ""id"": ""c38334c7-c7a4-4df6-abd0-7f50d60ca336"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""cdda471f-4fbf-491b-9768-eef8a885ad47"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3c8e7c7f-91f8-406a-8851-e31e2e24fe84"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Second Finger Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd5b24f1-687c-4ff6-ae33-9abfa7bf9d39"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""223cba44-23f9-4d61-80b5-963e10f2b813"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a60b9ca7-1198-4996-99bd-8583613ca61e"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e76b3494-7f94-440b-9b7c-3d78670dd8e4"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cd60ff3-e275-4f31-bd69-47251e9c4691"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e00d21a1-7a75-4de9-8a4b-b5b08bf09cae"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""652eae61-3297-4334-b48f-bc4eec611c4c"",
            ""actions"": [
                {
                    ""name"": ""UIClick"",
                    ""type"": ""Button"",
                    ""id"": ""b4d031b2-4339-49f2-ae12-446c5142ce56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83d20237-6e27-42a4-84b6-6861067160ad"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""UIClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f981e125-676e-4ce3-9bb5-6216f89b796e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""UIClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_SecondaryFingerPosition = m_Gameplay.FindAction("Secondary Finger Position", throwIfNotFound: true);
        m_Gameplay_SecondFingerTouch = m_Gameplay.FindAction("Second Finger Touch", throwIfNotFound: true);
        m_Gameplay_Click = m_Gameplay.FindAction("Click", throwIfNotFound: true);
        m_Gameplay_ClickPosition = m_Gameplay.FindAction("Click Position", throwIfNotFound: true);
        m_Gameplay_RightClick = m_Gameplay.FindAction("RightClick", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_UIClick = m_UI.FindAction("UIClick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_SecondaryFingerPosition;
    private readonly InputAction m_Gameplay_SecondFingerTouch;
    private readonly InputAction m_Gameplay_Click;
    private readonly InputAction m_Gameplay_ClickPosition;
    private readonly InputAction m_Gameplay_RightClick;
    public struct GameplayActions
    {
        private @GameplayInputController m_Wrapper;
        public GameplayActions(@GameplayInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Gameplay_SecondaryFingerPosition;
        public InputAction @SecondFingerTouch => m_Wrapper.m_Gameplay_SecondFingerTouch;
        public InputAction @Click => m_Wrapper.m_Gameplay_Click;
        public InputAction @ClickPosition => m_Wrapper.m_Gameplay_ClickPosition;
        public InputAction @RightClick => m_Wrapper.m_Gameplay_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @SecondaryFingerPosition.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondFingerTouch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondFingerTouch;
                @SecondFingerTouch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondFingerTouch;
                @SecondFingerTouch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSecondFingerTouch;
                @Click.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClick;
                @ClickPosition.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClickPosition;
                @ClickPosition.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClickPosition;
                @ClickPosition.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClickPosition;
                @RightClick.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
                @SecondFingerTouch.started += instance.OnSecondFingerTouch;
                @SecondFingerTouch.performed += instance.OnSecondFingerTouch;
                @SecondFingerTouch.canceled += instance.OnSecondFingerTouch;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ClickPosition.started += instance.OnClickPosition;
                @ClickPosition.performed += instance.OnClickPosition;
                @ClickPosition.canceled += instance.OnClickPosition;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_UIClick;
    public struct UIActions
    {
        private @GameplayInputController m_Wrapper;
        public UIActions(@GameplayInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @UIClick => m_Wrapper.m_UI_UIClick;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @UIClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnUIClick;
                @UIClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnUIClick;
                @UIClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnUIClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UIClick.started += instance.OnUIClick;
                @UIClick.performed += instance.OnUIClick;
                @UIClick.canceled += instance.OnUIClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondFingerTouch(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnClickPosition(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnUIClick(InputAction.CallbackContext context);
    }
}

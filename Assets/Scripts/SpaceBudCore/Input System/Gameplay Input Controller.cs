// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/SpaceBudCore/Input System/Gameplay Input Controller.inputactions'

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
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a4ec1a5b-62d0-4269-ad74-c662d077a255"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMove"",
                    ""type"": ""Value"",
                    ""id"": ""2d49add9-ecdc-4c3f-86e6-0ada52f2524c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftShoulder"",
                    ""type"": ""Button"",
                    ""id"": ""fbe156e5-eafe-46a9-a7c6-a2df02501fb1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightShoulder"",
                    ""type"": ""Button"",
                    ""id"": ""b10d65ad-9b7a-4f5a-930f-b73fa877962b"",
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
                    ""id"": ""737a1b17-788c-47e1-b6ad-a0b4fbab7b4b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""83e7e9f7-685a-449f-ae44-cdfff1f299b7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c08dbd76-86b4-4317-8a42-440ddb9cbf2f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8cd5f14-8d64-4640-a9ab-8cf3584b2083"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e8becf8-d199-48a8-ae9f-a178fe3649a2"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightShoulder"",
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
                },
                {
                    ""name"": ""UIMove"",
                    ""type"": ""Value"",
                    ""id"": ""b248662d-bde9-418c-9657-df692df61565"",
                    ""expectedControlType"": ""Vector2"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""3eef3fff-6a9b-4688-a81c-e90ad417e1e8"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UIClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b32a251-ad05-480b-9cc7-7c4a083aed48"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UIMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8019ef0-936c-45ab-a0fc-b096a4dad641"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UIMove"",
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
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_CameraMove = m_Gameplay.FindAction("CameraMove", throwIfNotFound: true);
        m_Gameplay_LeftShoulder = m_Gameplay.FindAction("LeftShoulder", throwIfNotFound: true);
        m_Gameplay_RightShoulder = m_Gameplay.FindAction("RightShoulder", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_UIClick = m_UI.FindAction("UIClick", throwIfNotFound: true);
        m_UI_UIMove = m_UI.FindAction("UIMove", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_CameraMove;
    private readonly InputAction m_Gameplay_LeftShoulder;
    private readonly InputAction m_Gameplay_RightShoulder;
    public struct GameplayActions
    {
        private @GameplayInputController m_Wrapper;
        public GameplayActions(@GameplayInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Gameplay_SecondaryFingerPosition;
        public InputAction @SecondFingerTouch => m_Wrapper.m_Gameplay_SecondFingerTouch;
        public InputAction @Click => m_Wrapper.m_Gameplay_Click;
        public InputAction @ClickPosition => m_Wrapper.m_Gameplay_ClickPosition;
        public InputAction @RightClick => m_Wrapper.m_Gameplay_RightClick;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @CameraMove => m_Wrapper.m_Gameplay_CameraMove;
        public InputAction @LeftShoulder => m_Wrapper.m_Gameplay_LeftShoulder;
        public InputAction @RightShoulder => m_Wrapper.m_Gameplay_RightShoulder;
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
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @CameraMove.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMove;
                @CameraMove.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMove;
                @CameraMove.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCameraMove;
                @LeftShoulder.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftShoulder;
                @LeftShoulder.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftShoulder;
                @LeftShoulder.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLeftShoulder;
                @RightShoulder.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightShoulder;
                @RightShoulder.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightShoulder;
                @RightShoulder.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRightShoulder;
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
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @CameraMove.started += instance.OnCameraMove;
                @CameraMove.performed += instance.OnCameraMove;
                @CameraMove.canceled += instance.OnCameraMove;
                @LeftShoulder.started += instance.OnLeftShoulder;
                @LeftShoulder.performed += instance.OnLeftShoulder;
                @LeftShoulder.canceled += instance.OnLeftShoulder;
                @RightShoulder.started += instance.OnRightShoulder;
                @RightShoulder.performed += instance.OnRightShoulder;
                @RightShoulder.canceled += instance.OnRightShoulder;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_UIClick;
    private readonly InputAction m_UI_UIMove;
    public struct UIActions
    {
        private @GameplayInputController m_Wrapper;
        public UIActions(@GameplayInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @UIClick => m_Wrapper.m_UI_UIClick;
        public InputAction @UIMove => m_Wrapper.m_UI_UIMove;
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
                @UIMove.started -= m_Wrapper.m_UIActionsCallbackInterface.OnUIMove;
                @UIMove.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnUIMove;
                @UIMove.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnUIMove;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @UIClick.started += instance.OnUIClick;
                @UIClick.performed += instance.OnUIClick;
                @UIClick.canceled += instance.OnUIClick;
                @UIMove.started += instance.OnUIMove;
                @UIMove.performed += instance.OnUIMove;
                @UIMove.canceled += instance.OnUIMove;
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
        void OnMove(InputAction.CallbackContext context);
        void OnCameraMove(InputAction.CallbackContext context);
        void OnLeftShoulder(InputAction.CallbackContext context);
        void OnRightShoulder(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnUIClick(InputAction.CallbackContext context);
        void OnUIMove(InputAction.CallbackContext context);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/KeybardAndMouseControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @KeybardAndMouseControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @KeybardAndMouseControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KeybardAndMouseControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""ee7a8b1d-b003-41f9-8463-90133989aa7a"",
            ""actions"": [
                {
                    ""name"": ""KAM1"",
                    ""type"": ""Value"",
                    ""id"": ""9826913b-f9b4-4e4c-9014-72df57719bd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""KAM2"",
                    ""type"": ""Button"",
                    ""id"": ""67a60864-e6dd-45c8-a1ab-d0847c7ca615"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KAM3"",
                    ""type"": ""Button"",
                    ""id"": ""6e5d7e1e-0c2e-4f10-87d1-aeea6aa0b1b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KAM4"",
                    ""type"": ""Button"",
                    ""id"": ""ec9865d7-58d5-47c4-8fcb-23a34c9d15d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KAMA"",
                    ""type"": ""Button"",
                    ""id"": ""942b3d47-8749-4e8f-a1e6-7c8c7eb5a14d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KAMB"",
                    ""type"": ""Button"",
                    ""id"": ""1eec84c6-f325-49c1-98eb-3f0e7d4da0ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""KAMC"",
                    ""type"": ""Button"",
                    ""id"": ""d9e9122a-6722-4e9e-9afc-9d6adabeaab9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""350b929a-0562-4722-97ba-9986a23d48c9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAM1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e363915e-1b28-49d0-97a7-6a378ffc4701"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAM2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51de377a-0c7d-48d2-bb28-6e3fb3679276"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAM3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cff1fb72-3456-4fd4-8608-aa15c45f22fd"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAM4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d975ebfc-15ff-46db-a81c-93ee54fc3c16"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAMA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15c1fb1a-487d-41e1-abae-8eec946a46df"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c055f057-5c37-4029-9f98-ea92c6ef43a1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KAMC"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_KAM1 = m_Gameplay.FindAction("KAM1", throwIfNotFound: true);
        m_Gameplay_KAM2 = m_Gameplay.FindAction("KAM2", throwIfNotFound: true);
        m_Gameplay_KAM3 = m_Gameplay.FindAction("KAM3", throwIfNotFound: true);
        m_Gameplay_KAM4 = m_Gameplay.FindAction("KAM4", throwIfNotFound: true);
        m_Gameplay_KAMA = m_Gameplay.FindAction("KAMA", throwIfNotFound: true);
        m_Gameplay_KAMB = m_Gameplay.FindAction("KAMB", throwIfNotFound: true);
        m_Gameplay_KAMC = m_Gameplay.FindAction("KAMC", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_KAM1;
    private readonly InputAction m_Gameplay_KAM2;
    private readonly InputAction m_Gameplay_KAM3;
    private readonly InputAction m_Gameplay_KAM4;
    private readonly InputAction m_Gameplay_KAMA;
    private readonly InputAction m_Gameplay_KAMB;
    private readonly InputAction m_Gameplay_KAMC;
    public struct GameplayActions
    {
        private @KeybardAndMouseControls m_Wrapper;
        public GameplayActions(@KeybardAndMouseControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @KAM1 => m_Wrapper.m_Gameplay_KAM1;
        public InputAction @KAM2 => m_Wrapper.m_Gameplay_KAM2;
        public InputAction @KAM3 => m_Wrapper.m_Gameplay_KAM3;
        public InputAction @KAM4 => m_Wrapper.m_Gameplay_KAM4;
        public InputAction @KAMA => m_Wrapper.m_Gameplay_KAMA;
        public InputAction @KAMB => m_Wrapper.m_Gameplay_KAMB;
        public InputAction @KAMC => m_Wrapper.m_Gameplay_KAMC;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @KAM1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM1;
                @KAM1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM1;
                @KAM1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM1;
                @KAM2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM2;
                @KAM2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM2;
                @KAM2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM2;
                @KAM3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM3;
                @KAM3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM3;
                @KAM3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM3;
                @KAM4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM4;
                @KAM4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM4;
                @KAM4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAM4;
                @KAMA.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMA;
                @KAMA.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMA;
                @KAMA.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMA;
                @KAMB.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMB;
                @KAMB.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMB;
                @KAMB.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMB;
                @KAMC.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMC;
                @KAMC.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMC;
                @KAMC.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnKAMC;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KAM1.started += instance.OnKAM1;
                @KAM1.performed += instance.OnKAM1;
                @KAM1.canceled += instance.OnKAM1;
                @KAM2.started += instance.OnKAM2;
                @KAM2.performed += instance.OnKAM2;
                @KAM2.canceled += instance.OnKAM2;
                @KAM3.started += instance.OnKAM3;
                @KAM3.performed += instance.OnKAM3;
                @KAM3.canceled += instance.OnKAM3;
                @KAM4.started += instance.OnKAM4;
                @KAM4.performed += instance.OnKAM4;
                @KAM4.canceled += instance.OnKAM4;
                @KAMA.started += instance.OnKAMA;
                @KAMA.performed += instance.OnKAMA;
                @KAMA.canceled += instance.OnKAMA;
                @KAMB.started += instance.OnKAMB;
                @KAMB.performed += instance.OnKAMB;
                @KAMB.canceled += instance.OnKAMB;
                @KAMC.started += instance.OnKAMC;
                @KAMC.performed += instance.OnKAMC;
                @KAMC.canceled += instance.OnKAMC;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnKAM1(InputAction.CallbackContext context);
        void OnKAM2(InputAction.CallbackContext context);
        void OnKAM3(InputAction.CallbackContext context);
        void OnKAM4(InputAction.CallbackContext context);
        void OnKAMA(InputAction.CallbackContext context);
        void OnKAMB(InputAction.CallbackContext context);
        void OnKAMC(InputAction.CallbackContext context);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

namespace HeroicArcade.CC.Core
{
    public sealed class InputController : MonoBehaviour
    {
        KeybardAndMouseControls controls;
        private void Awake()
        {
            controls = new KeybardAndMouseControls();

            controls.Gameplay.KAMA.started += OnKeyAPressed;
            //controls.Gameplay.KAMA.performed += OnKeyAPressed;
            //controls.Gameplay.KAMA.canceled += OnKeyAPressed;

            controls.Gameplay.KAMB.started += OnKeyBPressed;
            //controls.Gameplay.KAMB.performed += OnKeyBPressed;
            //controls.Gameplay.KAMB.canceled += OnKeyBPressed;

            controls.Gameplay.KAM1.started += OnKey1Pressed;
            //controls.Gameplay.KAM1.performed += OnKey1Pressed;
            //controls.Gameplay.KAM1.canceled += OnKey1Pressed;

            controls.Gameplay.KAM2.started += OnKey2Pressed;
            //controls.Gameplay.KAM2.performed += OnKey2Pressed;
            //controls.Gameplay.KAM2.canceled += OnKey2Pressed;

            controls.Gameplay.KAM3.started += OnKey3Pressed;
            //controls.Gameplay.KAM3.performed += OnKey3Pressed;
            //controls.Gameplay.KAM3.canceled += OnKey3Pressed;

            controls.Gameplay.KAM4.started += OnKey4Pressed;
            //controls.Gameplay.KAM4.performed += OnKey4Pressed;
            //controls.Gameplay.KAM4.canceled += OnKey4Pressed;
        }

        [HideInInspector] public bool isKeyAPressed;
        private void OnKeyAPressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKeyAPressed " + context);
            isKeyAPressed = context.ReadValueAsButton();
        }

        [HideInInspector] public bool isKeyBPressed;
        private void OnKeyBPressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKeyBPressed " + context);
            isKeyBPressed = context.ReadValueAsButton();
        }

        [HideInInspector] public bool isKey1Pressed;
        private void OnKey1Pressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKey1Pressed " + context);
            isKey1Pressed = context.ReadValueAsButton();
        }

        [HideInInspector] public bool isKey2Pressed;
        private void OnKey2Pressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKey2Pressed " + context);
            isKey2Pressed = context.ReadValueAsButton();
        }

        [HideInInspector] public bool isKey3Pressed;
        private void OnKey3Pressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKey3Pressed " + context);
            isKey3Pressed = context.ReadValueAsButton();
        }

        [HideInInspector] public bool isKey4Pressed;
        private void OnKey4Pressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKey4Pressed " + context);
            isKey4Pressed = context.ReadValueAsButton();
        }

        private void OnEnable()
        {
            controls.Gameplay.Enable();
        }

        private void OnDisable()
        {
            controls.Gameplay.Disable();
        }
    }
}

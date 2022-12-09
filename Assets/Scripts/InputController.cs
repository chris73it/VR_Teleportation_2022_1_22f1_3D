using UnityEngine;
using UnityEngine.InputSystem;

namespace HeroicArcade.CC.Core
{
    public sealed class InputController : MonoBehaviour
    {
        public float upperLimit = 8f;
        public float lowerLimit = 7.25f;

        CraneMagnet craneMagnet;
        int vertDir = -1;

        Attach attach;
        public Transform ball;
        public Transform crane;
        public Transform cubeCollider;

        public Transform winner;

        KeybardAndMouseControls controls;

        private void Awake()
        {
            GameObject mainCrane = GameObject.Find("Main_Crane");
            craneMagnet = mainCrane.GetComponent<CraneMagnet>();

            attach = crane.GetComponent<Attach>();

            controls = new KeybardAndMouseControls();

            controls.Gameplay.KAMA.started += OnKeyWPressed;
            //controls.Gameplay.KAMA.performed += OnKeyAPressed;
            //controls.Gameplay.KAMA.canceled += OnKeyAPressed;

            controls.Gameplay.KAMB.started += OnKeyAPressed;
            //controls.Gameplay.KAMB.performed += OnKeyBPressed;
            //controls.Gameplay.KAMB.canceled += OnKeyBPressed;

            controls.Gameplay.KAMC.started += OnKeyDPressed;

            controls.Gameplay.KAM1.started += OnKeySPressed;
            //controls.Gameplay.KAM1.performed += OnKey1Pressed;
            //controls.Gameplay.KAM1.canceled += OnKey1Pressed;
        }

        [HideInInspector] public bool isKeyWPressed;
        private void OnKeyWPressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKeyWPressed " + context);
            isKeyWPressed = context.ReadValueAsButton();
            GameObject.Find("Columns").GetComponent<LowerGate_script>().lowerGate();
            //W
        }

        [HideInInspector] public bool isKeyDPressed;
        private void OnKeyDPressed(InputAction.CallbackContext context)
        {
            //Debug.Log("OnKeyAPressed " + context);
            isKeyDPressed = context.ReadValueAsButton();
            craneMagnet.craneLeft();
            //D
        }

         
        [HideInInspector] public bool isKeyAPressed;
        private void OnKeyAPressed(InputAction.CallbackContext context)
        {
            //Debug.Log("OnKeyAPressed " + context);
            isKeyAPressed = context.ReadValueAsButton();
            craneMagnet.craneRight();
            //A
        }

        //y = 11 (fully up); y = 7.1 (fully down)
        //S
        [HideInInspector] public bool isKeySPressed;
        private void OnKeySPressed(InputAction.CallbackContext context)
        {
            Vector3 tempPos = craneMagnet.transform.position;

            if (vertDir == -1)
            {
                if (craneMagnet.transform.position.y > lowerLimit)
                {
                    //Debug.Log("OnKey1Pressed " + context);
                    isKeySPressed = context.ReadValueAsButton();
                    craneMagnet.craneDown();
                }
                else
                {
                    tempPos.y = lowerLimit;
                    craneMagnet.transform.position = tempPos;
                    vertDir = +1;

                    if (attach.isBallAttached)
                    {
                        if (attach.isCubeCollider)
                        {
                            ball.parent = null;
                            winner.gameObject.SetActive(true);
                        }
                        else
                        {
                            ball.parent = crane.transform;
                        }
                    }
                }
            }
            else if (vertDir == +1)
            {
                if (craneMagnet.transform.position.y < upperLimit)
                {
                    //Debug.Log("OnKey1Pressed " + context);
                    isKeySPressed = context.ReadValueAsButton();
                    craneMagnet.craneUp();
                }
                else
                {
                    tempPos.y = upperLimit;
                    craneMagnet.transform.position = tempPos;
                    Debug.Log("Touched the Ball..!");
                    vertDir = -1;
                }
            }
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

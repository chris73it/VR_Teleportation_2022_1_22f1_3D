using UnityEngine;
using UnityEngine.InputSystem;

namespace HeroicArcade.CC.Core
{
    public sealed class InputController : MonoBehaviour
    {
        public float upperLimit = 8f;
        public float lowerLimit = 6.5f;

        CraneController craneControls;
       

        Attach attach;
        public Transform ball;
        public Transform magnet;
        public Transform cubeCollider;

        public Transform success;
        public Transform magnetOn;
        public Transform magnetOff;
        KeybardAndMouseControls controls;

        private void Awake()
        {                                                                           
            GameObject mainCrane = GameObject.Find("Main Crane");
            craneControls = mainCrane.GetComponent<CraneController>();

            attach = magnet.GetComponent<Attach>();

            controls = new KeybardAndMouseControls();

            controls.Gameplay.KAMA.started += OnKeyWPressed;
        

            controls.Gameplay.KAMB.started += OnKeyAPressed;
            

            controls.Gameplay.KAMC.started += OnKeyDPressed;

            controls.Gameplay.KAM1.started += OnKeySPressed;
        
        }

        [HideInInspector] public bool isKeyWPressed;
        private void OnKeyWPressed(InputAction.CallbackContext context)
        {
            Debug.Log("OnKeyWPressed " + context);
            isKeyWPressed = context.ReadValueAsButton();
            craneControls.craneUp();

        }

        [HideInInspector] public bool isKeyDPressed;
        private void OnKeyDPressed(InputAction.CallbackContext context)
        {
       
            isKeyDPressed = context.ReadValueAsButton();
            craneControls.craneLeft();

        }


        [HideInInspector] public bool isKeyAPressed;
        private void OnKeyAPressed(InputAction.CallbackContext context)
        {
            isKeyAPressed = context.ReadValueAsButton();
            craneControls.craneRight();

        }

 
        [HideInInspector] public bool isKeySPressed;
        private void OnKeySPressed(InputAction.CallbackContext context)
        {
            Vector3 tempPos = craneControls.transform.position;

           
                if (craneControls.transform.position.y > lowerLimit)
                {
               
                    isKeySPressed = context.ReadValueAsButton();
                    craneControls.craneDown();
                }
                else
                {
                    tempPos.y = lowerLimit;
                    craneControls.transform.position = tempPos;
             

                    if (attach.isBallAttached)
                    {
                        if (attach.isCubeCollider)
                        {
                            ball.parent = null;
                          
                        }
                        else
                        {
                            ball.parent = magnet.transform;
                        magnetOn.gameObject.SetActive(true);
                        magnetOff.gameObject.SetActive(false);
                        }
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

// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/DefaultControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DefaultControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultControls"",
    ""maps"": [
        {
            ""name"": ""CharControl"",
            ""id"": ""6b924206-0c33-456e-9d69-d4d424317bb9"",
            ""actions"": [
                {
                    ""name"": ""LeftStick"",
                    ""type"": ""Value"",
                    ""id"": ""bf957701-0e44-407d-a9b2-fccee8d5c1a1"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""5af1a018-5c23-4f7c-b572-182cbfda4033"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPad"",
                    ""type"": ""Value"",
                    ""id"": ""ecc42989-beea-48bf-9400-e1478c2fd253"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonA"",
                    ""type"": ""Button"",
                    ""id"": ""c33b42d7-39cd-486f-9eb3-890a708cbccb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonB"",
                    ""type"": ""Button"",
                    ""id"": ""ce1e551e-d4a1-4d2d-901d-902c785a94de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonX"",
                    ""type"": ""Button"",
                    ""id"": ""f20d1414-e5c5-44f2-a738-24bf67b2000a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonY"",
                    ""type"": ""Button"",
                    ""id"": ""7fa9b239-1ed2-4f3c-a81f-e56080f1e1b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""264462c5-e869-4fcc-b6a7-a9eaf70271f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""cca5c9e2-b537-4fe1-ac5c-2f788c4cb942"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShoulderL"",
                    ""type"": ""Button"",
                    ""id"": ""3eb0bbf3-1ff5-4a02-8c06-8b9612705d0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShoulderR"",
                    ""type"": ""Button"",
                    ""id"": ""90c6569c-5fbd-4bf6-aad1-ed312fc0673d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerL"",
                    ""type"": ""Button"",
                    ""id"": ""ba67843a-05ff-4469-bf20-223e6cd3f79d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerR"",
                    ""type"": ""Button"",
                    ""id"": ""63cfb680-d80b-4249-9277-1ef9c4e5e06c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""69382b86-dedd-4988-b44e-bc4e467dc0d3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3d07817-f2a1-4557-b85b-685659ad0760"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d6bbd31-6d95-443a-86db-4ee828438420"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e18f676e-a1db-4c8f-96f3-1afbf1deafa9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonA"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74a839e5-38d0-4619-91a9-667e243a0f8e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b633bc19-bd4b-4b62-87ee-68b4d49b015b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ba155c1-a9d2-4478-b868-5b989027e3fb"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""959c7d33-18a3-4269-b209-917d6e02d77b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d60e2a2-7b29-4174-a72f-7cc068d90ca9"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da21a542-622d-45a5-aeba-c87f852006f5"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShoulderL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1c594ab-e7c4-41a8-9bc5-70ec3fbcc326"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShoulderR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11464570-caf7-4d2a-aeba-b5ad230f10a4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11b0d1c1-9674-492b-969a-3f61af801d61"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharControl
        m_CharControl = asset.FindActionMap("CharControl", throwIfNotFound: true);
        m_CharControl_LeftStick = m_CharControl.FindAction("LeftStick", throwIfNotFound: true);
        m_CharControl_RightStick = m_CharControl.FindAction("RightStick", throwIfNotFound: true);
        m_CharControl_DPad = m_CharControl.FindAction("DPad", throwIfNotFound: true);
        m_CharControl_ButtonA = m_CharControl.FindAction("ButtonA", throwIfNotFound: true);
        m_CharControl_ButtonB = m_CharControl.FindAction("ButtonB", throwIfNotFound: true);
        m_CharControl_ButtonX = m_CharControl.FindAction("ButtonX", throwIfNotFound: true);
        m_CharControl_ButtonY = m_CharControl.FindAction("ButtonY", throwIfNotFound: true);
        m_CharControl_Start = m_CharControl.FindAction("Start", throwIfNotFound: true);
        m_CharControl_Select = m_CharControl.FindAction("Select", throwIfNotFound: true);
        m_CharControl_ShoulderL = m_CharControl.FindAction("ShoulderL", throwIfNotFound: true);
        m_CharControl_ShoulderR = m_CharControl.FindAction("ShoulderR", throwIfNotFound: true);
        m_CharControl_TriggerL = m_CharControl.FindAction("TriggerL", throwIfNotFound: true);
        m_CharControl_TriggerR = m_CharControl.FindAction("TriggerR", throwIfNotFound: true);
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

    // CharControl
    private readonly InputActionMap m_CharControl;
    private ICharControlActions m_CharControlActionsCallbackInterface;
    private readonly InputAction m_CharControl_LeftStick;
    private readonly InputAction m_CharControl_RightStick;
    private readonly InputAction m_CharControl_DPad;
    private readonly InputAction m_CharControl_ButtonA;
    private readonly InputAction m_CharControl_ButtonB;
    private readonly InputAction m_CharControl_ButtonX;
    private readonly InputAction m_CharControl_ButtonY;
    private readonly InputAction m_CharControl_Start;
    private readonly InputAction m_CharControl_Select;
    private readonly InputAction m_CharControl_ShoulderL;
    private readonly InputAction m_CharControl_ShoulderR;
    private readonly InputAction m_CharControl_TriggerL;
    private readonly InputAction m_CharControl_TriggerR;
    public struct CharControlActions
    {
        private @DefaultControls m_Wrapper;
        public CharControlActions(@DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftStick => m_Wrapper.m_CharControl_LeftStick;
        public InputAction @RightStick => m_Wrapper.m_CharControl_RightStick;
        public InputAction @DPad => m_Wrapper.m_CharControl_DPad;
        public InputAction @ButtonA => m_Wrapper.m_CharControl_ButtonA;
        public InputAction @ButtonB => m_Wrapper.m_CharControl_ButtonB;
        public InputAction @ButtonX => m_Wrapper.m_CharControl_ButtonX;
        public InputAction @ButtonY => m_Wrapper.m_CharControl_ButtonY;
        public InputAction @Start => m_Wrapper.m_CharControl_Start;
        public InputAction @Select => m_Wrapper.m_CharControl_Select;
        public InputAction @ShoulderL => m_Wrapper.m_CharControl_ShoulderL;
        public InputAction @ShoulderR => m_Wrapper.m_CharControl_ShoulderR;
        public InputAction @TriggerL => m_Wrapper.m_CharControl_TriggerL;
        public InputAction @TriggerR => m_Wrapper.m_CharControl_TriggerR;
        public InputActionMap Get() { return m_Wrapper.m_CharControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharControlActions set) { return set.Get(); }
        public void SetCallbacks(ICharControlActions instance)
        {
            if (m_Wrapper.m_CharControlActionsCallbackInterface != null)
            {
                @LeftStick.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnLeftStick;
                @LeftStick.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnLeftStick;
                @LeftStick.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnLeftStick;
                @RightStick.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnRightStick;
                @RightStick.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnRightStick;
                @RightStick.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnRightStick;
                @DPad.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnDPad;
                @DPad.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnDPad;
                @DPad.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnDPad;
                @ButtonA.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonA;
                @ButtonA.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonA;
                @ButtonA.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonA;
                @ButtonB.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonB;
                @ButtonB.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonB;
                @ButtonB.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonB;
                @ButtonX.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonX;
                @ButtonX.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonX;
                @ButtonX.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonX;
                @ButtonY.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonY;
                @ButtonY.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonY;
                @ButtonY.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnButtonY;
                @Start.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnSelect;
                @ShoulderL.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnShoulderL;
                @ShoulderL.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnShoulderL;
                @ShoulderL.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnShoulderL;
                @ShoulderR.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnShoulderR;
                @ShoulderR.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnShoulderR;
                @ShoulderR.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnShoulderR;
                @TriggerL.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnTriggerL;
                @TriggerL.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnTriggerL;
                @TriggerL.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnTriggerL;
                @TriggerR.started -= m_Wrapper.m_CharControlActionsCallbackInterface.OnTriggerR;
                @TriggerR.performed -= m_Wrapper.m_CharControlActionsCallbackInterface.OnTriggerR;
                @TriggerR.canceled -= m_Wrapper.m_CharControlActionsCallbackInterface.OnTriggerR;
            }
            m_Wrapper.m_CharControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftStick.started += instance.OnLeftStick;
                @LeftStick.performed += instance.OnLeftStick;
                @LeftStick.canceled += instance.OnLeftStick;
                @RightStick.started += instance.OnRightStick;
                @RightStick.performed += instance.OnRightStick;
                @RightStick.canceled += instance.OnRightStick;
                @DPad.started += instance.OnDPad;
                @DPad.performed += instance.OnDPad;
                @DPad.canceled += instance.OnDPad;
                @ButtonA.started += instance.OnButtonA;
                @ButtonA.performed += instance.OnButtonA;
                @ButtonA.canceled += instance.OnButtonA;
                @ButtonB.started += instance.OnButtonB;
                @ButtonB.performed += instance.OnButtonB;
                @ButtonB.canceled += instance.OnButtonB;
                @ButtonX.started += instance.OnButtonX;
                @ButtonX.performed += instance.OnButtonX;
                @ButtonX.canceled += instance.OnButtonX;
                @ButtonY.started += instance.OnButtonY;
                @ButtonY.performed += instance.OnButtonY;
                @ButtonY.canceled += instance.OnButtonY;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @ShoulderL.started += instance.OnShoulderL;
                @ShoulderL.performed += instance.OnShoulderL;
                @ShoulderL.canceled += instance.OnShoulderL;
                @ShoulderR.started += instance.OnShoulderR;
                @ShoulderR.performed += instance.OnShoulderR;
                @ShoulderR.canceled += instance.OnShoulderR;
                @TriggerL.started += instance.OnTriggerL;
                @TriggerL.performed += instance.OnTriggerL;
                @TriggerL.canceled += instance.OnTriggerL;
                @TriggerR.started += instance.OnTriggerR;
                @TriggerR.performed += instance.OnTriggerR;
                @TriggerR.canceled += instance.OnTriggerR;
            }
        }
    }
    public CharControlActions @CharControl => new CharControlActions(this);
    public interface ICharControlActions
    {
        void OnLeftStick(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnDPad(InputAction.CallbackContext context);
        void OnButtonA(InputAction.CallbackContext context);
        void OnButtonB(InputAction.CallbackContext context);
        void OnButtonX(InputAction.CallbackContext context);
        void OnButtonY(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnShoulderL(InputAction.CallbackContext context);
        void OnShoulderR(InputAction.CallbackContext context);
        void OnTriggerL(InputAction.CallbackContext context);
        void OnTriggerR(InputAction.CallbackContext context);
    }
}

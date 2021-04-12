// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Jugador"",
            ""id"": ""c8806e1a-b794-42c4-9541-edacf707e7f8"",
            ""actions"": [
                {
                    ""name"": ""Movimiento"",
                    ""type"": ""Value"",
                    ""id"": ""7fbe0386-df25-48af-ad13-91d87c9234c6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControlCamara"",
                    ""type"": ""Value"",
                    ""id"": ""31204ce9-8537-4cba-87cb-2d17c50e701f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Atacar"",
                    ""type"": ""Button"",
                    ""id"": ""bfc54ee5-5a27-45ce-94fa-60e7fcdf084f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""3b39d978-c97e-47b1-bfca-e1ccd5ece041"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""aa024256-2938-49f6-9a1e-9b60b295e0c7"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""179136b6-7702-48ce-8536-aa727c47ae57"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4c81b844-996b-4388-936c-43412a1099c5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""760c48f0-9dfc-4b63-ba42-b311925d6f15"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f011fa65-429e-49c2-88ee-a058df5c3298"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b7440a59-5d57-4c0e-a6fd-d94b336429e7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimiento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ea5d192f-bf25-457c-a6f5-0b45eb2dae34"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d5764d76-eac1-4788-a594-83b7e38fa8ee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5e4a1e92-24b8-4433-abce-3a3ee7d85b81"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e0165a07-fa82-4bdf-a059-3ddbbb86173a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Movimiento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a6bbbb47-2722-4626-a924-613e173b843b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlCamara"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""095421ea-4e97-4881-aabe-ebd2ff203b1b"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""ControlCamara"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""10953d07-2fa9-4e7d-8f2b-b18dfe8f0962"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""ControlCamara"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""85aa8d3b-a147-4e7d-87ef-510161cfa3b0"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""ControlCamara"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3883b196-ddb2-4d29-ba66-7e69d541d21a"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""ControlCamara"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e4ee0549-535b-449b-b350-5491fbc78b7c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""ControlCamara"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bed01eb-ee94-4772-af45-3050ed10ec0e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Atacar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec387d71-e2b7-4c37-bdb9-f510ed880606"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mando"",
            ""bindingGroup"": ""Mando"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Teclado y raton"",
            ""bindingGroup"": ""Teclado y raton"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Jugador
        m_Jugador = asset.FindActionMap("Jugador", throwIfNotFound: true);
        m_Jugador_Movimiento = m_Jugador.FindAction("Movimiento", throwIfNotFound: true);
        m_Jugador_ControlCamara = m_Jugador.FindAction("ControlCamara", throwIfNotFound: true);
        m_Jugador_Atacar = m_Jugador.FindAction("Atacar", throwIfNotFound: true);
        m_Jugador_Dash = m_Jugador.FindAction("Dash", throwIfNotFound: true);
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

    // Jugador
    private readonly InputActionMap m_Jugador;
    private IJugadorActions m_JugadorActionsCallbackInterface;
    private readonly InputAction m_Jugador_Movimiento;
    private readonly InputAction m_Jugador_ControlCamara;
    private readonly InputAction m_Jugador_Atacar;
    private readonly InputAction m_Jugador_Dash;
    public struct JugadorActions
    {
        private @InputMaster m_Wrapper;
        public JugadorActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimiento => m_Wrapper.m_Jugador_Movimiento;
        public InputAction @ControlCamara => m_Wrapper.m_Jugador_ControlCamara;
        public InputAction @Atacar => m_Wrapper.m_Jugador_Atacar;
        public InputAction @Dash => m_Wrapper.m_Jugador_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Jugador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JugadorActions set) { return set.Get(); }
        public void SetCallbacks(IJugadorActions instance)
        {
            if (m_Wrapper.m_JugadorActionsCallbackInterface != null)
            {
                @Movimiento.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnMovimiento;
                @Movimiento.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnMovimiento;
                @Movimiento.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnMovimiento;
                @ControlCamara.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnControlCamara;
                @ControlCamara.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnControlCamara;
                @ControlCamara.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnControlCamara;
                @Atacar.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnAtacar;
                @Atacar.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnAtacar;
                @Atacar.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnAtacar;
                @Dash.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_JugadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimiento.started += instance.OnMovimiento;
                @Movimiento.performed += instance.OnMovimiento;
                @Movimiento.canceled += instance.OnMovimiento;
                @ControlCamara.started += instance.OnControlCamara;
                @ControlCamara.performed += instance.OnControlCamara;
                @ControlCamara.canceled += instance.OnControlCamara;
                @Atacar.started += instance.OnAtacar;
                @Atacar.performed += instance.OnAtacar;
                @Atacar.canceled += instance.OnAtacar;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public JugadorActions @Jugador => new JugadorActions(this);
    private int m_MandoSchemeIndex = -1;
    public InputControlScheme MandoScheme
    {
        get
        {
            if (m_MandoSchemeIndex == -1) m_MandoSchemeIndex = asset.FindControlSchemeIndex("Mando");
            return asset.controlSchemes[m_MandoSchemeIndex];
        }
    }
    private int m_TecladoyratonSchemeIndex = -1;
    public InputControlScheme TecladoyratonScheme
    {
        get
        {
            if (m_TecladoyratonSchemeIndex == -1) m_TecladoyratonSchemeIndex = asset.FindControlSchemeIndex("Teclado y raton");
            return asset.controlSchemes[m_TecladoyratonSchemeIndex];
        }
    }
    public interface IJugadorActions
    {
        void OnMovimiento(InputAction.CallbackContext context);
        void OnControlCamara(InputAction.CallbackContext context);
        void OnAtacar(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
}

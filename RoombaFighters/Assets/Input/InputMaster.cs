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
                    ""name"": ""Girar"",
                    ""type"": ""Value"",
                    ""id"": ""7fbe0386-df25-48af-ad13-91d87c9234c6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Acelerar"",
                    ""type"": ""Value"",
                    ""id"": ""9bc58c12-076f-4c25-9570-26142312ef26"",
                    ""expectedControlType"": """",
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
                    ""name"": ""1D Axis"",
                    ""id"": ""f40229d7-40e1-4918-b2ab-11f7d23151b4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Girar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""03d1b64b-5a7d-40e3-9605-1301cc2a4773"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Girar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6d5738db-5afc-4c4c-87dd-5aa4a9dc926b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Girar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1f0a4685-678b-488e-91fd-5c59adf6c288"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Girar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ac4cf5c8-224d-4e4b-ad34-74db12c58432"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Girar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a68855f0-3e04-45ae-baa3-645398acb898"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Girar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3bed01eb-ee94-4772-af45-3050ed10ec0e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Atacar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50bec631-d225-4a4a-8179-7b6df4bc69ee"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Atacar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec387d71-e2b7-4c37-bdb9-f510ed880606"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19fd0e5d-1dd7-47cb-a1a4-c2a139b901e6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""791d1afc-817f-4931-9580-d65bcdcd2de1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acelerar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4095a84f-3c2e-484f-92a7-25072a92181e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Acelerar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""94c93343-cd36-47f6-bd1f-535260441616"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y raton"",
                    ""action"": ""Acelerar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5ac040ce-f393-470c-961e-a3549f1fae8e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acelerar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bf5eed17-c727-445c-98d9-129f9045331b"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Acelerar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cbeeec60-54de-43e1-a17b-a804439426e9"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mando"",
                    ""action"": ""Acelerar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        m_Jugador_Girar = m_Jugador.FindAction("Girar", throwIfNotFound: true);
        m_Jugador_Acelerar = m_Jugador.FindAction("Acelerar", throwIfNotFound: true);
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
    private readonly InputAction m_Jugador_Girar;
    private readonly InputAction m_Jugador_Acelerar;
    private readonly InputAction m_Jugador_Atacar;
    private readonly InputAction m_Jugador_Dash;
    public struct JugadorActions
    {
        private @InputMaster m_Wrapper;
        public JugadorActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Girar => m_Wrapper.m_Jugador_Girar;
        public InputAction @Acelerar => m_Wrapper.m_Jugador_Acelerar;
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
                @Girar.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnGirar;
                @Girar.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnGirar;
                @Girar.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnGirar;
                @Acelerar.started -= m_Wrapper.m_JugadorActionsCallbackInterface.OnAcelerar;
                @Acelerar.performed -= m_Wrapper.m_JugadorActionsCallbackInterface.OnAcelerar;
                @Acelerar.canceled -= m_Wrapper.m_JugadorActionsCallbackInterface.OnAcelerar;
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
                @Girar.started += instance.OnGirar;
                @Girar.performed += instance.OnGirar;
                @Girar.canceled += instance.OnGirar;
                @Acelerar.started += instance.OnAcelerar;
                @Acelerar.performed += instance.OnAcelerar;
                @Acelerar.canceled += instance.OnAcelerar;
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
        void OnGirar(InputAction.CallbackContext context);
        void OnAcelerar(InputAction.CallbackContext context);
        void OnAtacar(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
}

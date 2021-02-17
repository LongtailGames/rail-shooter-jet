// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlaneControl"",
            ""id"": ""08fbb22c-0657-4f8b-bc53-ce7556d3c5ff"",
            ""actions"": [
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""6734a603-90f0-4554-a80a-e9b7522d8539"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f6127bfc-18a0-41fc-a357-b665b6ecf22f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3ad6ee62-aa48-4bbe-a09a-65d69e24c6e8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5e716239-c87d-47ed-96cf-19d7c8722a47"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""72016b54-be9c-44ea-afc0-e3908885ad57"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""381c3629-905e-486b-88ee-00c29ca9fda1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlaneControl
        m_PlaneControl = asset.FindActionMap("PlaneControl", throwIfNotFound: true);
        m_PlaneControl_Steer = m_PlaneControl.FindAction("Steer", throwIfNotFound: true);
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

    // PlaneControl
    private readonly InputActionMap m_PlaneControl;
    private IPlaneControlActions m_PlaneControlActionsCallbackInterface;
    private readonly InputAction m_PlaneControl_Steer;
    public struct PlaneControlActions
    {
        private @PlayerControls m_Wrapper;
        public PlaneControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steer => m_Wrapper.m_PlaneControl_Steer;
        public InputActionMap Get() { return m_Wrapper.m_PlaneControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlaneControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlaneControlActions instance)
        {
            if (m_Wrapper.m_PlaneControlActionsCallbackInterface != null)
            {
                @Steer.started -= m_Wrapper.m_PlaneControlActionsCallbackInterface.OnSteer;
                @Steer.performed -= m_Wrapper.m_PlaneControlActionsCallbackInterface.OnSteer;
                @Steer.canceled -= m_Wrapper.m_PlaneControlActionsCallbackInterface.OnSteer;
            }
            m_Wrapper.m_PlaneControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steer.started += instance.OnSteer;
                @Steer.performed += instance.OnSteer;
                @Steer.canceled += instance.OnSteer;
            }
        }
    }
    public PlaneControlActions @PlaneControl => new PlaneControlActions(this);
    public interface IPlaneControlActions
    {
        void OnSteer(InputAction.CallbackContext context);
    }
}

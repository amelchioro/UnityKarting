using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyInGameMenuManager : MonoBehaviour
{
    [Tooltip("Root GameObject of the menu used to toggle its activation")]
    public GameObject menuRoot;
    [Tooltip("Master volume when menu is open")]
    [Range(0.001f, 1f)]
    public float volumeWhenMenuOpen = 0.5f;
    [Tooltip("Toggle component for shadows")]
    public Toggle shadowsToggle;
    [Tooltip("Toggle component for framerate display")]
    public Toggle framerateToggle;
    [Tooltip("GameObject for the controls")]
    public GameObject controlImage;

    //PlayerInputHandler m_PlayerInputsHandler;
    FramerateCounter m_FramerateCounter;

    [SerializeField] AK.Wwise.Event OpenMenu;
    [SerializeField] AK.Wwise.Event CloseMenu;
    [SerializeField] AK.Wwise.State StateOpenMenu;
    [SerializeField] AK.Wwise.State StateCloseMenu;

    void Start()
    {
        //m_PlayerInputsHandler = FindObjectOfType<PlayerInputHandler>();
        //DebugUtility.HandleErrorIfNullFindObject<PlayerInputHandler, InGameMenuManager>(m_PlayerInputsHandler, this);

        m_FramerateCounter = FindObjectOfType<FramerateCounter>();
        //DebugUtility.HandleErrorIfNullFindObject<FramerateCounter, InGameMenuManager>(m_FramerateCounter, this);

        menuRoot.SetActive(false);

        shadowsToggle.isOn = QualitySettings.shadows != ShadowQuality.Disable;
        shadowsToggle.onValueChanged.AddListener(OnShadowsChanged);

        framerateToggle.isOn = m_FramerateCounter.uiText.gameObject.activeSelf;
        framerateToggle.onValueChanged.AddListener(OnFramerateCounterChanged);
    }

    private void Update()
    {

        if (Input.GetButtonDown(GameConstants.k_ButtonNamePauseMenu)
            || (menuRoot.activeSelf && Input.GetButtonDown(GameConstants.k_ButtonNameCancel)))
        {
            if (controlImage.activeSelf)
            {
                controlImage.SetActive(false);
                return;
            }

            SetPauseMenuActivation(!menuRoot.activeSelf);

        }

        if (Input.GetAxisRaw(GameConstants.k_AxisNameVertical) != 0)
        {
            if (EventSystem.current.currentSelectedGameObject == null)
            {
                EventSystem.current.SetSelectedGameObject(null);
                shadowsToggle.Select();
            }
        }
    }

    public void ClosePauseMenu()
    {
        SetPauseMenuActivation(false);
    }


    public void TogglePauseMenu()
    {
        SetPauseMenuActivation(!menuRoot.activeSelf);
    }
    void SetPauseMenuActivation(bool active)
    {
        menuRoot.SetActive(active);

        if (menuRoot.activeSelf)
        {
            //     Cursor.lockState = CursorLockMode.None;
            //  Cursor.visible = true;
            Time.timeScale = 0f;
            //  AudioUtility.SetMasterVolume(volumeWhenMenuOpen);
            StateOpenMenu.SetValue();
            OpenMenu.Post(gameObject);

            EventSystem.current.SetSelectedGameObject(null);
        }
        else
        {
            //   Cursor.lockState = CursorLockMode.Locked;
            //   Cursor.visible = false;
            Time.timeScale = 1f;
            //  AudioUtility.SetMasterVolume(1);
            StateCloseMenu.SetValue();
            CloseMenu.Post(gameObject);
        }

    }

    void OnShadowsChanged(bool newValue)
    {
        QualitySettings.shadows = newValue ? ShadowQuality.All : ShadowQuality.Disable;
    }

    void OnFramerateCounterChanged(bool newValue)
    {
        m_FramerateCounter.uiText.gameObject.SetActive(newValue);
    }

    public void OnShowControlButtonClicked(bool show)
    {
        controlImage.SetActive(show);
    }
}

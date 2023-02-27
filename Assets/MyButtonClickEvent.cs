using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyButtonClickEvent : MonoBehaviour
{
    [SerializeField] AK.Wwise.Event buttonClick;
    [SerializeField] AK.Wwise.Event buttonBack;
    [SerializeField] AK.Wwise.Event buttonControls;
    [SerializeField] AK.Wwise.Event buttonScreenshot;
    [SerializeField] AK.Wwise.State buttonStateOff;
    public void ButtonClicked()
    {
        buttonClick.Post(gameObject);
    }
    public void MenuBackClick() 
    { 
        buttonBack.Post(gameObject); 
    }

    public void MenuControls()
    {
        buttonControls.Post(gameObject);
    }

    public void MenuScreenshot()
    {
        buttonScreenshot.Post(gameObject);
    }
    
    public void MenuStateOff()
    {
        buttonStateOff.SetValue();
    }
}

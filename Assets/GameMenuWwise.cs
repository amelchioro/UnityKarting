using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuWwise : MonoBehaviour
{
    [SerializeField] AK.Wwise.Event OpenMenu;
    [SerializeField] AK.Wwise.Event CloseMenu;

    void ClosePauseMenu()
    {
        CloseMenu.Post(gameObject);
    }
}
/*
    private void Start()
    {
        cribbio = this.gameObject.GetComponent<InGameMenuManager>();

    }
    void cribbio.ClosePauseMenu()
    {
        CloseMenu.Post(gameObject);
    }
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;
    // Start is called before the first frame update
    void Start()
    {
        UIButtonHandler.OnStartButtonClicked += OnStartButtonClicked;
        UIButtonHandler.OnResetButtonClicked += OnResetButtonClicked;
    }

    private void OnResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }

    private void OnStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

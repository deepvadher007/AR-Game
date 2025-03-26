using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField] private Button StartButton;
    [SerializeField] private Button ShootButton;
    [SerializeField] private Button ResetButton;

    public static event Action OnStartButtonClicked;
    public static event Action OnShootButtonClicked;
    public static event Action OnResetButtonClicked;
    
    void Start()
    {
        StartButton.onClick.AddListener(StartButtonClicked);
        ShootButton.onClick.AddListener(ShootButtonClicked);
        ResetButton.onClick.AddListener(ResetButtonClicked);

        ShootButton.gameObject.SetActive(false);
    }

    void StartButtonClicked()
    {
        OnStartButtonClicked?.Invoke();
        StartButton.gameObject.SetActive(false );
        ShootButton.gameObject.SetActive(true );
    }
    void ShootButtonClicked()
    {
        OnShootButtonClicked?.Invoke();
    }
    void ResetButtonClicked()
    {
        OnResetButtonClicked?.Invoke();
        StartButton.gameObject.SetActive(true);
        ShootButton.gameObject.SetActive(false ) ;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

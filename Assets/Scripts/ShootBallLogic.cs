using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBallLogic : MonoBehaviour
{
    private Camera mainCam;

    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float ballForwardSpeed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        mainCam =FindAnyObjectByType<Camera>();
        UIButtonHandler.OnShootButtonClicked += ShootBallOnButton;
    }

    private void ShootBallOnButton()
    {
        Vector3 spawnPosition = mainCam.transform.position + mainCam.transform.forward * 0.1f;
        Quaternion spawnRotation = mainCam.transform.rotation;

        GameObject spawnedBall = Instantiate(ballPrefab, spawnPosition, spawnRotation);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(mainCam.transform.forward* ballForwardSpeed);
        }

        Destroy(spawnedBall, t:5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

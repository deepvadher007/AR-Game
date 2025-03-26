using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRbPositionOfObject : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private Vector3 rbStartPosition;
    private Quaternion rbStartRotation;

    // Start is called before the first frame update
    void Start()
    {
        UIButtonHandler.OnResetButtonClicked += ResetRbPositionOnButtonClicked;

        rbStartPosition = rb.transform.localPosition;
        rbStartRotation = rb.transform.localRotation;
    }

    private void ResetRbPositionOnButtonClicked()
    {
        rb.isKinematic = true;

        rb.transform.localPosition = rbStartPosition;
        rb.transform.localRotation = rbStartRotation;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

    private void OnDestroy()
    {
        UIButtonHandler.OnResetButtonClicked -= ResetRbPositionOnButtonClicked;
    }
}

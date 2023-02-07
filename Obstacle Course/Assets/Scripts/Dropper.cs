using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer MeshRenderer;
    Rigidbody Rigidbody;
    [SerializeField] private float _timeToWait = 3f;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        Rigidbody = GetComponent<Rigidbody>();

        MeshRenderer.enabled = false;
        Rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time  > _timeToWait)
        {
            StartDropping();
        }
    }

    void StartDropping()
    {
        Debug.Log(_timeToWait + " has elapsed");
        MeshRenderer.enabled = true;
        Rigidbody.useGravity = true;
    }
}

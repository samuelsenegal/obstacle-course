using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _xRotation = 1f;
    [SerializeField] private float _yRotation = 0f;
    [SerializeField] private float _zRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_xRotation, _yRotation, _zRotation);
    }
}

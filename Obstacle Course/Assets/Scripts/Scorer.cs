using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _bumps;
    private const string HIT = "Hit";

    // Start is called before the first frame update
    void Start()
    {
        _bumps = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(HIT))
        {
            _bumps++;
            Debug.Log("You have bumped into something: " + _bumps + " times.");
        }
    }
}

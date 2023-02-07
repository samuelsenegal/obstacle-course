using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private const string HIT = "Hit";
    private const string PLAYER = "Player";
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PLAYER))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = HIT;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _horizontal;
    [SerializeField] private float _vertical;
    [SerializeField] private int _speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game!");
        Debug.Log("This is an Obstacle Course");
        Debug.Log("Don't get caught lacking!!!");
    }

    void MovePlayer()
    {
        _horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
        _vertical = Input.GetAxis("Vertical") * Time.deltaTime * _speed;
        transform.Translate(_horizontal, 0, _vertical);
    }
}

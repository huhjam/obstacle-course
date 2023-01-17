using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float yValue = 0f;
    [SerializeField] float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1,0,0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    void PrintInstructions()
    {
        Debug.Log("Welcome to my obstacle course");
        Debug.Log("Move using the arrow keys");
        Debug.Log("Watch out for any obstacles!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}

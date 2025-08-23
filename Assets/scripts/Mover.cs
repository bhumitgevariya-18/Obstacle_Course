using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 10f;
    // These variables are to move the player
     //[SerializeField] float xValue = 0f;
     //[SerializeField] float yValue = 0.01f;
     //[SerializeField] float zValue = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer(); 
    }

    void  PrintInstructions()
    {
        Debug.Log("Welcome to the Game:-");
        Debug.Log("Move your player by arrow keys or WASD keys");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed ;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}

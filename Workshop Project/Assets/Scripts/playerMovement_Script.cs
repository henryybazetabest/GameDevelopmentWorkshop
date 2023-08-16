using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement_Script : MonoBehaviour
{


    [SerializeField] float _speed = 20f; // adjust for walking speed of character
    private float _horizontal;
    private float _vertical;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }


    private void MovePlayer()
    {
        // get input of player

        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");

        // set input into a vector 2 and normalize the vector (so player doesn't move faster at diagonals)
        Vector2 playerMovement = new Vector2(_horizontal, _vertical).normalized;

        // move player according to input and speed while being consistent to framerate
        transform.Translate(playerMovement * Time.deltaTime * _speed);
    }

}




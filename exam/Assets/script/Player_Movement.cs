using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Movement : MonoBehaviour
{




    public Vector3 G_MoveMent;


    public CharacterController CharacterController;



    // Start is called before the first frame update
    void Start()
    {






        
    }

    // Update is called once per frame
    void Update()
    {

        float X_Position = Input.GetAxis("Horizontal");
        float y_Position = Input.GetAxis("Vertical");


       G_MoveMent= X_Position * this.transform.right + y_Position * this.transform.forward;


        CharacterController.SimpleMove(G_MoveMent*5);














    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public saveObject so;



   public Animator animator;


    void Start()
    {
      








}




    

    





    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            screenManagement.save(so);
        }

        if(Input.GetKeyUp(KeyCode.P))
        {

           so= screenManagement.Load();

        
        }


        if(Input.GetKeyDown(KeyCode.K)) 
        {
       
        
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
      

        }
        if (Input.GetKeyDown(KeyCode.W))
        {


        }











    }


    public void leftGun()
    {
        animator.SetTrigger("GrabGun");


    }

    public void Walk()
    {
        animator.SetTrigger("walk");
    }
    public void HoidGun()
    {
        
            animator.SetTrigger("HoidGun");

        }










}

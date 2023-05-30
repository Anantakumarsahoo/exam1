using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{


    public Text MiddleText;

    public Camera cam;



    // Start is called before the first frame update
    void Start()
    {
        //    ray = new Ray(this.transform.position,transform.forward);

    }

    // Update is called once per framej
    void Update()
    {
        cheakforColiders();


        


    }
    Ray ray;
    RaycastHit hit;





    void cheakforColiders()
    {

        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                print(hit.transform.name);

                MiddleText.text = hit.transform.name;
            }

        }


    }
}


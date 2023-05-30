using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraContraller : MonoBehaviour
{
    // Start is called before the first frame update
    public float mousesensancativity = 20f;
    public Transform playerbody;
    float xrotation;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mousesensancativity * Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mousesensancativity * Time.deltaTime;


        xrotation -= mousey;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mousex);



    }


    public void OnApplicationQuit()
    {
        Application.Quit();
    }






}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunchange : MonoBehaviour
{

    public GameObject[] guns;


    public GameObject[] gunPrefab;

   





    // Start is called before the first frame update
    void Start()
    {
        creatGun();

    }

    // Update is called once per frame
    void Update()
    {








        
    }
    int num1;

    void creatGun()
    {

        for (int i = 0; i < guns.Length; i++)
        {


            gunPrefab[i] = Instantiate(guns[i]) as GameObject;

            gunPrefab[i].gameObject.SetActive(false);

            gunPrefab[i].transform.parent = transform;

        }










    }










}

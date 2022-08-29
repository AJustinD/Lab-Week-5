using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    int rand;

    private Transform[] transArray;

    // Start is called before the first frame update
    void Start()
    {
        transArray = new Transform[2];
        transArray[0] = GameObject.FindWithTag("Red").GetComponent<Transform>();
        transArray[1] = GameObject.FindWithTag("Blue").GetComponent<Transform>();
        rand = Random.Range(51, 251);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown("w"))
        {
            transArray[0].transform.Rotate(0.0f, 0.0f, 45.0f);
            transArray[1].transform.Rotate(0.0f, 0.0f, -45.0f);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            transArray[0].transform.position = new Vector3(2, -1, 0);
            transArray[1].transform.position = new Vector3(-2, 1, 0);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            Renderer rendRedObj = GameObject.FindWithTag("Red").GetComponent<Renderer>();
            rendRedObj.material.color = new Color(rand, 0.0f, 0.0f);

            Renderer rendBlueObj = GameObject.FindWithTag("Blue").GetComponent<Renderer>();
            rendRedObj.material.color = new Color(0.0f, 0.0f, rand);

            Debug.Log("Red: " + rendRedObj.material.color);
            Debug.Log("Blue: " + rendBlueObj.material.color);
        }
    }
}

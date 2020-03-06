using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //making basic, forward, backward, left and right movement
        if(Input.GetKey("w")) {
          transform.position += Vector3.forward * Time.deltaTime * 5;
        }
        if(Input.GetKey("a")) {
          transform.position += Vector3.left * Time.deltaTime * 5;
        }
        if(Input.GetKey("s")) {
          transform.position += Vector3.back * Time.deltaTime * 5;
        }
        if(Input.GetKey("d")) {
          transform.position += Vector3.right * Time.deltaTime * 5;
        }

        //making Q and E do rotation left and right
        if(Input.GetKey("q")) {
          transform.position += Vector3.forward * Time.deltaTime;
        }
        if(Input.GetKey("e")) {
          transform.position += Vector3.forward * Time.deltaTime;
        }

    }
}

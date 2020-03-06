using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //making basic, forward, backward, left and right movement
        if(Input.GetKey("w")) {
          if(Input.GetKey(KeyCode.LeftShift)) {
            transform.position += Vector3.forward * Time.deltaTime * 20;
          } else {
            transform.position += Vector3.forward * Time.deltaTime * 10;
          }
        }
        if(Input.GetKey("a")) {
          transform.position += Vector3.left * Time.deltaTime * 10;
        }
        if(Input.GetKey("s")) {
          transform.position += Vector3.back * Time.deltaTime * 10;
        }
        if(Input.GetKey("d")) {
          transform.position += Vector3.right * Time.deltaTime * 10;
        }

        //making Q and E do rotation left and right
        if(Input.GetKey("q")) {
          transform.Rotate(0, -Time.deltaTime * 100,0, Space.Self);
        }
        if(Input.GetKey("e")) {
          transform.Rotate(0, Time.deltaTime * 100,0, Space.Self);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var hMove=Input.GetAxis("Horizontal");
        var vMove = Input.GetAxis("Vertical");

        this.transform.Translate(Vector3.right * hMove * Time.deltaTime);
        this.transform.Translate(Vector3.up * vMove * Time.deltaTime);
    }
}

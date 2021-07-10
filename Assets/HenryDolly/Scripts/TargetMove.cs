using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    public float speed = 3f;

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Vector3 dir = v * Vector3.forward + h * Vector3.right;

        print(dir);
        transform.position += dir * speed * Time.deltaTime;
        
    }

    public void MoveToPosition(Transform pos){
        transform.position = pos.position;
    }
}

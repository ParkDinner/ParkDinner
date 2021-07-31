using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth_revolution : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.Rotate(Vector3.down*160f * Time.deltaTime);    //지구 자전
    }
}

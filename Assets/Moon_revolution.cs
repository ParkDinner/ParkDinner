using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moon_revolution : MonoBehaviour
{
    public Vector3 CentralMass; //질량 중심 변수
    Transform trans;
    public GameObject planet;

    float x;
    float z;

    void Start()
    {
        trans = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        x = (trans.position.x + 81 * planet.transform.position.x) / 82;
        z = (trans.position.z + 81 * planet.transform.position.z) / 82;
        CentralMass = new Vector3(x, 0, z);
        trans.RotateAround(CentralMass, Vector3.down, 10f * Time.deltaTime); //질량 중심을 축으로 회전
    }

}

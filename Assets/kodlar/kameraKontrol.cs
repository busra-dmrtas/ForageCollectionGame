using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakiMesafe;

    // Start is called before the first frame update
    void Start()
    {
        aradakiMesafe=transform.position-top.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position=top.transform.position+aradakiMesafe;
        //lateUpdate taþýdýk
    }
    private void LateUpdate()
    {
        transform.position = top.transform.position + aradakiMesafe;
    }
}

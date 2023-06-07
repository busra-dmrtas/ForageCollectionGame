using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TopKodlar : MonoBehaviour
{
    Rigidbody rb;
    public int hiz;
    int puan;

    public TextMeshProUGUI skor;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 v = new Vector3(yatay, 0, dikey);
        rb.AddForce (v*hiz);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tag_yem")
        {
            Destroy(other.gameObject);
            puan++;
            skor.text = "Puan: " + puan;
            Debug.Log(puan);
            if (puan == 11)
            {
                skor.text = "OYUN BÝTTÝ";
                UnityEditor.EditorApplication.isPlaying = false;
            }
        }else if (other.gameObject.tag == "Finish")
        {
            Destroy(other.gameObject);
            skor.text = "OYUN BÝTTÝ";
            UnityEditor.EditorApplication.isPlaying = false;
        }

    }
}

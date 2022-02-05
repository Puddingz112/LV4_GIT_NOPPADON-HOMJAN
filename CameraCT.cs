using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCT : MonoBehaviour
{
    private Vector3 offset;
    public GameObject Fastestball;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Fastestball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Fastestball.transform.position + offset;
    }
}

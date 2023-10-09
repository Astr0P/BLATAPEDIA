using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotate : MonoBehaviour
{
    // Start is called before the first frame update

    Quaternion rotation;

    void Awake()
    {
        rotation = transform.rotation;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.rotation = rotation;
    }
}

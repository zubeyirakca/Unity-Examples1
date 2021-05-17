using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleCube : MonoBehaviour
{
    Vector3 temp;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PuanBar()
    {
        temp = transform.localScale;
        temp.y += Time.deltaTime;
        transform.localScale = temp;
    }
}

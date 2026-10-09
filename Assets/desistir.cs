using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desistir : MonoBehaviour
{
    public Rigidbody variavel;
    void Start()
    {
                
    }

    void Update()
    {
        variavel.linearVelocity = new Vector3(0, 0, 10f);
    }        
}

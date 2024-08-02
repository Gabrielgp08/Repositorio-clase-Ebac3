using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola Mundo - start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning("Hola Mundo - Update");
    }
    private void FixedUpdate()
    {
        Debug.LogError("Hola Mundo - FixedUpdate");
    }
}

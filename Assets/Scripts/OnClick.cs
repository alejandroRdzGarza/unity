using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject objeto;
    public static string text;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        text = objeto.name;
        Debug.Log(text);
        Debug.Log("hola");
        
    }
}

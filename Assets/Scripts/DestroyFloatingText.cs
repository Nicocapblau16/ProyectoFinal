using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFloatingText : MonoBehaviour
{
    //intento de hacer aparecer la precisión en pantalla (no aplicado)
    public float destroyTime = 1.5f;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }


}

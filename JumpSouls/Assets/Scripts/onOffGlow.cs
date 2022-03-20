using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOffGlow : MonoBehaviour
{
    MeshRenderer meshrenderer;
    bool powerTime;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (powerTime)
        {
            meshrenderer.material.SetFloat("Vector1_24f9bbf227d04617b4e177b01f9a3a8f", meshrenderer.material.GetFloat("Vector1_24f9bbf227d04617b4e177b01f9a3a8f") + 0.3f);
            if (meshrenderer.material.GetFloat("Vector1_24f9bbf227d04617b4e177b01f9a3a8f") >= 5f)

                powerTime = false;
        }
        else
        {
            meshrenderer.material.SetFloat("Vector1_24f9bbf227d04617b4e177b01f9a3a8f", meshrenderer.material.GetFloat("Vector1_24f9bbf227d04617b4e177b01f9a3a8f") - 0.3f);
            if (meshrenderer.material.GetFloat("Vector1_24f9bbf227d04617b4e177b01f9a3a8f") <= 0)

                powerTime = true;


        }
    }
}

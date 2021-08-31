using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.IO;

public class BackgroundManager : MonoBehaviour
{

    // Start is called before the first frame update
    Material UIMaterial;
    void Start()
    {
        
        Renderer mRender = GetComponent<Renderer>();
        Cubemap UIBackground = new Cubemap(2048,TextureFormat.ARGB32,false);
        

        DynamicGI.UpdateEnvironment();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

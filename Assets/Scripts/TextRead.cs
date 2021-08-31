using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextRead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        ReadString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public TMPro.TMP_Text Header;

    public void ReadString()
    {
        string path = "Assets/Resources/Header/Header.txt";
        StreamReader reader = new StreamReader(path);
        Header.text = reader.ReadToEnd();
        
    }
}

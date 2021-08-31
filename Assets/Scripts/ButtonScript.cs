using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonScript : MonoBehaviour
{

    public int Index;
    public Material VideoMaterial;

    // Start is called before the first frame update

    void Awake()
    {
        Button myButton = GetComponent<Button>();
      // myButton.onClick.AddListener((UnityEngine.Events.UnityAction)this.OnClick);
      myButton.onClick.AddListener(OnClick);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        
      
    }


    
}

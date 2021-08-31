using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
 
  
    public Material skyBox = null;
    int index = 1;
  
    // Start is called before the first frame update
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        KeyboardInput();
        OculusInput();
    }

    private void LateUpdate()
    {
     
    }

    private void OculusInput()
    {
        

        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            //videoManager.PauseToggle();
             

        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
           // RenderSettings.skybox = skyBox;

        }
        
    }


    private void KeyboardInput()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            //videoManager.PauseToggle();

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           // videoManager.NextVideo();

        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            //videoManager.StartPrepare(index);

        }
    }

    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class CreateTexture : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Thumbnails;
    private VideoPlayer videoPlayer;

    VideoManager videoManager = new VideoManager();
    void Start()
    {
        videoPlayer.sendFrameReadyEvents = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

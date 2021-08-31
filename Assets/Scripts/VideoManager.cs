using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Linq;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;
public class VideoManager : MonoBehaviour
{
    public Material VideoMaterial;
    public Material DefaultSkybox;
    public GameObject prefab1;
    public Transform parent;
    int VideoIndex;
    public Sprite image;
    int PrefabNumber = 0;
    public static List<string> Background = new List<string>();
    public static List<string> Thumbnails = new List<string>();
    public static List<string> VideoURL = new List<string>();
    public Texture ImageBackground;
    
    
    
    // Start is called before the first frame update
   void Start()
    {

       StartCoroutine ("CreatePrefab");

    }

    // Update is called once per frame
    void Update()
    {


       


    }    

    private bool isPaused = false;
    private bool isVideoReady = false;
    public bool IsPaused
    {
        get
        {
            return isPaused;
        }

        set
        {

            isPaused = value;
        }

    }
    public bool IsVideoReady
    {
        get
        {
            return isVideoReady;
        }

        set
        {

            isVideoReady = value;
        }

    }
    private VideoPlayer videoPlayer = null;

    private void Awake()
    {
        Invoke(nameof(CreatePrefab), 1.5f);
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.prepareCompleted += OnComplete;
        videoPlayer.seekCompleted += OnComplete;



        //myButton.onClick.AddListener(OnClick);
    }
    private void OnDestroy()
    {
        
        videoPlayer.prepareCompleted -= OnComplete;
        videoPlayer.seekCompleted -= OnComplete;

    }

    public void PauseToggle()
    {
        isPaused = videoPlayer.isPlaying;

        if (isPaused)
        {
            videoPlayer.Pause();


        }


        else
            videoPlayer.Play();

    }


    public void NextVideo()
    {
       VideoIndex++;

        if (VideoIndex > VideoURL.Count-1)
            VideoIndex = 0;
        StartPrepare(VideoIndex);

    }

    public void PreviousVideo()
    {

      VideoIndex--;
        if (VideoIndex < 0)
        {
            VideoIndex = VideoURL.Count - 1;
        }
        StartPrepare(VideoIndex);
    }

    public void PlayVideo() 
    {
        videoPlayer.url = VideoURL[0] ;
        videoPlayer.Play();
    }

    public void StartPrepare(int VideoIndex1) 
    {
        isVideoReady = false;
        videoPlayer.url = VideoURL[VideoIndex1];
        Debug.Log(VideoURL[VideoIndex1]);
        videoPlayer.Prepare();

        
    
    }
    public void Prepare (int i)
    {
        StartPrepare(i);

    }

    public void OnComplete(VideoPlayer videoPlayer)
    {

        isVideoReady = true;
        videoPlayer.Play();

    }



    IEnumerator CreatePrefab()
    {
        yield return new WaitForSeconds(1f);
        foreach (var Var in VideoURL)
        {
            Debug.Log("VideoURL"+""+Var); 
        }

        for (int i = 0; i <=1; i++)
        {
           
            PrefabNumber = i;
            Debug.Log("Number" + PrefabNumber);
            GameObject ButtonPre = Instantiate(Resources.Load("Button") as GameObject, parent);
            ButtonPre.GetComponent<ButtonScript>().Index = i;
            ButtonPre.GetComponent<Button>().onClick.AddListener(() => StartPrepare(i));
            Image image1 = ButtonPre.GetComponent<Image>();
            byte[] pngBytes = System.IO.File.ReadAllBytes(Thumbnails[i]);
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(pngBytes);
            Sprite fromTex = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);

            image1.sprite = fromTex;
        }

       
        StopCoroutine("Createprefab");
    }

  
}

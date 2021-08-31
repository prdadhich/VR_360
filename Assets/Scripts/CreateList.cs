using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Linq;
using UnityEditor;
using System.IO;
using UnityEngine.Networking;

public class CreateList : MonoBehaviour
{

    int FolderIndex = 0;
    [HideInInspector] public List<string> VideoURL = new List<string>();
   // string VideoURLcommon;
    [HideInInspector]
    public List<string> FinalVideoURL = new List<string>();
    public List<string> Thumbnails;
    public List<string> Background = new List<string>();
    string defaulturl;


    public TMPro.TMP_Text URL;
    // Start is called before the first frame update
    void Start()
    {

       // string defaulturl = "jar:file://" + Application.dataPath + "\\Files\\Videos\\Video";


        defaulturl = Application.streamingAssetsPath + "\\Files\\Videos\\Video";


        string[] path2 = {defaulturl ,"Files", "Videos" };
        //string VideoURLcommon = defaulturl;
        Invoke("CreateLists", 1f);
        //URL.text = defaulturl;
    }

    // Update is called once per frame
    void LateUpdate()
    {
      
      
    }

    void CreateLists()
    {
        
        FolderIndex = GetSubfolders.NumberofFolders;
        for (int i = 1; i <= FolderIndex; i++)
        {
         
            //VideoURL.Add((defaulturl + i));
            if(defaulturl != null)
            {
                DirectoryInfo dir = new DirectoryInfo(defaulturl + i);
                FileInfo[] info = dir.GetFiles(".");


                foreach (FileInfo f in info)
                {
                    if (f.ToString().Contains(".meta") && f.ToString().Contains(".mp4"))
                    {
                       // FinalVideoURL.Add(defaulturl + i + "\\" + Path.GetFileNameWithoutExtension(f.ToString()));
                        VideoManager.VideoURL.Add(defaulturl + i + "\\" + Path.GetFileNameWithoutExtension(f.ToString()));
                    }
                    if (f.ToString().Contains(".meta") && f.ToString().Contains(".png"))
                    {
                        //Thumbnails.Add(VideoURLcommon + i + "\\" + Path.GetFileNameWithoutExtension(f.ToString()));
                        VideoManager.Thumbnails.Add(defaulturl + i + "\\" + Path.GetFileNameWithoutExtension(f.ToString()));
                    }


                    

                }

               
            }

            else
                Debug.Log("Check the url");

           
        }
        GetVideos();
    }

    void GetVideos()
    {
        foreach (var videoU in FinalVideoURL)
            Debug.Log(videoU);

    }
}

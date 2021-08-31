using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Video;
using System.IO;

public class GetSubfolders : MonoBehaviour
{

    public static int NumberofFolders = 0;

    private void Start()
    {
        SubFolderExample();
      
    }
    // Start is called before the first frame update
      static void  SubFolderExample()
    {
        //This method prints out the entire folder list of a project into the console
        var Videofolders = Directory.GetDirectories("Assets/StreamingAssets/Files/Videos");
        var Thumbnailfolders = Directory.GetDirectories("Assets/StreamingAssets/Files/Videos");
        var Backgroundfolders = Directory.GetDirectories("Assets/StreamingAssets/Files/Background");
        //var Headerfolders = AssetDatabase.GetSubFolders("Assets/StreamingAssets/Files/Header");


        foreach (var folder in Videofolders)
        {
           UpdateIndex();

          // Recursive(folder);

        }




    }

    static void Recursive(string folder)
    {
      // Debug.Log(folder);
        var folders = Directory.GetDirectories(folder);
        
        foreach (var fld in folders)
        {
            Recursive(fld);
            
        }
       
    }

    

    private void Update()
    {
       
        

    }

    static void UpdateIndex()
    {

        NumberofFolders++;
    }

 
}

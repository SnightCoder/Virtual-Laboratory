using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcanvastlookat : MonoBehaviour
{
    Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale=new Vector3(transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
        cam=Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cam);
    }
}

 /*
  _   _                  ______ _                     
| \ | |                 | ___ \ |                    
|  \| | __ _ _ __ ___   | |_/ / |__   __ _ _ __ ___  
| . ` |/ _` | '_ ` _ \  |  __/| '_ \ / _` | '_ ` _ \ 
| |\  | (_| | | | | | | | |   | | | | (_| | | | | | |
\_| \_/\__,_|_| |_| |_| \_|   |_| |_|\__,_|_| |_| |_|                                                   
                                                     
  */
/*
        _______  _       _________ _______          _________   _______  _______  ______   _______  _______        
       (  ____ \( (    /|\__   __/(  ____ \|\     /|\__   __/  (  ____ \(  ___  )(  __  \ (  ____ \(  ____ )       
       | (    \/|  \  ( |   ) (   | (    \/| )   ( |   ) (     | (    \/| (   ) || (  \  )| (    \/| (    )|       
 _____ | (_____ |   \ | |   | |   | |      | (___) |   | |     | |      | |   | || |   ) || (__    | (____)| _____ 
(_____)(_____  )| (\ \) |   | |   | | ____ |  ___  |   | |     | |      | |   | || |   | ||  __)   |     __)(_____)
             ) || | \   |   | |   | | \_  )| (   ) |   | |     | |      | |   | || |   ) || (      | (\ (          
       /\____) || )  \  |___) (___| (___) || )   ( |   | |     | (____/\| (___) || (__/  )| (____/\| ) \ \__       
       \_______)|/    )_)\_______/(_______)|/     \|   )_(     (_______/(_______)(______/ (_______/|/   \__/    
          
 */

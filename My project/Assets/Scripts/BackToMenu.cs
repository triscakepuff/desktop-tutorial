using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
   public SceneLoader sceneLoader;
   public string sceneName;
   public float loadTime = 10f;
   void Start()
   {
        Invoke("AutoLoad", loadTime);
   }

    void AutoLoad()
    {
        sceneLoader.ChangeScene(sceneName);
    }
}

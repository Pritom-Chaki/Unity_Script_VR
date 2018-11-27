using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    //Define a static Gamecontroller
    public static GameController control;

    //Monobehaviour Awake
    private void Awake()
    {
        control = this;
    }
    // Use this for initialization
    void Start ()
    {    //Load Level 01
        StartCoroutine(LoadLevel("Scene1"));
	}

    //Load a Scene, pass scene name

        public IEnumerator LoadLevel(string sceneName)
    {
        //wait until the end of the current frame
        yield return new WaitForEndOfFrame();
        //Load the scene Asynchronously
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        //Unload previous scenes(s)  
        StartCoroutine(UnloadLevels(sceneName));
    }


    //Unload all levels excepts "Exception" and the VRMain scene
      private IEnumerator UnloadLevels(string exception)
    {
        //wait untill the end of the current frame
        yield return new WaitForEndOfFrame();
        //For each scene that is current loaded
        for(int i = 0; i< SceneManager.sceneCount; i++)
        {
            //Check this scene to make sure it's NOT 'exception' NOR VRMain Scene
            if(SceneManager.GetSceneAt(i).name != exception && SceneManager.GetSceneAt(i).name !="VRMain")
            {
                //It's not the newly loaded scene, nor VR Main; Unload this scene
                SceneManager.UnloadScene(SceneManager.GetSceneAt(i).name);
            }
        }
    }
	
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenChanger : MonoBehaviour {
    [SerializeField]
    private float delayTime = 5f;
    [SerializeField]
    private string sceneNameToLoad;

    private float timeElapsed;
	private void Update () {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > delayTime)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
	}
}

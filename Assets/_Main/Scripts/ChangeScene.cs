using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private static int _count;

    //Lo va a llamar un boton

    [SerializeField]
    private GameObject _dontDestroyGO;


    private void Awake()
    {
        DontDestroyOnLoad(_dontDestroyGO);
    }
    public void LoadNewScene()
    {
        var countMaxScenes = SceneManager.sceneCountInBuildSettings;

        if(_count < countMaxScenes)
        {
            SceneManager.LoadScene(_count);
            _count++;
        }
       
    }

}

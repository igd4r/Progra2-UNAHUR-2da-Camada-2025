using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    //Singleton:
    //Instancia unica, es decir no existen copias.
    //Debe ser accesible desde cualquier otro script, es decir desde afuera.

    public static SpawnManager Instance { get; private set; }

   
    [SerializeField]
    private GameObject _objectToCreate;
    [SerializeField]
    private Transform _spawnPosition;
    [SerializeField]
    private float _delay;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

    

        
    }

    //Lo va a llamar un boton de la UI
    public void StartToInstance()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        while (true)
        {
            Instantiate(_objectToCreate, _spawnPosition);
            yield return new WaitForSeconds(_delay);

        }
    }



}

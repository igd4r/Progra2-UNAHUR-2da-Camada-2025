using UnityEngine;
public class SquareMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public GameObject _target;
    private void Awake()
    {
        _target = GameObject.Find("Target");
    }
    void Start()
    {
       
    }
    void Update()
    {
        //Movimiento por Transform con un vector direccion
        transform.position += direction * speed * Time.deltaTime;

        //Forma de detectar una tecla del teclado
        if (Input.GetKeyDown(KeyCode.F) && _target.activeInHierarchy)
        {
            _target.SetActive(false);
        }
        else if (Input.GetKeyDown((KeyCode.T)))
        {
            _target.SetActive(true);
        }


    }




}

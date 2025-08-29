using UnityEngine;
public class SquareMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public GameObject _target;
    private void Awake()
    {
        _target = GameObject.Find("Circle");
    }
    void Start()
    {
       
    }
    void Update()
    {
        //Input.GetAxis("Horizontal");
        

        //if (Input.GetKey(KeyCode.T))
        //{
        //    print("Get Key");
        //    //llamar animacion
        //}

        
        if (Input.GetKeyDown(KeyCode.U))
        {
            _target.SetActive(false);
        }

        //if (Input.GetKeyUp(KeyCode.I))
        //{
        //    print("Get Key Up");
        //}

        transform.position += direction * speed * Time.deltaTime;
  
    }
}

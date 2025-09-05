using UnityEngine;

public class CircleController : MonoBehaviour
{

    [SerializeField]
    private GameObject _panelDefeat;

    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private float _speed;

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    void Update()
    {
    
    }


    private void FixedUpdate()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePos - _rb.position);
        _rb.MovePosition(_rb.position + direction * _speed * Time.fixedDeltaTime);


        ////_rb.AddForce(Vector2.right * _speed, ForceMode2D.Impulse);
        //_rb.AddForce(Vector2.right, ForceMode2D.Force);


        //if (Input.GetMouseButtonDown(0))
        //    _rb.velocity = Vector2.zero;
        //else _rb.velocity = direction * _speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
            _panelDefeat.SetActive(true);

        if (collision.gameObject.layer == LayerMask.NameToLayer("NPC"))
        {   
            Debug.Log("Hola, Mundo");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _panelDefeat.SetActive(false);
    
    }




}

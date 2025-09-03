using UnityEngine;
using static Unity.VisualScripting.Member;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Animator _anim;
    private AudioSource _aSource;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _aSource = GetComponent<AudioSource>();
        rb.gravityScale = 0;
    }

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        direction = new Vector2(inputX, inputY).normalized;

        if (Input.GetKey(KeyCode.Space))
        {
            _anim.SetBool("canAttack", true);
            //Mientras mantengamos la tecla apretada 
            //Reproducir anim ataque
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _anim.SetBool("canAttack", false);
            //Si soltamos
            //Dejar reproducir la animacion de ataque
        }


    }
    public void PlaySoundAttack()
    {
        _aSource.Play();
    }

    private void FixedUpdate()
    {
        if (direction != Vector2.zero)
        {
            rb.velocity = direction * speed;
        }
      
    }
}
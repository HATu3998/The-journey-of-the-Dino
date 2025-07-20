using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed;
    public float jumpStrength;
    private Rigidbody2D _rb;
    private Animator _animator;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            gameObject.transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0, 0));
            _animator.SetInteger("Status", 1);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _animator.SetInteger("Status", 1);
            gameObject.transform.Translate(new Vector3( speed * Time.deltaTime, 0, 0));
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            _animator.SetInteger("Status", 0);
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetInteger("Status", 3);
            _rb.AddForce(new Vector3(0, jumpStrength, 0), ForceMode2D.Impulse);
        }
    }
}

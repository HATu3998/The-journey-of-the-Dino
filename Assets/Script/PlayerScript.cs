using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed;
    public float jumpStrength;
    private Rigidbody2D _rb;
    private Animator _animator;
    public Text  textScore;
    public Text gameOver;
   
    private int score;

    public static GameObject player;
    public static Text gameOverText;
    bool is_ground;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        player =GameObject.Find("player"); //ten trong ui chu khong phai goi tag
        gameOverText = gameOver;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            gameObject.transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0, 0));
            
            transform.localScale = new Vector3(-1, 1, 1);
            if (is_ground)
            {
                _animator.SetInteger("Status", 1);
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            if (is_ground){
                _animator.SetInteger("Status", 1);
            }
            gameObject.transform.Translate(new Vector3( speed * Time.deltaTime, 0, 0));
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            if (is_ground)
            {
                _animator.SetInteger("Status", 0);
            }
          
        }
        if (!is_ground)
        {
            _animator.SetInteger("Status", 3);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && is_ground)
        {
            _animator.SetInteger("Status", 3);
            _rb.AddForce(new Vector3(0, jumpStrength, 0), ForceMode2D.Impulse);
        }
    }
    public static void PlayerDeath()
    {
        //player.transform.position = new Vector3(2f,-2f, 0);
        gameOverText.gameObject.SetActive(true);
        Destroy(player);
    }
    private void OnCollisionEnter2D(Collision2D col )
    {
        if(col.gameObject.tag == "Ground")
        {
            is_ground = true;
        }
        else if (col.gameObject.tag == "item")
        {
            score++;
            textScore.text = "Score : " + score;

            Destroy(col.gameObject); // Xo? coin sau khi ?n
        }
    }
    

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            is_ground = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            is_ground = false;
        }
    }
    
}

using UnityEngine;

public class ThangMayController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 targetPosition;
    private Vector3 initPosition;

    private bool isMoveToTarget;
    public float speed;
    void Start()
    {
        initPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(isMoveToTarget && transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        }
        else if(! isMoveToTarget && transform.position != initPosition) 
        {
            transform.position = Vector3.MoveTowards(transform.position, initPosition, speed * Time.deltaTime);
        }
        else
        {
            isMoveToTarget = !isMoveToTarget;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.parent = null;
        }
    }

}

using UnityEngine;

public class CameraMini : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform player;
    void Start()
    {
        
    }
    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 newPos = transform.position;
            newPos.x = player.position.x;
            newPos.y = player.position.y;
            transform.position = newPos;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

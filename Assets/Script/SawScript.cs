using UnityEngine;

public class SawScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col )
    {
        if (col.gameObject.tag== "Player")
        {
            PlayerScript.PlayerDeath(); 
        }
    }
}

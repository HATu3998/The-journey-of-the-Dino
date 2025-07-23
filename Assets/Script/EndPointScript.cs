using UnityEngine;

public class EndPointScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ParticleSystem Effect;
    private bool isWin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D col )
    {
        if(col.gameObject.tag == "Player" && !isWin)
        {
            isWin = true;
            Effect.gameObject.SetActive(true);
            Effect.Play();
        }
    }
}

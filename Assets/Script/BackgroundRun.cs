using UnityEngine;

public class BackgroundRun : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerScript.player.transform.position;
      //  _spriteRenderer.material.mainTextureOffset = new Vector2(Time.time * 0.2f, 0);
    }
}

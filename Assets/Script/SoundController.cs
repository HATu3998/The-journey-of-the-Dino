using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public List<AudioClip> ListSound;

    private AudioSource BackgroundSource;
    void Start()
    {
        PlayBackground();
    }

    // Update is called once per frame
    void PlayBackground()
    {
        if(BackgroundSource == null)
        {
            BackgroundSource = gameObject.AddComponent<AudioSource>();
            BackgroundSource.clip = ListSound[0];
            BackgroundSource.loop = true;

        }
        BackgroundSource.Play();
    }
}

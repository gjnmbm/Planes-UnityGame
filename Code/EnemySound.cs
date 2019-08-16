using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    public static AudioClip explosion;
    static AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        explosion = Resources.Load<AudioClip>("Explosion Noise");
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        if (clip.Equals("explosion")) {
            audio.PlayOneShot(explosion); 
        }
    }
}

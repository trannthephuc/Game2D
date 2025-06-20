using UnityEngine;
using UnityEngine.UI;
public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
       audioSource.loop = true;
       audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

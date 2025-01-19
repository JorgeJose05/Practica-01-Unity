using Unity.VisualScripting;
using UnityEngine;

public class ScriptSound : MonoBehaviour
{private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      // Intenta obtener el componente AudioSource del GameObject
        audioSource = GetComponent<AudioSource>();

        // Si no existe, lo agregamos dinámicamente
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision){
                    
        PlaySOundWithFrequency(1000f);
    }

    void PlaySOundWithFrequency(float frequency)
    {
        int sampleRate = 882;
        int sampleLength = sampleRate;
        
        float[] samples = new float[sampleLength];

        for (int i = 0; i < sampleLength; i++)
        {
            samples[i] = Mathf.Sin(2 * Mathf.PI * frequency * i / sampleRate);
        }
        
        AudioClip clip = AudioClip.Create("GeneratedTone", sampleLength, 1, sampleRate, false);
        clip.SetData(samples, 0);
        
        //reproducir sondio
        audioSource.PlayOneShot(clip);
        
    }
    
    
}

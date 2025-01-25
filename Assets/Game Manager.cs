using UnityEngine;

public class GameManager : MonoBehaviour
{
    private SoundManager soundManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundManager = FindAnyObjectByType<SoundManager>();
        soundManager.m_instance.Play("BG");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

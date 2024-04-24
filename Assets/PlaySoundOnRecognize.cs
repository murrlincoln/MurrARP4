using UnityEngine;
using Vuforia;

public class PlaySoundOnRecognize : MonoBehaviour
{
    private ObserverBehaviour modelTargetBehaviour;
    public AudioClip soundClip;
    private AudioSource audioSource;

    void Start()
    {
        modelTargetBehaviour = GetComponent<ObserverBehaviour>();
        if (modelTargetBehaviour)
        {
            modelTargetBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.playOnAwake = false;
    }

    private void OnTargetStatusChanged(ObserverBehaviour observer, TargetStatus status)
    {
        if (status.Status == Status.TRACKED && status.StatusInfo == StatusInfo.NORMAL)
        {
            audioSource.Play();
        }
    }

    void OnDestroy()
    {
        if (modelTargetBehaviour)
        {
            modelTargetBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}

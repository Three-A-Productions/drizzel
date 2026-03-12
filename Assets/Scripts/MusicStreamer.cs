using System.Collections;
using UnityEngine;

public class MusicStreamer : MonoBehaviour
{
    public static MusicStreamer Instance { get; private set; }

    [SerializeField]
    private BackgroundTrack[] backgroundTracks;

    private bool isPlayingTrack = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        StartCoroutine(RandomMusicLoop());
    }

    private IEnumerator RandomMusicLoop()
    {
        while (true)
        {
            if (!isPlayingTrack)
                PlayRandomSong();

            yield return null;
        }
    }

    private void PlayRandomSong()
    {
        if (isPlayingTrack)
            return;

        isPlayingTrack = true;

        int idx = Random.Range(0, backgroundTracks.Length);
        BackgroundTrack track = backgroundTracks[idx];

        AudioManager.Instance.PlayAudio(track.audioClip, track.volume, false, true, true, 15f);
    }
}

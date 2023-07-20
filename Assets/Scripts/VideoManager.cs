using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string loadSceneName;

    private bool videoPlayed = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !videoPlayed)
        {
            videoPlayer.Play();
            videoPlayed = true;
        }

        if (videoPlayed && !videoPlayer.isPlaying)
        {
            SceneManager.LoadScene(loadSceneName);
        }
    }
}

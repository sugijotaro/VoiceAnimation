using System.Collections;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string loadSceneName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            videoPlayer.Play();

            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(loadSceneName);
    }
}

using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(VideoPlayer))]
public class VideoEndToMenu : MonoBehaviour
{
    public string menuScene = "mainmenu";
    VideoPlayer vp;

    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        vp.loopPointReached += OnVideoEnd;
        vp.Play();
    }

    void OnVideoEnd(VideoPlayer player)
    {
        SceneManager.LoadScene(menuScene);
    }
}


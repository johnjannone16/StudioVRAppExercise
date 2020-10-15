using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.Video;

public class EventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();

    }

    public void OnPress(Hand hand)
    {
        if(videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
        
        Debug.Log("buttons pressed");
    }
}

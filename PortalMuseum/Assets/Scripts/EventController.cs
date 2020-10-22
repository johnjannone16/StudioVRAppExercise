using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.Video;

public class EventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Animator rotAnimation;
    public bool animation_bool;


    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        rotAnimation = GetComponent<Animator>();
        animation_bool = false;

    }




    public void Rotation(Hand hand)
    {
        rotAnimation.SetBool("rotationBool", true);
        animation_bool = true; 
    }

    public void rotOff(Hand hand)
    {
        rotAnimation.SetBool("rotationBool", false);
        animation_bool = false;
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

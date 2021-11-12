using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualBtn : MonoBehaviour
{
    public Animator ballAnim;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ballAnim.Play("ballAnimation");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ballAnim.Play("None");
    }
}

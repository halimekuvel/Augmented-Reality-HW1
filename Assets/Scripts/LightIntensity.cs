using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensity : MonoBehaviour
{
    Animator lightanim;
    // Start is called before the first frame update
    void Start()
    {
        lightanim = GetComponent<Animator>();
        lightanim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void lightIntensityAnim()
    {
        lightanim.Play("LightAnimation", -1, 0f);
        lightanim.speed = 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour
{
    Animator treeAnim;
    static int scale = 0;
    // Start is called before the first frame update
    void Start()
    {
        treeAnim = GetComponent<Animator>();
        treeAnim.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TreeScale()
    {
        switch (scale)
        {
            case 0:
                treeAnim.Play("TreeAnimation", -1, 0f);
                treeAnim.speed = 1f;
                scale = 1;
                break;

            case 1:
                treeAnim.Play("TreeAnimation2", -1, 0f);
                treeAnim.speed = 1f;
                scale = 2;
                break;

            case 2:
                treeAnim.Play("TreeAnimation3", -1, 0f);
                treeAnim.speed = 1f;
                scale = 0;
                break;
        }
    }
}

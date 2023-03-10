using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed;

    Animator runAnimation;
    Transform characterTransform;
    void Start()
    {
        runAnimation = GetComponent<Animator>();
        characterTransform = GetComponent<Transform>();
    }
    void Update()
    {
        run();
    }

    private void run()
    {
        runAnimation.SetBool("runActive", true);
        characterTransform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    private void grow()
    {
        characterTransform.localScale += new Vector3(2, 2, 2) * Time.deltaTime;

    }
    private void shrink()
    {
        characterTransform.localScale -= new Vector3(2, 2, 2) * Time.deltaTime;

    }
}


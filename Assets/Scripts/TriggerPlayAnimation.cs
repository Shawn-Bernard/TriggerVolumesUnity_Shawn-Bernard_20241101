using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlayAnimation : MonoBehaviour
{
    public GameObject Ghost;
    public GameObject GhostKid;

    private Animator _animator;
    private Animator _animatorKid;

    private void Start()
    {
        _animator = Ghost.GetComponent<Animator>();
        _animatorKid = GhostKid.GetComponent<Animator>();
        _animator.enabled = false;
        _animatorKid.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        _animator.enabled = true;
        _animatorKid.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        _animator.enabled = false;
        _animatorKid.enabled = false;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickForAnimation : MonoBehaviour
{
     [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _animator.enabled = true;
        }
        
    }

   
}

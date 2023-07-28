using UnityEngine;


public class ClickForAnimation : MonoBehaviour
{
     [SerializeField] protected Animator _animator;

    protected virtual void Start()
    {
        _animator = GetComponent<Animator>();

    }
    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _animator.enabled = true;
        }
        
    }

   
}


using UnityEngine;
using UnityEngine.EventSystems;

public class ClickForAnimationWithCollider : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();

    }
    

    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.enabled = true;
    }
}

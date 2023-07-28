using UnityEngine.EventSystems;

public class ClickForAnimationWithCollider : ClickForAnimation, IPointerClickHandler
{

    protected override void Start()
    {
        base.Start();

    }
   
    protected override void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.enabled = true;
    }
}

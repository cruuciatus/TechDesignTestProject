using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickForAnotherScene : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private string _sceneName;
    public void OnPointerClick(PointerEventData eventData)
    {
        Click();
    }

    public void Click()
    {
        SceneManager.LoadScene(_sceneName);
    }
}

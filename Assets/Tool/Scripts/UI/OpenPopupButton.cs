using System;
using UnityEngine;
using UnityEngine.UI;

public class OpenPopupButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    [SerializeField] private ScreenType _screenType;

    void Start()
    {
        if (_button == null)
        {
            _button = GetComponent<Button>();
        }

        _button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        if (_screenType == ScreenType.Back)
        {
            UIManager.Instance.Back();
        }
        else
        {
            UIManager.Instance.OpenScreen(_screenType);
        }
    }
}
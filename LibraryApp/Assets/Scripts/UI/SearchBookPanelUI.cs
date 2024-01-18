using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchBookPanelUI : MonoBehaviour
{
    public static SearchBookPanelUI Instance { get; private set; }

    [SerializeField] private Button closeButton;

    private void Awake()
    {
        Instance = this;
        closeButton.onClick.AddListener(Hide);
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
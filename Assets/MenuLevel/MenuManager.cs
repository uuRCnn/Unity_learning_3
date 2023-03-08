using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject menuPaneli;

    private void Start()
    {
        menuPaneli.GetComponent<CanvasGroup>().DOFade(1, 1f);
        menuPaneli.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.OutBack);
    }

    public void ikinciLeveleGeç()
    {
        SceneManager.LoadScene("ikinci_menu_level");
    }

    public void AyarlarıYap()
    {
     // dahasonra kodliyacagız   
    }

    public void OyundanÇık()
    {
        Application.Quit();
    }
}

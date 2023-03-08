using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class alt_menu_manager : MonoBehaviour
{
    [SerializeField] private GameObject altMenuPaneli;
    private void Start()
    {
        altMenuPaneli.GetComponent<CanvasGroup>().DOFade(1, 1f);
        altMenuPaneli.GetComponent<RectTransform>().DOScale(1, 1f).SetEase(Ease.InOutBack );
    }

    public void HangiOyunAçılsın(string hangiOyun)
    {
        PlayerPrefs.SetString("hangiOyun", hangiOyun);
        SceneManager.LoadScene("Game_level");
    }

    public void GeriDon()
    {
        SceneManager.LoadScene("Menu_level");
    }
}

using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class game_manager : MonoBehaviour
{
    [SerializeField] private GameObject baslaImage;
    void Start()
    {
        if (PlayerPrefs.HasKey("hangiOyun"))
        {
            // Debug.Log(PlayerPrefs.GetString("hangiOyun"));
        }

        StartCoroutine(baslaYazıRoutine());
    }

    IEnumerator baslaYazıRoutine()
    {
        baslaImage.GetComponent<CanvasGroup>().DOFade(1f, 0.5f);
        baslaImage.GetComponent<RectTransform>().DOScale(1f, 0.8f);
        yield return new WaitForSeconds(0.8f);
        baslaImage.GetComponent<RectTransform>().DOScale(0f, 0.8f).SetEase(Ease.InBack);
        baslaImage.GetComponent<CanvasGroup>().DOFade(0f, 0.5f);
        yield return new WaitForSeconds(0.5f);

        OyunBaşla();
    }

    private void OyunBaşla()
    {
        
    }
    
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    AudioSource _audioSource;
    TextMeshProUGUI _textMeshProUGUI;

    readonly string[] countDownTexts = new string[] {
        "3",
        "2",
        "1",
        "GO!"
    };

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _textMeshProUGUI = GetComponentInChildren<TextMeshProUGUI>();

        StartCoroutine(DoCountDown());
    }

    public IEnumerator DoCountDown()
    {
        yield return new WaitForSeconds(2f);
        _audioSource.Play();
        yield return CountDownTextRoutine();

        _textMeshProUGUI.enabled = false;
    }

    IEnumerator CountDownTextRoutine()
    {
        for (int i = 0; i < countDownTexts.Length; i++)
        {
            _textMeshProUGUI.text = countDownTexts[i];
            yield return new WaitForSeconds(1f);
        }
    }

}

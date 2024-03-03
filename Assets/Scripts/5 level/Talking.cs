using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Talking : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private TextMeshProUGUI _text;

    private int i = 0;

    private string[] text = {"*������������� ���*", "*������������* ��� �������� ��� *������������* � ���������� *������������*", "������ ��������� *������������* ","" +
            "���� ��������� ��� ������ ����� 495 ���������� ����������� ������������� �����������","�� ����� ���� ����� ��������� ������� � ������� ����� ���������� �������",
        "*������������* ���, ������ �� ��� �� ������ � ���� � ��������� � �� �������� ���� ������� ��-��, �� �� ���� ��� ���������","�� ��� ����� ������ �� ������ ������, ��� ������ ������ �� ��������",
        "�������� �����, � �������� ������ ����� 496" , "������� �������� < ������-����������� >"};

    public void StartTalking()
    {
        _audio.Play();
        _image.gameObject.SetActive(true);
        _text.text = text[i];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i < text.Length - 1)
            {
                i++;
                _text.text = text[i];
            }
            if (i == text.Length - 1)
            {
                StartCoroutine(LastLevel());
            }
        }
    }

    IEnumerator LastLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

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

    private string[] text = {"*неразборчивый гул*", "*неразборчиво* это позволит нам *неразборчиво* и достигнуть *неразборчиво*", "Сейчас тревожить *неразборчиво* ","" +
            "Хочу заключить что объект номер 495 страдающий психическим расстройством шизофренией","На самом деле легко поддается гипнозу с помощью наших записанных мелодий",
        "*неразборчиво* нет, сейчас он уже не бегает у себя в головушке и не собирает свои кассеты ха-ха, мы же дали ему лекарство","Он все равно ничего не успеет понять, уже сейчас пойдет на списание",
        "Вывозите этого, и завозите объект номер 496" , "Пробуем сценарий < Псевдо-разработчик >"};

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

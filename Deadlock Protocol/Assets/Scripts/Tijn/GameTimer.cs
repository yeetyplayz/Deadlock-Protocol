using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timer = 0f;
    public bool isCounting = false;
    public TMP_Text counterText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        counterText.text = "time: =" + Mathf.FloorToInt(timer).ToString();
    }
}

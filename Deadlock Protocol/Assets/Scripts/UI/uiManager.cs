using UnityEngine;

public class uiManager : MonoBehaviour
{
    [Header("UI stuff")]
    public GameObject mainUI;

    [Header("UI buttons")]
    public GameObject startGameButton;
    public void ChangeUI(GameObject ui)
    {
        mainUI.SetActive(false);

        ui.SetActive(true);
    }
    public void ChangeButton(GameObject ui)
    {

    }
}

using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public float delay = 0;  // Use a float for delay instead of int
    public GameObject button;

    private void Start()
    {
        button.SetActive(false);
        Invoke("ActivateButton", delay);
    }

    private void ActivateButton()
    {
        button.SetActive(true);
    }
}

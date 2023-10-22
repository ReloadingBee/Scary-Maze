using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string redirectLevel = "Menu";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Mouse"))
        {
            SceneManager.LoadScene(redirectLevel);
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string sceneRedirect;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(sceneRedirect);
        }
    }
}

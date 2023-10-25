using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouse : MonoBehaviour
{
    public string sceneRedirect = "Menu";

    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Death"))
        {
            print("DEATH " + sceneRedirect);
            SceneManager.LoadScene("Menu");
        }
        else if (collision.gameObject.name == "Victory")
        {
            print("VICTORY " + sceneRedirect);
            SceneManager.LoadScene(sceneRedirect);
        }
    }
}

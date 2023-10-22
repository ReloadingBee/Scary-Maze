using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouse : MonoBehaviour
{
    public Color deathColor = Color.black;
    public Color winColor = Color.red;

    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Death"))
        {
            print("died");
            //SceneManager.LoadScene("Menu");
        }
    }
}

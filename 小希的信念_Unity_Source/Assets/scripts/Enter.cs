using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject enterButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enterButton.SetActive(true);
        }
    }

}

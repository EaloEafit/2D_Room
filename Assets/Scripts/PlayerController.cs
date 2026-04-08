using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveHorizontal, moveVertical, 0);
        transform.Translate(direction * speed * Time.deltaTime);
    }

    //este método especial de unity se ejecuta cuando interactuamos con un objeto en modo Trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            Debug.Log("Collected!");
        }
    }

}

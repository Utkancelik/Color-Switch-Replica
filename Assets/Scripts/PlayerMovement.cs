
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject colorChanger;

    

    private Rigidbody2D rb2D;
    public float jumpForce = 10f;
    private SpriteRenderer sr;

    public string currentColor;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorMagenta;
    void Start()
    {
        
        rb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        SetRandomColor();
        
    }

    

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            //Jump here
            rb2D.velocity = Vector2.up * jumpForce; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "colorChanger")
        {
            SetRandomColor();
            Destroy(collision.gameObject);
            return;
        }
        if (collision.tag != currentColor)
        {
            SceneManager.LoadScene(0,LoadSceneMode.Single);
            Debug.Log("GAME OVER!");
        }

        
       
    }

    void SetRandomColor()
    {
        int randomInt = Random.Range(1, 5);

        switch (randomInt)
        {
            case 1:
                currentColor = "cyan";
                sr.color = colorCyan;
                break;
            case 2:
                currentColor = "yellow";
                sr.color = colorYellow;
                break;
            case 3:
                currentColor = "pink";
                sr.color = colorPink;
                break;
            case 4:
                currentColor = "magenta";
                sr.color = colorMagenta;
                break;
            
        }

        


    }
}

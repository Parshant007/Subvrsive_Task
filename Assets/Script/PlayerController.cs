using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    Rigidbody rb;
    public void Awake()
    {
        if (instance == null) { instance = this; }
        rb= GetComponent<Rigidbody>(); 
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerRotation();
    }

    private void HandlePlayerRotation() 
    {
        Vector3 mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(mousePos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
    } 
}

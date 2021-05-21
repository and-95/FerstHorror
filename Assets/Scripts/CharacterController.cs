
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed = 10.0f;
    private float translation;
    private float straffe;
    private AudioSource audio;
    public int value = 0;

    
    private bool m_Play = true;


    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        audio = GetComponent<AudioSource>();
    }
  

    void Update()
    {

        if (m_Play == true)
        {
            if (Input.GetAxis("Vertical") != 0)
            {

                audio.Play();
                m_Play = false;
            }
        }

        if (Input.GetAxis("Vertical") == 0)
        {
            audio.Stop();
            m_Play = true;
        }

        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(straffe, 0, translation);
        
      
        if (Input.GetKeyDown("escape"))
        {
            
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
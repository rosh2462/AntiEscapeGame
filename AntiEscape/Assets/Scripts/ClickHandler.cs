using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    // Reference to the GameObjects you want to enable
    public GameObject[] objectsToEnable;
public AudioClip clickSound;
private AudioSource audioSource;

    void Start(){
    audioSource = GetComponent<AudioSource>();
if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
         audioSource.clip = clickSound;
        }
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse position to world space
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Set z-coordinate to 0 for 2D games

            // Check if the mouse click hits the GameObject
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);
            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                // The GameObject is clicked, enable specified objects
                EnableObjects();
                PlayClickSound();
            }
        }
    }

    // Enable the specified objects
    void EnableObjects()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            obj.SetActive(true);
        }
    }

    void PlayClickSound()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}

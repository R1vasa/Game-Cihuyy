using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    public GameObject  gameOvUI;
    [SerializeField] private float startingHealth;
    public float Currenthealth { get; private set; }
    //public GameManager gameManager;

    // void Update(){
    //     if (Currenthealth<= 0){
    //         Debug.Log("Dead");
    //     }
    // }
    private void Awake()
    {
        Currenthealth = startingHealth;
    }

    public void TakeDamage(float damage)
    {
        Currenthealth = Mathf.Clamp(Currenthealth - damage, 0, startingHealth);

        if (Currenthealth == 0)
        {
            Destroy(gameObject);

            gameOvUI.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            TakeDamage(1);
        }
        {
            
        }
    }
}

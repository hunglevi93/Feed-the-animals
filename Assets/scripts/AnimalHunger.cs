using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public float maxHealth;
    private float minHealth = 0;
    private float delayDestroy = 0.3f;
    private float currenthHealth;
    private Slider heathSlider;
    

    // Start is called before the first frame update
    void Start()
    {
        heathSlider = GetComponentInChildren<Slider>();
        currenthHealth = minHealth;
        heathSlider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        heathSlider.value = currenthHealth;
        if (heathSlider.value == maxHealth)
        {
            Invoke("OnDestroyAnimal", delayDestroy);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("projectile"))
        {
            currenthHealth += 1;
        }
    }
    private void OnDestroyAnimal()
    {
        Destroy(gameObject);
    }
}

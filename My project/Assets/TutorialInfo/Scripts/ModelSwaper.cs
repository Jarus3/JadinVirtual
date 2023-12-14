using UnityEngine;

public class ModelSwapper : MonoBehaviour
{
    public GameObject model1; // asigna esto en el Inspector de Unity
    public GameObject model2; // asigna esto en el Inspector de Unity
    public AnimationClip transitionAnimation; // asigna esto en el Inspector de Unity

    private bool usingModel1 = true;
    private Animation animation;

    void Start()
    {
        animation = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // cambia esto por cualquier condición que quieras
        {
            SwapModel();
        }
    }

    void SwapModel()
    {
        usingModel1 = !usingModel1;
        model1.SetActive(usingModel1);
        model2.SetActive(!usingModel1);

        // Reproduce la animación de transición
        animation.clip = transitionAnimation;
        animation.Play();
    }
}
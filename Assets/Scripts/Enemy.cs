using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySO data;

    public float enemyHealth;
    public string enemyName;
    public Material color;

    void Start()
    {
        enemyHealth = data.enemyHealth;
        enemyName = data.enemyName;
        color = data.enemyColor;

        Renderer renderer = gameObject.GetComponent<Renderer>();
        renderer.material = color;
    }

}

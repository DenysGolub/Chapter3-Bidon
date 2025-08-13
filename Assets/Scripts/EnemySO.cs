using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObjects/Enemy")]
public class EnemySO : ScriptableObject
{
    public float enemyHealth;
    public Material enemyColor;
    public string enemyName;

}

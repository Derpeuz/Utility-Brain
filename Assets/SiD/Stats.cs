using UnityEngine;

public class Stats : MonoBehaviour
{
    [Header("Basic Stats")]
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float health = 100f;
    [SerializeField] private float damage = 10f;

    [Header("Detection Colliders")]
    [SerializeField] private Collider lineOfSightCollider;
    [SerializeField] private Collider detectionCollider;
    [SerializeField] private Collider meleeRangeCollider;

    [Header("Detection States")]
    [SerializeField] private bool lineOfSight;
    [SerializeField] private bool distanceDetection;
    [SerializeField] private bool inMeleeRange;

    // Stats getters
    public float Health => health;
    public float MaxHealth => maxHealth;
    public float Damage => damage;

    // Collider getters
    public Collider LineOfSightCollider => lineOfSightCollider;
    public Collider DetectionCollider => detectionCollider;
    public Collider MeleeRangeCollider => meleeRangeCollider;

    // Detection getters
    public bool LineOfSight => lineOfSight;
    public bool DistanceDetection => distanceDetection;
    public bool InMeleeRange => inMeleeRange;

    // Detection setters
    public void SetLineOfSight(bool value)
    {
        lineOfSight = value;
    }

    public void SetDistanceDetection(bool value)
    {
        distanceDetection = value;
    }

    public void SetInMeleeRange(bool value)
    {
        inMeleeRange = value;
    }

    // Health methods
    public void TakeDamage(float amount)
    {
        health = Mathf.Max(0f, health - amount);
    }

    public void Heal(float amount)
    {
        health = Mathf.Min(maxHealth, health + amount);
    }
}
using UnityEngine;

public interface IStatus
{
    void TakeDamage(int damageAmount, Vector2 hitPosition);
    void Heal(int healAmount);
    void Die();
}

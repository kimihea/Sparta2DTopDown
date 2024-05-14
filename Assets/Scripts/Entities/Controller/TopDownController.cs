using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //Action은 무조건void만 반환해야 아니면 Func

    public event Action<Vector2> OnLookEvent;
    public event Action<AttackSO> OnAttackEvent;
    protected bool IsAttacking { get; set; }
    private float timeSinceLastAttack = float.MaxValue;
    protected CharacterStatHandler stats { get; private set; }
    protected virtual void Awake()
    {
        stats = GetComponent<CharacterStatHandler>();
    }
    private void Update()
    {
        HandleAttackDealy();

        
    }

    private void HandleAttackDealy()
    {
        if (timeSinceLastAttack < stats.CurrentStat.attackSO.delay)
        {
            timeSinceLastAttack += Time.deltaTime;
        }
        else if (IsAttacking && timeSinceLastAttack >= stats.CurrentStat.attackSO.delay)
        {
            timeSinceLastAttack = 0f;
            CallAttackEvent(stats.CurrentStat.attackSO);
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }
    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
    private void CallAttackEvent(AttackSO attackSO)
    {
        OnAttackEvent?.Invoke(attackSO);
    }
}

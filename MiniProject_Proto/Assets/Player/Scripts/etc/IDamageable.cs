using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable 
{
    void TakeHit(float damage, RaycastHit hit);
    void TakeHit2(float damage);
}

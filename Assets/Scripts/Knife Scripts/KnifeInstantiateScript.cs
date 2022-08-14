using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInstantiateScript : MonoBehaviour
{
    
    [SerializeField] GameObject _knifeLeft,_knifeRight;
    
    [SerializeField] Transform _knifeSpawner;
  

    
    public void KnifeLeftInstantiate() 
    {
        
        Instantiate(_knifeLeft, _knifeSpawner);
        
        
    } 
    public void KnifeRightInstantiate() 
    {
        
        Instantiate(_knifeRight, _knifeSpawner);
        
    }

}

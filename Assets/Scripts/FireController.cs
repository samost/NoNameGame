
using UnityEngine;
using UnityEngine.EventSystems;

public class FireController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AnimationHero animationHero;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        
        animationHero.Fire(true);
        
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
       
        animationHero.Fire(false);
    }
}

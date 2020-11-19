using UnityEngine;
public class PlayerRay : MonoBehaviour
{
    private Selectable _currentSelectable;
    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward); // создаём луч, который смотрит вперед
        if (Physics.Raycast(ray, out RaycastHit hit, 10f)) // если луч попал во что-то
        {
            var selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if (selectable)
            {
                if (_currentSelectable != selectable)
                    DeselectCurrent();
                _currentSelectable = selectable;
                selectable.Select();
            }
            else
                DeselectCurrent();
        }
        else
            DeselectCurrent();
    }
    void DeselectCurrent()
    {
        if (_currentSelectable) // если текущее выделение существует, то снимаем его
        {
            _currentSelectable.Deselect();
            _currentSelectable = null;
        }
    }
}

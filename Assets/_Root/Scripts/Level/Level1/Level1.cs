using UnityEngine;
using System;

public class Level1 : Level
{
    public Folk Folk;
    public Pizza[] Pizzas;
    public Pizza PizzaPicked;
    [NonSerialized] public bool IsWin;

    private void Update()
    {
        if (!IsWin)
        {
            if (Input.GetMouseButton(0))
            {
                if (Folk.IsPicked)
                {
                    Folk.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    foreach (var pizza in Pizzas)
                    {
                        if (pizza.IsPicked)
                        {
                            pizza.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition - new Vector3(100, 100, 0));
                            PizzaPicked = pizza;
                        }
                    }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                if (PizzaPicked == Pizzas[Pizzas.Length - 1])
                {
                    IsWin = true;
                    PopupController.Instance.Show<WinPopup>();
                }
            }
        }
    }
}

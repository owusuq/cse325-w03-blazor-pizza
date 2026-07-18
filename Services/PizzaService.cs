using PizzaApp.Models;

namespace PizzaApp.Services;

public class PizzaService
{
    private readonly List<Pizza> _pizzas = new()
    {
        new Pizza { Id = 1, Name = "Margherita", Description = "Tomato, mozzarella, basil", Price = 8.99m },
        new Pizza { Id = 2, Name = "Pepperoni", Description = "Tomato, mozzarella, pepperoni", Price = 10.49m },
        new Pizza { Id = 3, Name = "BBQ Chicken", Description = "BBQ sauce, chicken, red onion", Price = 11.99m },
        new Pizza { Id = 4, Name = "Veggie Supreme", Description = "Peppers, mushrooms, olives, sweetcorn", Price = 9.49m }
    };

    public List<Pizza> GetPizzas() => _pizzas;
}
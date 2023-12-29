//Develop a console-based Inventory Management System using OOP, functions, arrays, lists, and CRUD operations in C#
using System;
using System.Collections.Generic;

class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }

    public Item(int id, string name, double price, double quantity)
    {
        ID = id;
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"ID:{ID}, Name:{Name}, Price:{Price}, Quantity:{Quantity}";
    }
}

class Program
{
    static List<Item> inventory = new List<Item>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Inventory Management System");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. View Items");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    ViewItems();
                    break;
                case 3:
                    UpdateItem();
                    break;
                case 4:
                    DeleteItem();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        double quantity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        int id = inventory.Count + 1;

        Item item = new Item(id, name, price, quantity);

        inventory.Add(item);

        Console.WriteLine("Item added successfully!\n");
    }

    static void ViewItems()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("Inventory is empty.\n");
        }
        else
        {
            Console.WriteLine("ID\tName\tQuantity\tPrice");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item.ID}\t{item.Name}\t{item.Quantity}\t\t{item.Price}");
            }
            Console.WriteLine();
        }
    }

    static void UpdateItem()
    {
        Console.Write("Enter the ID of the item to update: ");
        int itemId = Convert.ToInt32(Console.ReadLine());

        Item item = inventory.Find(i => i.ID == itemId);

        if (item == null)
        {
            Console.WriteLine("Item not found.\n");
        }
        else
        {
            Console.Write("Enter new Quantity: ");
            item.Quantity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter new Price: ");
            item.Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Item updated successfully!\n");
        }
    }

    static void DeleteItem()
    {
        Console.Write("Enter the ID of the item to delete: ");
        int itemId = Convert.ToInt32(Console.ReadLine());

        Item item = inventory.Find(i => i.ID == itemId);

        if (item == null)
        {
            Console.WriteLine("Item not found.\n");
        }
        else
        {
            inventory.Remove(item);
            Console.WriteLine("Item deleted successfully!\n");
        }
    }
}

using Test.DB;
using Test.Interfaces;
using Test.Models;

namespace Test.Service;

public class ModelService : IModelService
{
    private void InitDb()
    {
        using (var context = new ApiContext())
        {
            var itemList = new List<Item>
            {
                new Item
                {
                    Name = "sad",
                    Id = 1,
                },
                new Item
                {
                    Name = "sadasd",
                    Id = 2,
                },
                new Item
                {
                    Name = "sadzxc",
                    Id = 3,
                },
                new Item
                {
                    Name = "sadzxc",
                    Id = 4,
                },
                new Item
                {
                    Name = "sadzxc",
                    Id = 5,
                },
                new Item
                {
                    Name = "sadzxc",
                    Id = 6,
                },
                new Item
                {
                    Name = "sadzxc",
                    Id = 7,
                },
                new Item
                {
                    Name = "sadzxc",
                    Id = 8,
                }
            };

            context.Items.AddRange(itemList);

            context.SaveChanges();
        }
    }
    
    public List<Item> GetItems()
    {

        using (var context = new ApiContext())
        {

            if(!context.Items.Any()) InitDb();

            var res = context.Items.ToList();

            return res;
        }
    }
    public List<Item> GetItems(int start, int end)
    {

        using var context = new ApiContext();

        var isReverse = start > end;
        if (!context.Items.Any()) InitDb();
        if (isReverse)
        {
            (start, end) = (end, start);
        }

        var res = context.Items.Skip(start - 1).Take(end - (start - 1)).ToList();

        if (isReverse)
        {
            res.Reverse();
        }

        return res;
    }
}
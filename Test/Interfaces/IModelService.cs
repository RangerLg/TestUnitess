using Test.Models;

namespace Test.Interfaces;

public interface IModelService
{
    List<Item> GetItems(int start, int end);

    List<Item> GetItems();
}
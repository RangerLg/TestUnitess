using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.DB;
using Test.Interfaces;
using Test.Models;
using Test.Service;

namespace Test.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private IModelService service;

    public ItemController(IModelService service)
    {
        this.service = service;
    }

    /// <summary>
    /// Get items
    /// </summary>
    /// <remarks>Max items 8</remarks>
    /// <returns>Items</returns>
    [HttpGet]
    public List<Item> Get(int start = 0, int end = 0)
    {
        if(start == 0 && end == 0)
        {
            return service.GetItems();
        }

        return service.GetItems(start, end);
    }

}

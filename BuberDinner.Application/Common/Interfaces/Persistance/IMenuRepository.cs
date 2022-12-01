using System;
using BuberDinner.Domain.Menus;

namespace BuberDinner.Application.Common.Interfaces.Persistance;

public interface IMenuRepository
{
    IEnumerable<Menu> GetList(string hostId);
    void Add(Menu menu);
}
using BuberDinner.Domain.Menus;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Menus.Queries;

public class GetMenusQuery : IRequest<ErrorOr<List<Menu>>>
{
    public string HostId { get; }

    public GetMenusQuery(string hostId)
    {
        HostId = hostId;
    }
}
using Mockifyr.Domain.Common;

namespace Mockifyr.Domain.Entities;

public class Mockifyr : BaseAuditableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int MockifyrRequestId { get; set; }
    public int MockifyrResponseId { get; set; }
}

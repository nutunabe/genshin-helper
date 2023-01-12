using GenshinHelper.Application.Common;
using GenshinHelper.Core.Entities;
using MediatR;

namespace GenshinHelper.Application.Requests.CharacterBuilds;

public class CreateCharacterBuild : IRequest<ResponseModel<CharacterBuildDto>>
{
    public string Character { get; set; }
    public List<string> ArtifactSets { get; set; }
    public ArtifactStats ArtifactStats { get; set; }
    public List<string> ArtifactExtraStats { get; set; }
    public List<string> Weapons { get; set; }
    public Talents Talents { get; set; }
    public Stats Stats { get; set; }
}
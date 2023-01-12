using AutoMapper;
using GenshinHelper.Application.Common;
using GenshinHelper.Core.Entities;
using GenshinHelper.Core.Interfaces;
using GenshinHelper.Core.Repositories;
using MediatR;

namespace GenshinHelper.Application.Requests.CharacterBuilds;

public class CreateCharacterBuildHandler : IRequestHandler<CreateCharacterBuild, ResponseModel<CharacterBuildDto>>
{ 
    private readonly ICharacterBuildRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    
    public CreateCharacterBuildHandler(ICharacterBuildRepository repository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<ResponseModel<CharacterBuildDto>> Handle(CreateCharacterBuild request, CancellationToken cancellationToken)
    {
        var build = _mapper.Map<CharacterBuild>(request);
        _repository.AddBuild(build);
        await _unitOfWork.Complete();
        var result = _mapper.Map<CharacterBuildDto>(build);
        return new ResponseModel<CharacterBuildDto>(result);
    }
}
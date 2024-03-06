using MinimalTranslator.Core.Domain;

namespace MinimalTranslator.Application.Interfaces;

public interface ITranslationService
{
    Task Add(Translation translation);
    Task<Translation> Get(Guid id);
}

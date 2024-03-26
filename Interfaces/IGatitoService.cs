namespace GatitoAPI;

public interface IGatitoService
{
    public Task<Models.Gatito> AddGatito(Models.Gatito gatito);
}

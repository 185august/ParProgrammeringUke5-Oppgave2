namespace ParProgrammeringUke5_Oppgave2;

public class MainStore
{
    private IStore _store;
    
    public MainStore(IStore store)
    {
        _store = store;
    }
    
    public void SeeAllPrices()
    {
        _store.SeeAllPrices();
    }
    
    public void ChangeStore(IStore store)
    {
        _store = store;
    }
}
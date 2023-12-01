using Plugin_Framework.Effects;

public static class PluginManager
{
    private static List<IImageEffect> availableEffects;

    static PluginManager()
    {
        availableEffects = new List<IImageEffect>();
        
    }
    public static void RegisterEffect(IImageEffect effect)
    {
        availableEffects.Add(effect);
    }
    public static void RegisterEffectRange(List<IImageEffect> effect)
    {
        availableEffects.AddRange(effect);
    }

    public static void UnRegisterEffect(IImageEffect effect)
    {
        availableEffects.Add(effect);
    }
    public static void UnRegisterEffectRange(List<IImageEffect> effect)
    {
        
        foreach(var eff in effect)
        {
            availableEffects.Remove(eff);
        }
    }


    public static List<IImageEffect> GetAvailableEffects()
    {
        return availableEffects;
    }
    public static void ClearEffects()
    {
        availableEffects.Clear();
    }
}

namespace MaterialRemove.Interfaces
{
    public interface ISectionVolume : ISectionElement
    {
        double SizeX { get; set; }
        double SizeY { get; set; }
        double SizeZ { get; set; }
    }
}

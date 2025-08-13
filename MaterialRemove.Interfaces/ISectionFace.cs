namespace MaterialRemove.Interfaces
{
    public interface ISectionFace : ISectionElement
    {
        double SizeX { get; set; }
        double SizeY { get; set; }
        Orientation Orientation { get; set; }
    }
}

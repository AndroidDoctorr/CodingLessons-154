
public class Room // oh hai mark
{
    // Create a Room class with
    // ✓ Length, Width and Height properties
    // ✓ Floor Area property
    // Volume property
    // Bonus: Wall surface area property

    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public double FloorArea
    {
        get
        {
            return Length * Width;
        }
    }

    public double Volume
    {
        get
        {
            return Length * Width * Height;
        }
    }

    public double WallArea
    {
        get
        {
            double frontBack = Width * Height;
            double sideWall = Length * Height;

            return 2 * frontBack + 2 * sideWall;
        }
    }
}
namespace Warehouse.Abstract;

/// <summary>Обощий базовый контейнер.</summary>
public abstract class Container
{
    /// <summary>Идентификатор контейнера.</summary>
    public int Id { get; }

    /// <summary>Ширина контейнера.</summary>
    public double Width { get; init; }

    /// <summary>Глубина контейнера.</summary>
    public double Depth { get; init; }

    /// <summary>Высота контейнера.</summary>
    public double Height { get; init; }

    /// <summary>Вес контейнера.</summary>
    public abstract double Weight { get; }

    /// <summary>Объём контейнера.</summary>
    public abstract double Volume { get; }

    /// <summary>Дата истечения срока годности контейнера.</summary>
    public abstract DateOnly ExpiryDate { get; }

    protected Container(int id, double width, double depth, double height)
    {
        Id = id;
        Width = width;
        Depth = depth;
        Height = height;
    }
}
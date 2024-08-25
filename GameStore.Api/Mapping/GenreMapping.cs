using GameStore.Api.Dtos;

namespace GameStore.Api.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this GenreDto genre)
    {
        return new GenreDto(genre.Id, genre.Name);
    }
}

namespace GameStore.Api.Dtos;

public record class GameSummaryDto(
    int Id,
    String Name,
    String Genre,
    decimal Price,
    DateOnly ReleaseDate
);

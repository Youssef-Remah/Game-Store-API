# Game Store API

This project is a basic CRUD API for managing a game store, developed using .NET 8, SQLite database, and Entity Framework Core. It provides endpoints to create, read, update, and delete games in the store.

## Features

- **Create:** Add new games to the store.

- **Read:** Retrieve a list of all games or details of a specific game.

- **Update:** Modify existing game details.

- **Delete:** Remove a game from the store.

## Endpoints

**1. Get All Games**

- **URL:** `GET /games`
- **Description:** Retrieves a list of all games, including their genre.
- **Response:** A list of game summaries.

**2. Get Game by ID**

- **URL:** `GET /games/{id}`
- **Description:** Retrieves the details of a specific game by its ID.
- **Response:** Game details or 404 if not found.

**3. Create a New Game**

- **URL:** `POST /games`
- **Description:** Adds a new game to the store.
- **Request Body:** A CreateGameDto object with the new game details.
- **Response:** 201 Created with the game details.

**4. Update an Existing Game**

- **URL:** `PUT /games/{id}`
- **Description:** Updates the details of an existing game by its ID.
- **Request Body:** An UpdateGameDto object with the updated game details.
- **Response:** 204 No Content.

**5. Delete a Game**

- **URL:** `DELETE /games/{id}`
- **Description:** Deletes a game by its ID.
- **Response:** 204 No Content.

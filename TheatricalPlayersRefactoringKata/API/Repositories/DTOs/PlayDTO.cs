﻿using TheatricalPlayersRefactoringKata.Core.Services;

namespace TheatricalPlayersRefactoringKata.API.Repositories.DTOs;

public record PlayRequest(string Name, Genre Type, int Lines);

public record PlayResponse(
    Guid Id,
    string Name,
    Genre Type,
    int Lines);
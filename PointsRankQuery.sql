WITH HomePointsCte(TeamId, TotalPoints) AS (
	SELECT t.TeamId, SUM(g.HomeScore) AS TotalPoints
	FROM dbo.Team t
		INNER JOIN dbo.Game g ON t.TeamId = g.HomeTeamId
	GROUP BY t.TeamId
),
AwayPointsCte(TeamId, TotalPoints) AS (
	SELECT t.TeamId, SUM(g.AwayScore) AS TotalPoints
	FROM dbo.Team t
		INNER JOIN dbo.Game g ON t.TeamId = g.AwayTeamId
	GROUP BY t.TeamId
)
SELECT RANK() OVER (ORDER BY (h.TotalPoints + a.TotalPoints) DESC) AS [Rank],
	t.[Name], (h.TotalPoints + a.TotalPoints) AS TotalPointsScored
	FROM dbo.Team t
		INNER JOIN HomePointsCte h ON t.TeamId = h.TeamId
		INNER JOIN AwayPointsCte a ON t.TeamId = a.TeamId
	ORDER BY TotalPointsScored DESC
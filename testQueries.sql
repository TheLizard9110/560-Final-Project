
--DROP SCHEMA dbo IF EXISTS;
--CREATE SCHEMA dbo;
--REPORT QUERIES

	--List all players with over 500 rushing yards
	DECLARE @RushingYards INT  = 500;

	SELECT p.Name, p.RushingYards, t.[Name] AS TeamName
	FROM dbo.Players p
		INNER JOIN dbo.Team t ON t.TeamId = p.TeamId
	WHERE p.RushingYards > @RushingYards
	ORDER BY p.RushingYards DESC

	--lists players and coach and frontoffice members by one team
	DECLARE @team INT = 22;

	WITH GmName(TeamId, GMName) AS(
	SELECT t.TeamId, f.[Name]
	FROM dbo.Team t
	INNER JOIN dbo.FrontOffice f ON t.TeamId = f.TeamId
	WHERE f.Job = 'GM' OR f.Job = 'Owner/GM'
	),
	OwnerName(TeamId, OwnerName) AS(
	SELECT t.TeamId,f.[Name]
	FROM dbo.Team t
	INNER JOIN dbo.FrontOffice f ON t.TeamId = f.TeamId
	WHERE f.Job = 'Owner' OR f.Job = 'Owner/GM')
	SELECT p.[Name] AS Players, p.PositionalUnit, c.[Name] AS Coach, gm.[GMName] AS GM, o.OwnerName AS Owner
	FROM dbo.Team t
		INNER JOIN dbo.Players p ON p.TeamId = t.TeamId 
		INNER JOIN dbo.Coach c ON t.TeamId = c.TeamId
		INNER JOIN GmName gm ON t.TeamId = gm.TeamId
		INNER JOIN OwnerName o ON t.TeamId = o.TeamId
	WHERE t.TeamId = @team


	--ranks teams by points
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


	--lists coaches by exeprience
	SELECT c.[Name], RANK() OVER (ORDER BY c.Experience DESC) AS [ExpereinceRank], t.[Name] AS TeamName
	FROM dbo.Team t
		INNER JOIN dbo.Coach c ON c.TeamId = t.TeamId
	ORDER BY c.Experience DESC


	--Q Queries
	--touchdowns over a variable that are a certain position or just by touchdowns
	DECLARE @touchdown INT = 15
	DECLARE @position INT = 'QB'
	SELECT * FROM dbo.Players p
	WHERE p.Touchdowns > @touchdown AND p.PositionalUnit = @position
	
	SELECT * FROM dbo.Players p
	WHERE p.Touchdowns > @touchdown
	--a teams players
	DECLARE @teamid INT = 21
	SELECT * FROM dbo.Players p
	WHERE p.TeamId = @teamid
	--Games where either home or away scored over 40 points
	DECLARE @score INT = 40
	SELECT * FROM dbo.Game g
	WHERE g.HomeScore > @score OR g.AwayScore > @score
	--All of ones teams games
	DECLARE @teamid INT = 23
	SELECT * FROM dbo.Game g
	WHERE g.AwayTeamId = @teamid OR g.HomeTeamId = @teamid
	--Games where home team rushed for over a certain amount of yards
	DECLARE @rushingyards = 200
	SELECT * FROM dbo.Game g 
	WHERE g.HomeRushingYards > @rushingyards
	--returns all owner/gm or owner or gm of a team
	DECLARE @job NVARCHAR(16) = 'Owner/GM'
	SELECT f.Name FROM dbo.FrontOffice f
	WHERE f.Job = @job
	--returns coaches with less than a years years of head coaching expereince
	DECLARE @expYears INT = 3
	SELECT * FROM dbo.Coach c
	WHERE c.Experience < @expYears
	--returns all of a positional unit by a points
	DECLARE @positionunit NVARCHAR(4)= 'WR'
	SELECT p.Name, p.Touchdowns, (SELECT t.Name FROM dbo.Team t WHERE t.TeamId = p.TeamId) AS Team FROM dbo.Players p
	WHERE p.PositionalUnit = @positionunit
	ORDER by p.Points DESC

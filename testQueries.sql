
DROP SCHEMA NFLDB IF EXISTS;
CREATE SCHEMA NFLDB;
--needs to replace dbo by NFLDB
--REPORT QUERIES

	--List all players with over 500 rushing yards
	DECLARE @RushingYards INT  = 500;

	SELECT p.Name, p.RushingYards, t.[Name] AS TeamName
	FROM dbo.Players p
		INNER JOIN dbo.Team t ON t.TeamId = p.TeamId
	WHERE p.RushingYards > @RushingYards
	ORDER BY p.RushingYards DESC

	--lists players and coach and frontoffice members by one team
	DECLARE @team INT = 1;
	SELECT p.[Name] AS Players, p.PositionalUnit, c.[Name] AS Coach, f.[Name] AS Owner
	FROM dbo.Team t
		INNER JOIN dbo.Players p ON p.TeamId = t.TeamId 
		INNER JOIN dbo.Coach c ON t.TeamId = c.TeamId
		INNER JOIN dbo.FrontOffice f ON t.TeamId = f.TeamId
	WHERE t.TeamId = @team AND f.Job = 'Owner'
	SELECT f.[Name] AS GM
	FROM dbo.Team t
		INNER JOIN dbo.FrontOffice f ON f.TeamId = t.TeamId
	WHERE t.TeamId = @team AND f.Job = 'GM'


	--COUNTING WINS IS AN ISSUE AND CALCULATING TOTAL POINTS IS INACCURATE
	--ranks teams by wins then points UNFINISHED
	--SELECT --RANK() OVER (ORDER BY COUNT(g.AwayScore AS [Rank],
	--t.Name, SUM(p.Points) AS Points
	--FROM dbo.Team t
	--	INNER JOIN dbo.Players p ON p.TeamId = t.TeamId
		--INNER JOIN dbo.Game g ON g.AwayTeamId = t.TeamId AND g.HomeTeamId = t.TeamId
--		WHERE 
	--GROUP BY t.Name
	--ORDER BY SUM(p.Points) DESC



	--lists coaches by exeprience
	SELECT c.[Name], RANK() OVER (ORDER BY c.Experience DESC) AS [ExpereinceRank], t.[Name] AS TeamName
	FROM dbo.Team t
		INNER JOIN dbo.Coach c ON c.TeamId = t.TeamId
	ORDER BY c.Experience DESC


	--Q Queries
	--touchdowns over 15 that are not QBs
	SELECT * FROM dbo.Players p
	WHERE p.Touchdowns > 15 AND p.PositionalUnit != 'QB'
	--Chiefs players
	SELECT * FROM dbo.Players p
	WHERE p.TeamId = 16
	--Games where either home or away scored over 40 points
	SELECT * FROM dbo.Game g
	WHERE g.HomeScore > 40 OR g.AwayScore > 40
	--All chiefs games
	SELECT * FROM dbo.Game g
	WHERE g.AwayTeamId = 16 OR g.HomeTeamId = 16
	--Games where home team rushed for over 200 yards
	SELECT * FROM dbo.Game g 
	WHERE g.HomeRushingYards > 200
	--returns all owner/gms of a team
	SELECT f.Name FROM dbo.FrontOffice f
	WHERE f.Job = 'Owner/GM'
	--returns coaches with less than 2 years of head coaching expereince
	SELECT * FROM dbo.Coach c
	WHERE c.Experience < 2
	--returns all DBs by interceptions
	SELECT * FROM dbo.Players p
	WHERE p.PositionalUnit = 'S' OR p.PositionalUnit = 'CB'
	ORDER by p.Interceptions DESC

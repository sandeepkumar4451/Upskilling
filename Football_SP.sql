use RashmiAssignment
create table FootBallLeague ( MatchID int primary key,TeamName1 varchar(15),TeamName2 varchar(15),Statuss varchar(5),WinningTeam varchar(10),Points int) 
select * from FootBallLeague
--delete from FootBallLeague
--stored procedure for inserting table records
ALTER PROCEDURE FootBall (
														 @MatchID INT,
														 @TeamName1 VARCHAR(15),
														 @TeamName2 VARCHAR(15),
														 @Statuss VARCHAR(5),
														 @WinningTeam VARCHAR(10),
														 @Points INT)
AS
	BEGIN
		INSERT INTO FootBallLeague(MatchID,TeamName1,TeamName2,Statuss,WinningTeam,Points)
		VALUES(@MatchID,@TeamName1,@TeamName2,@Statuss,@WinningTeam,@Points)
	END

	--INSERTING RECORDS
	EXEC FootBall @MatchID=1001,@TeamName1='Italy',@TeamName2='France',@Statuss='Win',@WinningTeam='France',@Points=4;
	EXEC FootBall @MatchID=1002,@TeamName1='Brazil',@TeamName2='Portugal',@Statuss='Draw',@WinningTeam='null',@Points=4;
	EXEC FootBall @MatchID=1003,@TeamName1='England',@TeamName2='Japan',@Statuss='Win',@WinningTeam='England',@Points=4;
	EXEC FootBall @MatchID=1004,@TeamName1='USA',@TeamName2='Russia',@Statuss='Win',@WinningTeam='Russia',@Points=4;
	EXEC FootBall @MatchID=1005,@TeamName1='Portugal',@TeamName2='Italy',@Statuss='Draw',@WinningTeam='null',@Points=4;
	EXEC FootBall @MatchID=1006,@TeamName1='Brazil',@TeamName2='France',@Statuss='Win',@WinningTeam='Brazil',@Points=4;
	EXEC FootBall @MatchID=1007,@TeamName1='England',@TeamName2='Russia',@Statuss='Win',@WinningTeam='Russia',@Points=4;
	EXEC FootBall @MatchID=1008,@TeamName1='Japan',@TeamName2='USA',@Statuss='Draw',@WinningTeam='null',@Points=4;

select distinct WinningTeam from FootBallLeague where WinningTeam is not null
select * from FootBallLeague where TeamName1='Japan' or TeamName2='Japan'
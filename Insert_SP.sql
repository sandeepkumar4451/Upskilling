use RashmiAssignment
create table bus ( BusID int primary key identity(1,1),BoardingPoint varchar(3),TravelDate date,Amount float,Rating int) 
select * from bus

--stored procedure for inserting table records
CREATE PROCEDURE INSERTPRO(
														 @BoardingPoint VARCHAR(3),
														 @TravelDate DATE,
														 @Amount FLOAT,
														 @Rating INT)
AS
	BEGIN
		INSERT INTO bus(BoardingPoint,TravelDate,Amount,Rating)
		VALUES(@BoardingPoint,@TravelDate,@Amount,@Rating)
	END

	--INSERTING RECORDS
	EXEC INSERTPRO @BoardingPoint='BGL',@TravelDate='2017-06-18',@Amount=400.65,@Rating=2;
	EXEC INSERTPRO @BoardingPoint='HYD',@TravelDate='2017-10-05',@Amount=600.00,@Rating=3;
	EXEC INSERTPRO @BoardingPoint='CHN',@TravelDate='2016-07-25',@Amount=445.95,@Rating=3;
	EXEC INSERTPRO @BoardingPoint='PUN',@TravelDate='2017-12-10',@Amount=543.00,@Rating=4;
	EXEC INSERTPRO @BoardingPoint='MUM',@TravelDate='2017-01-28',@Amount=500.50,@Rating=4;
	EXEC INSERTPRO @BoardingPoint='PUN',@TravelDate='2016-03-26',@Amount=333.55,@Rating=3;
	EXEC INSERTPRO @BoardingPoint='MUM',@TravelDate='2016-11-06',@Amount=510.00,@Rating=4;

select BoardingPoint,TravelDate from bus where Amount>450
select BusID,BoardingPoint from bus where TravelDate='2017-12-10'
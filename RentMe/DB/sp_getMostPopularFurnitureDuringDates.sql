USE [cs6232-g1]
GO

/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/20/2022 1:05:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		CS6232-g1
-- Create date: 04/19/2022
-- Description:	Gets the statistics that show the most popular furniture during the specified period of time for furniture with the same furnintureID that was rented out in at least two transactions.
-- =============================================
CREATE PROCEDURE [dbo].[getMostPopularFurnitureDuringDates] 
	@startDate Date, 
	@endDate Date
AS
BEGIN
	SET NOCOUNT ON;

	IF @startDate IS NULL THROW 50000, 'Start date cannot be null', 1;
	IF @endDate IS NULL THROW 50000, 'End date cannot be null', 1;
	IF @startDate > @endDate THROW 51000, 'Start date must be earlier than the end date', 1;

	DECLARE @total_rentals INT;

	SELECT @total_rentals = COUNT(transactionID)
    FROM rental_transaction
    WHERE CONVERT(DATE, rentalDate) BETWEEN @startDate AND @endDate;

    SELECT ri.furnitureID,
           f.category,
           f.name,
           COUNT(ri.furnitureID) AS furniture_rentals,
           @total_rentals AS all_rentals,
           1.0*COUNT(ri.furnitureID)/@total_rentals AS percent_of_rentals,
		   1.0*COUNT(CASE WHEN (CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, m.dateOfBirth, rt.rentalDate), m.dateOfBirth) > rt.rentalDate 
									 THEN DATEDIFF(YEAR, m.dateOfBirth, rt.rentalDate) - 1
									 ELSE DATEDIFF(YEAR, m.dateOfBirth, rt.rentalDate) 
								END) BETWEEN 18 AND 29 THEN 1 
					 END)/COUNT(*) AS percent_18_to_29,
		   1.0*COUNT(CASE WHEN (CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, m.dateOfBirth, rt.rentalDate), m.dateOfBirth) > rt.rentalDate 
									 THEN DATEDIFF(YEAR, m.dateOfBirth, rt.rentalDate) - 1
									 ELSE DATEDIFF(YEAR, m.dateOfBirth, rt.rentalDate) 
								END) NOT BETWEEN 18 AND 29 THEN 1 
					 END)/COUNT(*) AS percent_not_18_to_29
    FROM rental_item ri JOIN furniture f ON ri.furnitureID = f.furnitureID
    JOIN rental_transaction rt ON ri.transactionID = rt.transactionID
	JOIN member m on rt.memberID = m.memberID
    WHERE CONVERT(DATE, rt.rentalDate) BETWEEN @startDate AND @endDate
    GROUP BY ri.furnitureID, f.category, f.name
    HAVING COUNT(ri.furnitureID) >= 2
    ORDER BY COUNT(ri.furnitureID) DESC, ri.furnitureID DESC;
END
GO


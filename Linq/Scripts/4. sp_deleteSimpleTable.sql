USE [Linq_project]
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteSimpleTable]    Script Date: 6/20/2021 12:41:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan
-- Create date: 6/18/2021
-- Description:	Delete SimpleTable
-- =============================================
ALTER PROCEDURE [dbo].[sp_deleteSimpleTable]
	 @ID NUMERIC(18,0)
	
AS
BEGIN
	UPDATE [dbo].[sampleTable]
		SET lq_status = 1
	WHERE @ID = lqID

	RETURN @@ROWCOUNT

END

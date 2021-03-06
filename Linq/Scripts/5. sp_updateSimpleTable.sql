USE [Linq_project]
GO
/****** Object:  StoredProcedure [dbo].[sp_deleteSimpleTable]    Script Date: 6/20/2021 12:41:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan
-- Create date: 6/19/2021
-- Description:	Update SimpleTable
-- =============================================
CREATE PROCEDURE [dbo].[sp_updateSimpleTable]
	 @ID NUMERIC(18,0),
	 @input VARCHAR(70),
	 @json VARCHAR(100)
	
AS
BEGIN
	UPDATE [dbo].[sampleTable]
	SET
		lq_data =  @input,
		lq_fullInput =  @json,
		lq_response = 'UPDATED',
		lq_modDate = GETDATE()
	WHERE lqID = @ID

	RETURN @@ROWCOUNT

END

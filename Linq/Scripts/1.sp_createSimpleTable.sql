USE [Linq_project]
GO
/****** Object:  StoredProcedure [dbo].[sp_createSimpleTable]    Script Date: 6/18/2021 4:29:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan
-- Create date: 6/18/2021
-- Description:	Insert into table
-- =============================================
ALTER PROCEDURE [dbo].[sp_createSimpleTable]
	 @input VARCHAR(70),
	 @json VARCHAR(100)
	
AS
BEGIN
	INSERT INTO dbo.sampleTable
		(	
			lq_data,
			lq_fullInput,
			lq_response,
			lq_creaDate
		)
	VALUES(
			@input,
			@json,
			'OK',
			GETDATE()
	)

	RETURN SCOPE_IDENTITY()
END

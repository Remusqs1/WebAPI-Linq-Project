USE [Linq_project]
GO
/****** Object:  StoredProcedure [dbo].[sp_getSimpleTableByID]    Script Date: 6/20/2021 1:04:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan
-- Create date: 6/18/2021
-- Description:	get SimpleTable by ID
-- =============================================
CREATE PROCEDURE [dbo].[sp_getSimpleTableByID]
	
	@lqID NUMERIC(18,0)

AS
BEGIN
	SELECT
		lqID,
		lq_data,
		lq_fullInput,
		lq_response,
		lq_creaDate,
		lq_status
	FROM dbo.sampleTable
	WHERE lqID = @lqID
END

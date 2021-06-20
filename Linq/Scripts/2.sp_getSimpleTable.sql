USE [Linq_project]
GO
/****** Object:  StoredProcedure [dbo].[sp_getSimpleTable]    Script Date: 6/20/2021 1:16:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ivan
-- Create date: 6/18/2021
-- Description:	get SimpleTable
-- =============================================
CREATE PROCEDURE [dbo].[sp_getSimpleTable]
	
AS
BEGIN
	SELECT
		lqID,
		lq_data,
		lq_fullInput,
		lq_response,
		lq_creaDate
	FROM dbo.sampleTable
	WHERE lq_status = 0
END

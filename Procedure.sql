USE [PIM]
GO
/****** Object:  StoredProcedure [dbo].[sp_PreencheComboBox]    Script Date: 05/12/2018 22:28:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_PreencheComboBox] 
	@TIPO INT=NULL, @SUBTIPO INT =NULL
AS 
BEGIN

	IF @TIPO=1
	BEGIN
		
		SELECT 0 idArea,'Selecione uma Area' Area
		UNION ALL
		SELECT 
			IdArea,
			Area 
		FROM AREA

	END 

	
	IF @TIPO=2
	BEGIN
		SELECT 0 IdProblema,'Selecione uma Problema' as Problema
		UNION ALL
		SELECT 
			p.IdProblema,
			Problema
		FROM [dbo].[AREA_PROBLEMA] AS A
		JOIN PROBLEMAS AS P
			ON P.IdProblema=A.IdProblema
		WHERE 1=1
			--AND A.IdArea=@SUBTIPO

	END 

	
	IF @TIPO=3
	BEGIN
		
		SELECT 0 IdEmpresa,'Selecione uma Empresa' as Empresa
		UNION ALL
		SELECT 
			IdEmpresa,
			Empresa 
		FROM  [dbo].[EMPRESA]



	END 



END 
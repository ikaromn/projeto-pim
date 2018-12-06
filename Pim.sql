--IF (SELECT 1 FROM PROBLEMAS) IS NOT NULL
--	BEGIN
--		DROP TABLE PROBLEMAS
--	END

CREATE TABLE PROBLEMAS (
	IdProblema int identity,
	Problema varchar(255),
	TempoH int
	PRIMARY KEY (IdProblema) 
)


INSERT INTO PROBLEMAS VALUES ('Internet',4)
INSERT INTO PROBLEMAS VALUES ('Periféricos',48)
INSERT INTO PROBLEMAS VALUES ('Manutenção',72)
INSERT INTO PROBLEMAS VALUES ('Sistema fora do Ar',2)
INSERT INTO PROBLEMAS VALUES ('Visita Técnica',24)
INSERT INTO PROBLEMAS VALUES ('Criação de Acesso',4)
INSERT INTO PROBLEMAS VALUES ('Encomenda Máquinas',24)
INSERT INTO PROBLEMAS VALUES ('Mudanças de Pontos',72)
INSERT INTO PROBLEMAS VALUES ('Wi-fi',3)
INSERT INTO PROBLEMAS VALUES ('Orientação ao Usuário',6)
INSERT INTO PROBLEMAS VALUES ('Migração Servidores',72)

--IF (SELECT TOP 1 1 FROM AREA) IS NOT NULL
--	BEGIN
--	DROP TABLE AREA
--	END

CREATE TABLE AREA
(
	IdArea int identity,
	Area varchar(255)
	PRIMARY KEY (IdArea)
)

INSERT INTO AREA VALUES ('Suporte')
INSERT INTO AREA VALUES ('Infraestrutura')

CREATE TABLE AREA_PROBLEMA
(
	Id int identity,
	IdArea int,
	IdProblema int
	PRIMARY KEY (Id),
	FOREIGN KEY (IdArea) references Area(IdArea),
	FOREIGN KEY (IdProblema) references Problemas(IdProblema)
)

INSERT INTO AREA_PROBLEMA VALUES (1,1)
INSERT INTO AREA_PROBLEMA VALUES (1,2)
INSERT INTO AREA_PROBLEMA VALUES (1,3)
INSERT INTO AREA_PROBLEMA VALUES (1,5)
INSERT INTO AREA_PROBLEMA VALUES (1,6)
INSERT INTO AREA_PROBLEMA VALUES (1,7)
INSERT INTO AREA_PROBLEMA VALUES (1,10)


INSERT INTO AREA_PROBLEMA VALUES (2,1)
INSERT INTO AREA_PROBLEMA VALUES (2,4)
INSERT INTO AREA_PROBLEMA VALUES (2,8)
INSERT INTO AREA_PROBLEMA VALUES (2,9)
INSERT INTO AREA_PROBLEMA VALUES (2,10)


CREATE TABLE EMPRESA 
(
	IdEmpresa INT IDENTITY,
	Empresa varchar(255),
	Descricao varchar(500),
	Endereço varchar(500)
	PRIMARY KEY (IdEmpresa)
)

INSERT INTO EMPRESA values ('Empresa 1','HelpDesk Services','Avenida dos Chamados n°1745')
INSERT INTO EMPRESA values ('Empresa 2','Prestadora de Serviços Azul','Avenida Machona n°123')
INSERT INTO EMPRESA values ('Empresa 3','Prestadora de Serviços Dafitti','Avenida Ceará n°123')
INSERT INTO EMPRESA values ('Empresa 4','Prestadora de Serviços P&G','Avenida Cinderela n°123')
INSERT INTO EMPRESA values ('Empresa 5','Prestadora de Serviços StMarche','Avenida Shazam n°123')


CREATE TABLE FUNCOES 
(
	IdFuncao Int identity,
	Funcao varchar(255)
	PRIMARY KEY(IdFuncao)
)

Insert into FUNCOES VALUES ('Admin')
Insert into FUNCOES VALUES ('Cliente')
Insert into FUNCOES VALUES ('ClienteAdm')
Insert into FUNCOES VALUES ('Operador')
Insert into FUNCOES VALUES ('Operador2')
Insert into FUNCOES VALUES ('Coordenador')


--DROP TABLE USUARIOS

CREATE TABLE USUARIOS 
(
	IdUsuario Int identity,
	Login varchar(255),
	Senha varchar(255),
	Nome varchar(300),
	IdEmpresa Int,
	IdFuncao int,

	FOREIGN KEY (IdEmpresa) REFERENCES EMPRESA(IdEmpresa),
	FOREIGN KEY (IdFuncao) REFERENCES FUNCOES(IdFuncao)
)

INSERT INTO USUARIOS VALUES ('Admin','Admin123','Administrador',1,1)
INSERT INTO USUARIOS VALUES ('Cliente','Cliente123','Cliente1',2,2)
INSERT INTO USUARIOS VALUES ('Cliente2','Cliente123','Cliente2',2,3)
INSERT INTO USUARIOS VALUES ('Operador','Operador123','Operador1',1,4)
INSERT INTO USUARIOS VALUES ('Operador2','Operador123','Operador2',1,5)
INSERT INTO USUARIOS VALUES ('Coordenador','Coord123','Coordenador',1,6)


CREATE TABLE TELAS_MENU
(
	IdTela INT IDENTITY,
	Nome VARCHAR(255),
	Link VARCHAR(MAX)
	PRIMARY KEY (IdTela)
)

INSERT INTO TELAS_MENU VALUES ('Usuário','../Chamados/Usuario.aspx')
INSERT INTO TELAS_MENU VALUES ('Usuarios','../Chamados/Usuarios.aspx')
INSERT INTO TELAS_MENU VALUES ('Abrir Chamado','../Chamados/ChamadoAbrir.aspx')
INSERT INTO TELAS_MENU VALUES ('Painel','../Chamados/ChamadoConsultar.aspx')
INSERT INTO TELAS_MENU VALUES ('Relatório','../Chamados/ChamadosRelatorio.aspx')


CREATE TABLE TELA_USUARIOS
(
	IdFuncaoRef INT,
	IdTelaRef INT
	

	FOREIGN KEY (IdTelaRef) references TELAS_MENU(IdTela),
	FOREIGN KEY (IdFuncaoRef) references FUNCOES(IdFuncao) 
)

INSERT INTO TELA_USUARIOS VALUES (1,1)
INSERT INTO TELA_USUARIOS VALUES (1,2)
INSERT INTO TELA_USUARIOS VALUES (1,3)
INSERT INTO TELA_USUARIOS VALUES (1,4)
INSERT INTO TELA_USUARIOS VALUES (1,5)
INSERT INTO TELA_USUARIOS VALUES (2,1)
INSERT INTO TELA_USUARIOS VALUES (2,3)
INSERT INTO TELA_USUARIOS VALUES (2,4)


CREATE TABLE [dbo].[CHAMADOS](
	[IdChamado] [int] IDENTITY(1,1) NOT NULL,
	[IdProblema] [int] NULL,
	[IdArea] [int] NULL,
	[IdEmpresa] [int] NULL,
	[Descricao] [varchar](255) NULL,
	[Solicitante] [varchar](255) NULL,
	[Status] [varchar](100) NULL,
	[DataAbertura] [datetime] NULL,
	[DataFechamento] [datetime] NULL,
	[TelefoneContato] [bigint] NULL,
	[operador] [varchar](255) NULL,
	[Mensagemalt] [varchar](255) NULL,
	[Mensagemfinal] [varchar](500) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CHAMADOS] ADD  DEFAULT ('AGUARDANDO ATENDIMENTO') FOR [Status]
GO

ALTER TABLE [dbo].[CHAMADOS] ADD  DEFAULT (getdate()) FOR [DataAbertura]
GO

ALTER TABLE [dbo].[CHAMADOS] ADD  DEFAULT (NULL) FOR [Mensagemfinal]
GO



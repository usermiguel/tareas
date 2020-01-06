Create database Objetivo_Tarea
Go
use Objetivo_Tarea
Create table tblCalificacion
(
Codigo				int				Primary key identity,
Descripcion			varchar(500)	not null,
FechaHoraRegistro	datetime not null,
NombreBreve			varchar(30)	not null,
NombreCompleto		varchar(70)	not null
)
GO

CREATE procedure usp_Insertar_Calificacion

@calDescripcion		varchar(500),
@CalNombreBreve		varchar(30),
@CalNombreCompleto		varchar(70)
As
insert into tblCalificacion
(Descripcion,NombreBreve,NombreCompleto,FechaHoraRegistro)
Values 
(@calDescripcion,@CalNombreBreve,@CalNombreCompleto,GETDATE())
GO


CREATE procedure usp_listar_calificacion
as
select Codigo, Descripcion, FechaHoraRegistro, NombreBreve, NombreCompleto
from tblCalificacion
order by codigo
GO

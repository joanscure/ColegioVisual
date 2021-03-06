CREATE DATABASE [primeros_frutos]
go
USE [primeros_frutos]
GO
/****** Object:  StoredProcedure [dbo].[spbuscar_Alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_Alumno]
@textbuscar varchar (50),
@textbuscar1 varchar (50)
as
select alumno.id_alumno,alumno.nombres as Nombre ,alumno.apellidos as Apellido, alumno.dni as DNI , alumno.fecha_naci as 'Fecha de Nacimiento', alumno.sexo as Sexo, alumno.edad as Edad,alumno.id_padre,alumno.id_madre,alumno.id_año,alumno.codigo as Codigo, alumno.lugar_naci as 'Lugar de Nacimiento', alumno.domi_actual as 'Domicilio Actual', alumno.direccion as Direccion, alumno.n_partida as 'N° de Partida',alumno.religion as Religion,alumno.len_materna as 'Lengua Materna', alumno.n_hermanos as 'N° de Hermanos', alumno.lugar_ocupa as 'Lugar que Ocupa', alumno.cole_procedencia as 'Colegio de Procedencia', alumno.discapacidad as Discapacidad ,alumno.parto as Parto, madre.apellido_materno_ma,madre.nombre_ma,padre.apellido_pa,padre.nombre_pa,año.descripcion

from  alumno inner join madre on alumno.id_madre=madre.id_madre inner join padre on alumno.id_padre=padre.id_padre inner join año on alumno.id_año=año.id_año
where alumno.apellidos like @textbuscar + '%' and alumno.nombres like @textbuscar1 + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_alumnogite]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spbuscar_alumnogite]
@textbuscar varchar (50),
@textbuscar1 varchar (50)
as
select  alumno.id_alumno,alumno.nombres ,alumno.apellidos,alumno.dni,alumno.fecha_naci,alumno.sexo,alumno.edad,alumno.id_padre,alumno.id_madre,alumno.id_año,alumno.codigo,alumno.lugar_naci,alumno.domi_actual,alumno.direccion,alumno.n_partida,alumno.religion,alumno.len_materna,alumno.n_hermanos,
        alumno.lugar_ocupa,alumno.cole_procedencia,alumno.discapacidad,alumno.parto,madre.nombre_ma,madre.apellido_materno_ma,madre.dni_ma,madre.email_ma,madre.ocuacion_ma,madre.esta_civil_ma,madre.celular_ma,madre.grado_estudio_ma,madre.centro_trabajo_ma,madre.domi_actual_ma,madre.fecha_defu as fecha_defun_ma,madre.fecha_naci as fecha_naci_ma,madre.lugar_naci as lugar_naci_ma, madre.vive as vive_ma,madre.vive_con_estu as vive_von_etu_ma,
		padre.nombre_pa,padre.apellido_pa,padre.dni_pa,padre.email_pa,padre.ocuacion_pa,padre.esta_civil_pa,padre.celular_pa,padre.grado_estudio_pa,padre.centro_trabajo_pa,padre.domi_actual_pa,padre.fecha_defu as fecha_defun_pa,padre.fecha_naci as fecha_naci_pa,padre.lugar_naci as lugar_naci_pa, padre.vive as vive_pa,padre.vive_con_estu as vive_von_etu_pa
		 from alumno INNER JOIN PADRE ON ALUMNO.id_padre=padre.id_padre INNER JOIN madre on ALUMNO.id_madre=madre.id_madre 

where alumno.nombres like @textbuscar + '%' and alumno.apellidos like @textbuscar1 + '%'




GO
/****** Object:  StoredProcedure [dbo].[spbuscar_año]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_año]
@textbuscar varchar (50)
as
select año.id_año, año.descripcion as 'Nombre del Año' ,año.año as Año
from año 
where año.año like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spbuscar_curso]
@textbuscar varchar (50)
as
select * from curso 
where curso.nombre like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_curso_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_curso_alumno]
@textbuscar varchar (50)

as
select curso_alumno.id_curso_alumno,curso_alumno.id_profe_curso, curso_alumno.id_alumno,alumno.nombres as Nombres,alumno.apellidos as Apellidos,curso.nombre as Curso, curso.grado AS Grado,curso.año as Año, profesor.nombre,profesor.apellidos
from  curso_alumno inner join alumno on curso_alumno.id_alumno= alumno.id_alumno inner join profe_curso on curso_alumno.id_profe_curso=profe_curso.id_profe_curso inner join curso on profe_curso.id_profe_curso=curso.id_curso inner join profesor on profe_curso.id_profesor=profesor.id_profesor
where alumno.apellidos like @textbuscar + '%' 

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_cursoprofesor]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_cursoprofesor]
@textbuscar varchar (50)
as
select profe_curso.id_profe_curso,profe_curso.id_profesor,profe_curso.id_curso,profesor.nombre as Nombres ,profesor.apellidos as Apellidos,curso.nombre as 'Curso',curso.grado as Grado,curso.año as Año from profe_curso inner join profesor on profe_curso.id_profesor=profesor.id_profesor inner join curso on profe_curso.id_curso=curso.id_curso
where profesor.apellidos like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_detadeuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_detadeuda]
@textbuscar varchar (50)
as
select detalle_deuda.id_alumno,detalle_deuda.id_deuda,detalle_deuda.id_deta_deuda,alumno.nombres as Nombre,alumno.apellidos as Apellido,deuda.descripcion as  Deuda,deuda.monto as Monto from detalle_deuda inner join alumno on detalle_deuda.id_alumno=alumno.id_alumno inner join deuda on detalle_deuda.id_deuda=deuda.id_deuda
where alumno.apellidos like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_deuda]
@textbuscar varchar (50)
as
select deuda.id_deuda, deuda.descripcion as Descripcion  ,deuda.monto as  'Monto a Pagar'
from deuda
where deuda.id_deuda like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_login]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_login]
@textbuscar varchar (50)
as
select LOGIN.id_login,profesor.apellidos as Apellido,profesor.nombre AS Nombre,LOGIN.id,LOGIN.contraseña,LOGIN.acceso as Acceso,LOGIN.id_profesor
 from LOGIN inner join profesor on LOGIN.id_profesor=profesor.id_profesor
where profesor.apellidos like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_madre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_madre]
@textbuscar varchar (50),
@textbuscar1 varchar (50)
as
select madre.id_madre,madre.nombre_ma AS Nombres,madre.apellido_materno_ma as Apellidos, madre.dni_ma as DNI, madre.email_ma AS 'E-mail',madre.ocuacion_ma as Ocupacion , madre.esta_civil_ma as 'Estado Civil',madre.celular_ma AS Celular, madre.grado_estudio_ma as 'Grado de Estudios',madre.centro_trabajo_ma as 'Centro de Trabajo',madre.domi_actual_ma as 'Domicilio Actual',madre.fecha_naci as 'Fecha de Nacimiento',madre.fecha_defu as 'Fecha de Defuncion',madre.lugar_naci as 'Lugar de Nacimiento', madre.vive_con_estu as 'Vive con el Alumno' , madre.vive as Vive
 from madre
where madre.nombre_ma like @textbuscar + '%' and madre.apellido_materno_ma like @textbuscar1 + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_nota]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_nota]

@textbuscar1 varchar (50),
@textbuscar3 varchar (50)

as
select profe_curso.id_curso,alumno.nombres as NOMBRE,alumno.apellidos as APELLIDO,alumno.id_alumno, curso_alumno.id_curso_alumno, CURSO.nombre AS CURSO,nota.n1 AS N1,nota.n2 as N2,nota.n3 AS N3,nota.n4 AS N4,nota.id_nota,curso.grado as Grado,curso.año as Año
from profe_curso inner join profesor on profe_curso.id_profesor=profesor.id_profesor  inner join curso on profe_curso.id_curso=curso.id_curso INNER JOIN curso_alumno ON profe_curso.id_profe_curso=curso_alumno.id_profe_curso INNER JOIN alumno on curso_alumno.id_alumno=alumno.id_alumno INNER JOIN NOTA ON curso_alumno.id_curso_alumno=nota.id_curso_alumno
where alumno.apellidos like @textbuscar1 + '%'  and alumno.nombres like @textbuscar3 +  '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_padre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_padre]
@textbuscar varchar (50),
@textbuscar1 varchar (50)
as
select padre.id_padre,padre.nombre_pa AS Nombres,padre.apellido_pa as Apellidos, padre.dni_pa as DNI, padre.email_pa AS 'E-mail',padre.ocuacion_pa as Ocupacion , padre.esta_civil_pa as 'Estado Civil',padre.celular_pa AS Celular, padre.grado_estudio_pa as 'Grado de Estudios',padre.centro_trabajo_pa as 'Centro de Trabajo',padre.domi_actual_pa as 'Domicilio Actual',padre.fecha_naci as 'Fecha de Nacimiento',padre.fecha_defu as 'Fecha de Defuncion',padre.lugar_naci as 'Lugar de Nacimiento', padre.vive_con_estu as 'Vive con el Alumno' , padre.vive as Vive from padre
where padre.nombre_pa like @textbuscar + '%' and padre.apellido_pa like @textbuscar1 + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_pago]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_pago]
@textbuscar varchar (50)
as
select pago.id_pago, alumno.nombres as Nombre,alumno.apellidos AS Apellido,deuda.descripcion as Deuda,deuda.monto AS Monto, pago.cantidad_pagar as 'Cantidad a Pagar',pago.id_deta_deuda,pago.fecha_pago as 'Fecha de Pago',pago.debe as Debe,detalle_deuda.id_alumno
from pago inner join detalle_deuda on pago.id_deta_deuda=detalle_deuda.id_deta_deuda inner join alumno on detalle_deuda.id_alumno=alumno.id_alumno inner join deuda on detalle_deuda.id_deuda=deuda.id_deuda
where alumno.apellidos like @textbuscar + '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_profe_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_profe_curso]
@textbuscar varchar (50)
as
select id_profe_curso,profe_curso.id_profesor,profe_curso.id_curso,profesor.nombre as 'Nombre Pofesor',profesor.apellidos as 'Apellidos Profesor',curso.nombre as 'Nombre Curso' from profe_curso inner join profesor on profe_curso.id_profesor=profesor.id_profesor inner join curso on profe_curso.id_curso=curso.id_curso
where profesor.apellidos like @textbuscar + '%'


GO
/****** Object:  StoredProcedure [dbo].[spbuscar_profesor]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_profesor]

@textbuscar1 varchar (50),
@textbuscar3 varchar (50)

as
select profesor.id_profesor,profesor.nombre as Nombre ,profesor.apellidos as Apellido, profesor.dni as DNI, profesor.celular as Celular,profesor.email as 'E-mail',profesor.fecha_naci as 'Fecha de Nacimiento' ,profesor.edad as Edad ,profesor.id_año,año.año
 from profesor inner join año on profesor.id_año=año.id_año
 where profesor.apellidos like @textbuscar1 + '%'  and profesor.nombre like @textbuscar3 +  '%'

GO
/****** Object:  StoredProcedure [dbo].[spbuscar_tablamaestro]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_tablamaestro]
@textbuscar varchar (50),
@textbuscar1 varchar (50)
as
select profe_curso.id_profe_curso,profe_curso.id_profesor,profe_curso.id_curso,curso.nombre as nombre_curso,curso.grado,profesor.nombre as nombre_profesor,profesor.apellidos,LOGIN.id ,LOGIN.acceso
from profe_curso inner join profesor on profe_curso.id_profesor=profesor.id_profesor inner join login on login.id_profesor=profesor.id_profesor inner join curso on profe_curso.id_curso=curso.id_curso
where LOGIN.id like @textbuscar +'%' and LOGIN.acceso like @textbuscar1 + '%'



GO
/****** Object:  StoredProcedure [dbo].[spbuscar_tablamaestro2]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spbuscar_tablamaestro2]

@textbuscar1 varchar (50),
@textbuscar3 varchar (50)

as
select profe_curso.id_curso,alumno.nombres as NOMBRE,alumno.apellidos as APELLIDO,alumno.id_alumno, curso_alumno.id_curso_alumno, CURSO.nombre AS CURSO, profesor.nombre AS NOMBREP,profesor.apellidos AS PELLIDOP,nota.n1,nota.n2,nota.n3,nota.n4,nota.id_nota
from profe_curso inner join profesor on profe_curso.id_profesor=profesor.id_profesor inner join login on login.id_profesor=profesor.id_profesor inner join curso on profe_curso.id_curso=curso.id_curso INNER JOIN curso_alumno ON profe_curso.id_profe_curso=curso_alumno.id_profe_curso INNER JOIN alumno on curso_alumno.id_alumno=alumno.id_alumno INNER JOIN NOTA ON curso_alumno.id_curso_alumno=nota.id_curso_alumno
where LOGIN.id like @textbuscar1 + '%'  and profe_curso.id_profe_curso like @textbuscar3 +  '%'


GO
/****** Object:  StoredProcedure [dbo].[speditar_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[speditar_alumno]
@id_alumno int,
	@nombres varchar(50),
	@apellidos varchar(50) ,
	@dni char(8) ,
	@fecha_naci date,
	@sexo varchar(50),
	@edad varchar(20),
	@id_padre int,
	@id_madre int,
	@id_año int,
	@codigo varchar(50),
	@lugar_naci varchar(50),
	@domi_actual varchar(50),
	@direccion varchar(50),
	@n_partida varchar(50),
	@religion varchar(50),
	@len_materna varchar(50),
	@n_hermanos varchar(10),
	@lugar_ocupa varchar(50),
	@cole_procedencia varchar(50),
	@discapacidad char(2),
	@parto char(2)
AS
update alumno set nombres=@nombres,apellidos=@apellidos,dni=@dni,fecha_naci=@fecha_naci,sexo=@sexo,edad=@edad,id_padre=@id_padre,id_madre=@id_madre,id_año=@id_año,codigo=@codigo,lugar_naci=@lugar_naci,domi_actual=@domi_actual,direccion=@direccion,n_partida=@n_partida,religion=@religion,len_materna=@len_materna,n_hermanos=@n_hermanos,lugar_ocupa=@lugar_ocupa,cole_procedencia=@cole_procedencia,discapacidad=@discapacidad,parto=@parto
where id_alumno=@id_alumno
  

  




GO
/****** Object:  StoredProcedure [dbo].[speditar_año]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[speditar_año]
@id_año INT ,
@descripcion VARCHAR (50),
@año varchar(10)

AS
update año set descripcion=@descripcion, año=@año
where id_año=@id_año


GO
/****** Object:  StoredProcedure [dbo].[speditar_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[speditar_curso]
@id_curso INT ,
@nombre VARCHAR (50),
@grado varchar(50),
@año varchar(50)

AS
update curso set nombre=@nombre, grado=@grado, año=@año
where id_curso=@id_curso


GO
/****** Object:  StoredProcedure [dbo].[speditar_curso_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_curso_alumno]
@id_curso_alumno int,
	@id_profe_curso int ,
	@id_alumno int 
	

AS
update curso_alumno set id_profe_curso=@id_profe_curso, id_alumno=@id_alumno
where id_curso_alumno=@id_curso_alumno


GO
/****** Object:  StoredProcedure [dbo].[speditar_detalle_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_detalle_deuda]
@id_deta_deuda int ,
	@id_deuda int ,
	@id_alumno int 
	

AS
update detalle_deuda set id_deuda=@id_deuda, id_alumno=@id_alumno
where id_deta_deuda=@id_deta_deuda


GO
/****** Object:  StoredProcedure [dbo].[speditar_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_deuda]
 @id_deuda int  ,
	@descripcion varchar(50) ,
	@monto money 
	

AS
update  deuda set descripcion=@descripcion, monto=@monto
where id_deuda=@id_deuda


GO
/****** Object:  StoredProcedure [dbo].[speditar_login]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_login]
@id_login int ,
	@id char(8) ,
	@contraseña char(8) ,
	@acceso varchar(50) ,
    @id_profesor int
	

AS
update  login set id=@id, contraseña=@contraseña, acceso=@acceso, id_profesor=@id_profesor
where id_login=@id_login


GO
/****** Object:  StoredProcedure [dbo].[speditar_madre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_madre]
@id_madre int,
	@nombre_ma varchar(50),
	@apellido_materno_ma varchar(50) ,
	@dni_ma char(8) ,
	@email_ma varchar(50),
	@ocuacion_ma varchar(50),
	@esta_civil_ma varchar(50),
	@celular_ma varchar(10),
	@grado_estudio_ma varchar(50),
	@centro_trabajo_ma varchar(50),
	@domi_actual_ma varchar(50),
	@fecha_defu date,
    @fecha_naci date,
	@lugar_naci varchar(50),
	@vive char(2),
	@vive_con_estu char(2)
AS
update madre set nombre_ma=@nombre_ma,apellido_materno_ma=@apellido_materno_ma,dni_ma=@dni_ma,email_ma=@email_ma,
       ocuacion_ma=@ocuacion_ma,esta_civil_ma=@esta_civil_ma,celular_ma=@celular_ma,grado_estudio_ma=@grado_estudio_ma,
	   centro_trabajo_ma=@centro_trabajo_ma,domi_actual_ma=@domi_actual_ma,fecha_defu=@fecha_defu,fecha_naci=@fecha_naci,
	   lugar_naci=@lugar_naci,vive=@vive,vive_con_estu=@vive_con_estu
where id_madre=@id_madre


GO
/****** Object:  StoredProcedure [dbo].[speditar_nota]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_nota]
 @id_nota int,
	@n1 int ,
	@n2 int ,
	@n4 int ,
    @id_curso_alumno int,
	@n3 int 
AS
update nota set n1=@n1, n2=@n2 ,n3=@n3 ,id_curso_alumno=@id_curso_alumno,n4=@n4
where id_nota=@id_nota


GO
/****** Object:  StoredProcedure [dbo].[speditar_padre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[speditar_padre]
@id_padre int,
	@nombre_pa varchar(50),
	@apellido_pa varchar(50) ,
	@dni_pa char(8) ,
	@email_pa varchar(50),
	@ocuacion_pa varchar(50),
	@esta_civil_pa varchar(50),
	@celular_pa varchar(10),
	@grado_estudio_pa varchar(50),
	@centro_trabajo_pa varchar(50),
	@domi_actual_pa varchar(50),
	@fecha_defu date,
    @fecha_naci date,
	@lugar_naci varchar(50),
	@vive char(2),
	@vive_con_estu char(2)
AS
update padre set nombre_pa=@nombre_pa,apellido_pa=@apellido_pa,dni_pa=@dni_pa,email_pa=@email_pa,
       ocuacion_pa=@ocuacion_pa,esta_civil_pa=@esta_civil_pa,celular_pa=@celular_pa,grado_estudio_pa=@grado_estudio_pa,
	   centro_trabajo_pa=@centro_trabajo_pa,domi_actual_pa=@domi_actual_pa,fecha_defu=@fecha_defu,fecha_naci=@fecha_naci,
	   lugar_naci=@lugar_naci,vive=@vive,vive_con_estu=@vive_con_estu
where id_padre=@id_padre
  

  



GO
/****** Object:  StoredProcedure [dbo].[speditar_pago]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_pago]
 @id_pago int  ,
	@cantidad_pagar money ,
    @id_deta_deuda int,
	@fecha_pago date
AS
update pago set cantidad_pagar=@cantidad_pagar,id_deta_deuda=@id_deta_deuda ,fecha_pago=@fecha_pago
where id_pago=@id_pago


GO
/****** Object:  StoredProcedure [dbo].[speditar_profe_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_profe_curso]
@id_profe_curso int,
	@id_profesor int ,
    @id_curso int
AS
update profe_curso set id_profesor=@id_profesor,id_curso=@id_curso 
where id_profe_curso=@id_profe_curso


GO
/****** Object:  StoredProcedure [dbo].[speditar_profesor]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speditar_profesor]
@id_profesor int output,
    @nombre varchar(50),
    @apellidos varchar(50),
    @dni char(8),
    @celular varchar(10),
    @email varchar(50),
    @fecha_naci date,
    @edad varchar(2),
    @id_año int
AS
update profesor set nombre=@nombre,apellidos=@apellidos,dni=@dni,celular=@celular, email=@email,fecha_naci=@fecha_naci,edad=@edad,id_año=@id_año
       
where id_profesor=@id_profesor


GO
/****** Object:  StoredProcedure [dbo].[speliminar_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_alumno]
@id_alumno int
AS
delete from alumno
where id_alumno=@id_alumno





GO
/****** Object:  StoredProcedure [dbo].[speliminar_año]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_año]
@id_año int
AS
delete from año
where id_año=@id_año





GO
/****** Object:  StoredProcedure [dbo].[speliminar_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_curso]
@id_curso int
AS
delete from curso
where id_curso=@id_curso





GO
/****** Object:  StoredProcedure [dbo].[speliminar_curso_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_curso_alumno]
@id_curso_alumno int
AS
delete from curso_alumno
where id_curso_alumno=@id_curso_alumno



GO
/****** Object:  StoredProcedure [dbo].[speliminar_detalle_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_detalle_deuda]
@id_deta_deuda int
AS
delete from detalle_deuda
where id_deta_deuda=@id_deta_deuda





GO
/****** Object:  StoredProcedure [dbo].[speliminar_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_deuda]
@id_deuda int
AS
delete from deuda
where id_deuda=@id_deuda





GO
/****** Object:  StoredProcedure [dbo].[speliminar_login]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_login]
@id_login int
AS
delete from LOGIN
where id_login=@id_login




GO
/****** Object:  StoredProcedure [dbo].[speliminar_madre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_madre]
@id_madre int
AS
delete from madre
where id_madre=@id_madre





GO
/****** Object:  StoredProcedure [dbo].[speliminar_padre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_padre]
@id_padre int
AS
delete from padre
where id_padre=@id_padre





GO
/****** Object:  StoredProcedure [dbo].[speliminar_pago]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_pago]
@id_pago int
AS
delete from pago
where id_pago=@id_pago



GO
/****** Object:  StoredProcedure [dbo].[speliminar_profesor]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[speliminar_profesor]
@id_profesor int
AS
delete from profesor
where id_profesor=@id_profesor





GO
/****** Object:  StoredProcedure [dbo].[spinsertar_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_alumno]
    @id_alumno int output,
	@nombres varchar(50),
	@apellidos varchar(50) ,
	@dni char(8) ,
	@fecha_naci date,
	@sexo varchar(50),
	@edad varchar(20),
	@id_padre int,
	@id_madre int,
	@id_año int,
	@codigo varchar(50),
	@lugar_naci varchar(50),
	@domi_actual varchar(50),
	@direccion varchar(50),
	@n_partida varchar(50),
	@religion varchar(50),
	@len_materna varchar(50),
	@n_hermanos varchar(10),
	@lugar_ocupa varchar(50),
	@cole_procedencia varchar(50),
	@discapacidad char(2),
	@parto char(2)
AS

insert into alumno(nombres,apellidos,dni,fecha_naci,sexo,edad,id_padre,id_madre,id_año,codigo,lugar_naci,domi_actual,direccion,n_partida,religion,len_materna,n_hermanos,lugar_ocupa,cole_procedencia,discapacidad,parto)
values (@nombres,@apellidos,@dni,@fecha_naci,@sexo,@edad,@id_padre,@id_madre,@id_año,@codigo,@lugar_naci,@domi_actual,@direccion,@n_partida,@religion,@len_materna,@n_hermanos,@lugar_ocupa,@cole_procedencia,@discapacidad,@parto)









GO
/****** Object:  StoredProcedure [dbo].[spinsertar_año]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spinsertar_año]
@id_año INT output,
@descripcion VARCHAR (50),
@año varchar(10)

AS
insert into año(descripcion,año)
values (@descripcion,@año)




GO
/****** Object:  StoredProcedure [dbo].[spinsertar_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_curso]
@id_curso INT output,
@nombre VARCHAR (50),
@grado varchar(50),
@año varchar(50)

AS
insert into curso(nombre,grado,año)
values (@nombre,@grado,@año)

GO
/****** Object:  StoredProcedure [dbo].[spinsertar_curso_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_curso_alumno]
    @id_curso_alumno int output,
	@id_profe_curso int ,
	@id_alumno int 
	
	
    
    
	
AS
DECLARE @CODI INT
insert into curso_alumno(id_profe_curso,id_alumno)
values(@id_profe_curso,@id_alumno)
SET @CODI=SCOPE_IDENTITY()
 
INSERT INTO [dbo].[nota]
           ([n1]
           ,[n2]
           ,[n4]
           ,[id_curso_alumno]
           ,[n3])
     VALUES
           (0,0,0,@CODI,0)
           


GO
/****** Object:  StoredProcedure [dbo].[spinsertar_detalle_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spinsertar_detalle_deuda]
    @id_deta_deuda int output,
	@id_deuda int ,
	@id_alumno int 
	
	
    
    
	
AS
insert into detalle_deuda(id_deuda,id_alumno)
values(@id_deuda,@id_alumno)




GO
/****** Object:  StoredProcedure [dbo].[spinsertar_deuda]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_deuda]
    @id_deuda int output,
	@descripcion varchar(50) ,
	@monto int 
	
	
    
    
	
AS
insert into deuda(descripcion,monto)
values(@descripcion,@monto)

GO
/****** Object:  StoredProcedure [dbo].[spinsertar_login]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spinsertar_login]
    @id_login int output,
	@id char(8) ,
	@contraseña char(8) ,
	@acceso varchar(50) ,
    @id_profesor int
	
    
    
	
AS
insert into login(id,contraseña,acceso,id_profesor)
values (@id,@contraseña,@acceso,@id_profesor)



GO
/****** Object:  StoredProcedure [dbo].[spinsertar_madre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_madre]
    @id_madre int output,
	@nombre_ma varchar(50),
	@apellido_materno_ma varchar(50) ,
	@dni_ma char(8) ,
	@email_ma varchar(50),
	@ocuacion_ma varchar(50),
	@esta_civil_ma varchar(50),
	@celular_ma varchar(10),
	@grado_estudio_ma varchar(50),
	@centro_trabajo_ma varchar(50),
	@domi_actual varchar(50),
	@fecha_defu varchar(50),
    @fecha_naci date,
	@lugar_naci varchar(50),
	@vive char(2),
	@vive_con_estu char(2)
	
	
	
AS
insert into madre(nombre_ma,apellido_materno_ma,dni_ma,email_ma,ocuacion_ma,esta_civil_ma,celular_ma,grado_estudio_ma,centro_trabajo_ma,domi_actual_ma,fecha_defu,fecha_naci,lugar_naci,vive,vive_con_estu)
values (@nombre_ma,@apellido_materno_ma,@dni_ma,@email_ma,@ocuacion_ma,@esta_civil_ma,@celular_ma,@grado_estudio_ma,@centro_trabajo_ma,@domi_actual,@fecha_defu,@fecha_naci,@lugar_naci,@vive,@vive_con_estu)

GO
/****** Object:  StoredProcedure [dbo].[spinsertar_nota]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spinsertar_nota]
    @id_nota int output,
	@n1 int ,
	@n2 int ,
	@n4 int ,
    @id_curso_alumno int,
	@n3 int 
    
    
	
AS
insert into nota(n1,n2,n4,id_curso_alumno,n3)
values (@n1,@n2,@n4,@id_curso_alumno,@n3)



GO
/****** Object:  StoredProcedure [dbo].[spinsertar_padre]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_padre]
    @id_padre int output,
	@nombre_pa varchar(50),
	@apellido_pa varchar(50) ,
	@dni_pa char(8) ,
	@email_pa varchar(50),
	@ocuacion_pa varchar(50),
	@esta_civil_pa varchar(50),
	@celular_pa varchar(10),
	@grado_estudio_pa varchar(50),
	@centro_trabajo_pa varchar(50),
	@domi_actual varchar(50),
	@fecha_defu varchar(50),
    @fecha_naci date,
	@lugar_naci varchar(50),
	@vive char(2),
	@vive_con_estu char(2)
	
	
	
AS
insert into padre(nombre_pa,apellido_pa,dni_pa,email_pa,ocuacion_pa,esta_civil_pa,celular_pa,grado_estudio_pa,centro_trabajo_pa,domi_actual_pa,fecha_defu,fecha_naci,lugar_naci,vive,vive_con_estu)
values (@nombre_pa,@apellido_pa,@dni_pa,@email_pa,@ocuacion_pa,@esta_civil_pa,@celular_pa,@grado_estudio_pa,@centro_trabajo_pa,@domi_actual,@fecha_defu,@fecha_naci,@lugar_naci,@vive,@vive_con_estu)


GO
/****** Object:  StoredProcedure [dbo].[spinsertar_pago]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_pago]
    @id_pago int output,
	@cantidad_pagar money ,
    @id_deta_deuda int,
	@fecha_pago date,
    @debe int
    
	
AS
insert into pago(cantidad_pagar,id_deta_deuda,fecha_pago,debe )
values (@cantidad_pagar,@id_deta_deuda,@fecha_pago,@debe )



GO
/****** Object:  StoredProcedure [dbo].[spinsertar_profe_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[spinsertar_profe_curso]
    @id_profe_curso int output,
	@id_profesor int ,
    @id_curso int
    
    
	
AS
insert into profe_curso(id_profesor,id_curso)
values (@id_profesor,@id_curso)





GO
/****** Object:  StoredProcedure [dbo].[spinsertar_profesor]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spinsertar_profesor]
    @id_profesor int output,
    @nombre varchar(50),
    @apellidos varchar(50),
    @dni char(8),
    @celular varchar(10),
    @email varchar(50),
    @fecha_naci date,
    @edad varchar(2),
    @id_año int
	
AS
insert into profesor(nombre,apellidos,dni,celular,email,fecha_naci,edad,id_año)
values (@nombre,@apellidos,@dni,@celular,@email,@fecha_naci,@edad,@id_año)





GO
/****** Object:  StoredProcedure [dbo].[splogin]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[splogin]
@id char(8),
@contraseña char(8)
as
select id_login,id_profesor,acceso
from LOGIN
where id=@id and contraseña=@contraseña





GO
/****** Object:  StoredProcedure [dbo].[spmostrar_alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spmostrar_alumno]
as
select  alumno.id_alumno,alumno.nombres ,alumno.apellidos,alumno.dni,alumno.fecha_naci,alumno.sexo,alumno.edad,alumno.id_padre,alumno.id_madre,alumno.id_año,alumno.codigo,alumno.lugar_naci,alumno.domi_actual,alumno.direccion,alumno.n_partida,alumno.religion,alumno.len_materna,alumno.n_hermanos,
        alumno.lugar_ocupa,alumno.cole_procedencia,alumno.discapacidad,alumno.parto
from alumno 





GO
/****** Object:  StoredProcedure [dbo].[spmostrar_alumnoSIGE]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spmostrar_alumnoSIGE]
as
select  alumno.id_alumno,alumno.nombres ,alumno.apellidos,alumno.dni,alumno.fecha_naci,alumno.sexo,alumno.edad,alumno.id_padre,alumno.id_madre,alumno.id_año,alumno.codigo,alumno.lugar_naci,alumno.domi_actual,alumno.direccion,alumno.n_partida,alumno.religion,alumno.len_materna,alumno.n_hermanos,
        alumno.lugar_ocupa,alumno.cole_procedencia,alumno.discapacidad,alumno.parto,madre.nombre_ma,madre.apellido_materno_ma,madre.dni_ma,madre.email_ma,madre.ocuacion_ma,madre.esta_civil_ma,madre.celular_ma,madre.grado_estudio_ma,madre.centro_trabajo_ma,madre.domi_actual_ma,madre.fecha_defu as fecha_defun_ma,madre.fecha_naci as fecha_naci_ma,madre.lugar_naci as lugar_naci_ma, madre.vive as vive_ma,madre.vive_con_estu as vive_von_etu_ma,
		padre.nombre_pa,padre.apellido_pa,padre.dni_pa,padre.email_pa,padre.ocuacion_pa,padre.esta_civil_pa,padre.celular_pa,padre.grado_estudio_pa,padre.centro_trabajo_pa,padre.domi_actual_pa,padre.fecha_defu as fecha_defun_pa,padre.fecha_naci as fecha_naci_pa,padre.lugar_naci as lugar_naci_pa, padre.vive as vive_pa,padre.vive_con_estu as vive_von_etu_pa
		 from alumno INNER JOIN PADRE ON ALUMNO.id_padre=padre.id_padre INNER JOIN madre on ALUMNO.id_madre=madre.id_madre 




GO
/****** Object:  StoredProcedure [dbo].[spmostrar_año]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[spmostrar_año]
AS
select año.id_año,año.descripcion,año.año
from año





GO
/****** Object:  StoredProcedure [dbo].[spmostrar_curso]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[spmostrar_curso]
AS
select curso.id_curso,curso.nombre,curso.grado
from curso





GO
/****** Object:  Table [dbo].[alumno]    Script Date: 26/06/2017 6:40:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alumno](
	[id_alumno] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[dni] [char](8) NOT NULL,
	[fecha_naci] [date] NOT NULL,
	[sexo] [varchar](50) NOT NULL,
	[edad] [varchar](20) NOT NULL,
	[id_padre] [int] NOT NULL,
	[id_madre] [int] NOT NULL,
	[id_año] [int] NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[lugar_naci] [varchar](50) NOT NULL,
	[domi_actual] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[n_partida] [varchar](50) NOT NULL,
	[religion] [varchar](50) NOT NULL,
	[len_materna] [varchar](50) NOT NULL,
	[n_hermanos] [varchar](10) NOT NULL,
	[lugar_ocupa] [varchar](50) NOT NULL,
	[cole_procedencia] [varchar](50) NOT NULL,
	[discapacidad] [char](2) NOT NULL,
	[parto] [char](2) NOT NULL,
 CONSTRAINT [PK_alumno] PRIMARY KEY CLUSTERED 
(
	[id_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__alumno__D87608A70706FB0F] UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[año]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[año](
	[id_año] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[año] [varchar](10) NOT NULL,
 CONSTRAINT [PK_año] PRIMARY KEY CLUSTERED 
(
	[id_año] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[año] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[curso]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[curso](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[grado] [varchar](50) NOT NULL,
	[año] [varchar](50) NOT NULL,
 CONSTRAINT [PK_curso] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[curso_alumno]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[curso_alumno](
	[id_curso_alumno] [int] IDENTITY(1,1) NOT NULL,
	[id_profe_curso] [int] NOT NULL,
	[id_alumno] [int] NOT NULL,
 CONSTRAINT [PK_curso_alumno] PRIMARY KEY CLUSTERED 
(
	[id_curso_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_deuda]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_deuda](
	[id_alumno] [int] NOT NULL,
	[id_deuda] [int] NOT NULL,
	[id_deta_deuda] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_detalle_deuda] PRIMARY KEY CLUSTERED 
(
	[id_deta_deuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_deuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[deuda]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[deuda](
	[id_deuda] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[monto] [int] NOT NULL,
 CONSTRAINT [PK_deuda] PRIMARY KEY CLUSTERED 
(
	[id_deuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOGIN](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[id] [char](8) NOT NULL,
	[contraseña] [char](8) NOT NULL,
	[acceso] [varchar](50) NOT NULL,
	[id_profesor] [int] NOT NULL,
 CONSTRAINT [PK__LOGIN__1DEA7BAD21DC98A5] PRIMARY KEY CLUSTERED 
(
	[id_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__LOGIN__159ED616B56B3D5C] UNIQUE NONCLUSTERED 
(
	[id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__LOGIN__99B700722689191C] UNIQUE NONCLUSTERED 
(
	[acceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[madre]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[madre](
	[id_madre] [int] IDENTITY(1,1) NOT NULL,
	[nombre_ma] [varchar](50) NOT NULL,
	[apellido_materno_ma] [varchar](50) NOT NULL,
	[dni_ma] [char](8) NOT NULL,
	[email_ma] [varchar](50) NOT NULL,
	[ocuacion_ma] [varchar](50) NOT NULL,
	[esta_civil_ma] [varchar](50) NOT NULL,
	[celular_ma] [varchar](10) NOT NULL,
	[grado_estudio_ma] [varchar](50) NOT NULL,
	[centro_trabajo_ma] [varchar](50) NOT NULL,
	[domi_actual_ma] [varchar](50) NOT NULL,
	[fecha_defu] [varchar](50) NOT NULL,
	[fecha_naci] [date] NOT NULL,
	[lugar_naci] [varchar](50) NOT NULL,
	[vive] [char](2) NOT NULL,
	[vive_con_estu] [char](2) NOT NULL,
 CONSTRAINT [PK_madre] PRIMARY KEY CLUSTERED 
(
	[id_madre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__madre__B79E10ABFBF508C4] UNIQUE NONCLUSTERED 
(
	[dni_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nota]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nota](
	[id_nota] [int] IDENTITY(1,1) NOT NULL,
	[n1] [int] NULL,
	[n2] [int] NULL,
	[n4] [int] NULL,
	[id_curso_alumno] [int] NOT NULL,
	[n3] [int] NULL,
 CONSTRAINT [PK_nota] PRIMARY KEY CLUSTERED 
(
	[id_nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[padre]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[padre](
	[id_padre] [int] IDENTITY(1,1) NOT NULL,
	[nombre_pa] [varchar](50) NOT NULL,
	[apellido_pa] [varchar](50) NOT NULL,
	[dni_pa] [char](8) NOT NULL,
	[email_pa] [varchar](50) NOT NULL,
	[ocuacion_pa] [varchar](50) NOT NULL,
	[esta_civil_pa] [varchar](50) NOT NULL,
	[celular_pa] [varchar](10) NOT NULL,
	[grado_estudio_pa] [varchar](50) NOT NULL,
	[centro_trabajo_pa] [varchar](50) NOT NULL,
	[domi_actual_pa] [varchar](50) NOT NULL,
	[fecha_defu] [int] NOT NULL,
	[fecha_naci] [date] NOT NULL,
	[lugar_naci] [varchar](50) NOT NULL,
	[vive] [char](2) NOT NULL,
	[vive_con_estu] [char](2) NOT NULL,
 CONSTRAINT [PK_padre] PRIMARY KEY CLUSTERED 
(
	[id_padre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__padre__B79E39480747DA7C] UNIQUE NONCLUSTERED 
(
	[dni_pa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[pago]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pago](
	[id_pago] [int] IDENTITY(1,1) NOT NULL,
	[cantidad_pagar] [int] NOT NULL,
	[id_deta_deuda] [int] NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[debe] [int] NOT NULL,
 CONSTRAINT [PK_pago] PRIMARY KEY CLUSTERED 
(
	[id_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__pago__CC0D58E5883C64B9] UNIQUE NONCLUSTERED 
(
	[id_deta_deuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[profe_curso]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profe_curso](
	[id_profesor] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[id_profe_curso] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_profe_curso] PRIMARY KEY CLUSTERED 
(
	[id_profe_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[profesor]    Script Date: 26/06/2017 6:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profesor](
	[id_profesor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[dni] [char](8) NOT NULL,
	[celular] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[fecha_naci] [date] NOT NULL,
	[edad] [varchar](2) NOT NULL,
	[id_año] [int] NOT NULL,
 CONSTRAINT [PK_profesor] PRIMARY KEY CLUSTERED 
(
	[id_profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[alumno]  WITH CHECK ADD  CONSTRAINT [FK_alumno_año] FOREIGN KEY([id_año])
REFERENCES [dbo].[año] ([id_año])
GO
ALTER TABLE [dbo].[alumno] CHECK CONSTRAINT [FK_alumno_año]
GO
ALTER TABLE [dbo].[alumno]  WITH CHECK ADD  CONSTRAINT [FK_alumno_madre] FOREIGN KEY([id_madre])
REFERENCES [dbo].[madre] ([id_madre])
GO
ALTER TABLE [dbo].[alumno] CHECK CONSTRAINT [FK_alumno_madre]
GO
ALTER TABLE [dbo].[alumno]  WITH CHECK ADD  CONSTRAINT [FK_alumno_padre] FOREIGN KEY([id_padre])
REFERENCES [dbo].[padre] ([id_padre])
GO
ALTER TABLE [dbo].[alumno] CHECK CONSTRAINT [FK_alumno_padre]
GO
ALTER TABLE [dbo].[curso_alumno]  WITH CHECK ADD  CONSTRAINT [FK_curso_alumno_alumno] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[alumno] ([id_alumno])
GO
ALTER TABLE [dbo].[curso_alumno] CHECK CONSTRAINT [FK_curso_alumno_alumno]
GO
ALTER TABLE [dbo].[curso_alumno]  WITH CHECK ADD  CONSTRAINT [FK_curso_alumno_profe_curso1] FOREIGN KEY([id_profe_curso])
REFERENCES [dbo].[profe_curso] ([id_profe_curso])
GO
ALTER TABLE [dbo].[curso_alumno] CHECK CONSTRAINT [FK_curso_alumno_profe_curso1]
GO
ALTER TABLE [dbo].[detalle_deuda]  WITH CHECK ADD  CONSTRAINT [FK_detalle_deuda_alumno] FOREIGN KEY([id_alumno])
REFERENCES [dbo].[alumno] ([id_alumno])
GO
ALTER TABLE [dbo].[detalle_deuda] CHECK CONSTRAINT [FK_detalle_deuda_alumno]
GO
ALTER TABLE [dbo].[detalle_deuda]  WITH CHECK ADD  CONSTRAINT [FK_detalle_deuda_deuda] FOREIGN KEY([id_deuda])
REFERENCES [dbo].[deuda] ([id_deuda])
GO
ALTER TABLE [dbo].[detalle_deuda] CHECK CONSTRAINT [FK_detalle_deuda_deuda]
GO
ALTER TABLE [dbo].[LOGIN]  WITH CHECK ADD  CONSTRAINT [FK_LOGIN_profesor] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[profesor] ([id_profesor])
GO
ALTER TABLE [dbo].[LOGIN] CHECK CONSTRAINT [FK_LOGIN_profesor]
GO
ALTER TABLE [dbo].[nota]  WITH CHECK ADD  CONSTRAINT [FK_nota_curso_alumno1] FOREIGN KEY([id_curso_alumno])
REFERENCES [dbo].[curso_alumno] ([id_curso_alumno])
GO
ALTER TABLE [dbo].[nota] CHECK CONSTRAINT [FK_nota_curso_alumno1]
GO
ALTER TABLE [dbo].[pago]  WITH CHECK ADD  CONSTRAINT [FK_pago_detalle_deuda] FOREIGN KEY([id_deta_deuda])
REFERENCES [dbo].[detalle_deuda] ([id_deta_deuda])
GO
ALTER TABLE [dbo].[pago] CHECK CONSTRAINT [FK_pago_detalle_deuda]
GO
ALTER TABLE [dbo].[profe_curso]  WITH CHECK ADD  CONSTRAINT [FK_profe_curso_curso] FOREIGN KEY([id_curso])
REFERENCES [dbo].[curso] ([id_curso])
GO
ALTER TABLE [dbo].[profe_curso] CHECK CONSTRAINT [FK_profe_curso_curso]
GO
ALTER TABLE [dbo].[profe_curso]  WITH CHECK ADD  CONSTRAINT [FK_profe_curso_profesor] FOREIGN KEY([id_profesor])
REFERENCES [dbo].[profesor] ([id_profesor])
GO
ALTER TABLE [dbo].[profe_curso] CHECK CONSTRAINT [FK_profe_curso_profesor]
GO
ALTER TABLE [dbo].[profesor]  WITH CHECK ADD  CONSTRAINT [FK_profesor_año] FOREIGN KEY([id_año])
REFERENCES [dbo].[año] ([id_año])
GO
ALTER TABLE [dbo].[profesor] CHECK CONSTRAINT [FK_profesor_año]
GO
USE [master]
GO
ALTER DATABASE [primeros_frutos] SET  READ_WRITE 
GO

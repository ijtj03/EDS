insert into estudiantes (carne, correo_electronico,  primer_nombre, segundo_nombre, primer_apellido , segundo_apellido) 
values ('2015012410' , 'esteban_hv.09@hotmail.com','Esteban', 'Jose','Herrera', 'Vargas');
insert into estudiantes (carne, correo_electronico,  primer_nombre, segundo_nombre, primer_apellido , segundo_apellido) 
values ('2015127287' , 'ijtj03@gmail.com' , 'Isaac' , 'Jose' , 'Trejos' , 'Jara');
insert into estudiantes (carne, correo_electronico,  primer_nombre, primer_apellido , segundo_apellido)  
values ('2015183074', 'and-h@hotmail.com' , 'André','Herrera', 'Chacón' );
INSERT estudiantes (carne, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, correo_electronico) 
VALUES ('2015028430', 'David', 'Eduardo', 'Gomez', 'Vargas', 'daedgomez@gmail.com');


INSERT usuario (correo_electronico, cedula, contrasenna, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido) 
VALUES ('lcortes@itcr.ac.cr', '116608924','', 'Laura', 'Maria', 'Cortes', 'Ugalde');
INSERT usuario (correo_electronico, cedula, contrasenna, primer_nombre, primer_apellido, segundo_apellido) 
VALUES ('mrivera@itcr.ac.cr', '999999999','123456', 'Marco', 'Rivera', 'Meneses');
INSERT usuario (correo_electronico, cedula, contrasenna, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido) 
VALUES ('esteban_hv.09@hotmail,com', '116880380','123456', 'Esteban', 'Jose', 'Herrera', 'Vargas');

INSERT sistema_informacion (nombre) VALUES ('Inclusiones');
INSERT sistema_informacion (nombre) VALUES ('Horas Beca');

INSERT rol (nombre, sistema) VALUES ('Administrador Inclusiones', 1);
INSERT rol (nombre, sistema) VALUES ('Administrador Horas Beca', 2);
Insert into rol(nombre,sistema)VALUES('Encargado',2);
Insert into rol(nombre,sistema)VALUES('Comision Becas',2);

INSERT roles_por_usuario (usuario, rol) VALUES (1, 1);
INSERT roles_por_usuario (usuario, rol) VALUES (1, 2);


Insert into ESTADO(Id,Estado)VALUES(0,'Fallido');
Insert into ESTADO(Id,Estado)VALUES(1,'Enviado');

Insert into Curso(IdCurso,Codigo)VALUES(1,'CE0001')
Insert into Curso(IdCurso,Codigo)VALUES(2,'CE0002')
Insert into Curso(IdCurso,Codigo)VALUES(3,'CE0003')

Insert into Departamento(Nombre,Descripcion)VALUES('Computacion','Computacion')
Insert into Departamento(Nombre,Descripcion)VALUES('Materiales','Materiales')
Insert into Departamento(Nombre,Descripcion)VALUES('Electronica','Electronica')


Insert into TipoBeca(Nombre,Descripcion)VALUES('Horas Estudiante','Descripcion')
Insert into TipoBeca(Nombre,Descripcion)VALUES('Horas Asistente','Descripcion')
Insert into TipoBeca(Nombre,Descripcion)VALUES('Tutoria Estudiantil','Descripcion')
Insert into TipoBeca(Nombre,Descripcion)VALUES('Asistencia Especial','Descripcion')

Insert into Formulario(Cedula,Correo,CuentaBancaria,IdCurso,IdDepartamento,IdTipoBeca,ImgCedula
						,ImgCuentaBancaria,ImgPromedioPonderado,ImgPromedioGeneral,OtraBeca,OtraBecaHoras
						,PromedioCurso,PromedioPonderadoAnterior,PromedioPonderadoGeneral,Telefono)
Values('111111111','ijtj03@gmail.com',11111111,1,1,1,'abc','abc','abc','abc','ob',12,90.1,90.1,90.1,22222222)
Insert into Formulario(Cedula,Correo,CuentaBancaria,IdCurso,IdDepartamento,IdTipoBeca,ImgCedula
						,ImgCuentaBancaria,ImgPromedioPonderado,ImgPromedioGeneral,OtraBeca,OtraBecaHoras
						,PromedioCurso,PromedioPonderadoAnterior,PromedioPonderadoGeneral,Telefono)
Values('111111111','ijtj03@gmail.com',11111111,2,2,2,'abc','abc','abc','abc','ob',12,90.1,90.1,90.1,22222222)
Insert into Formulario(Cedula,Correo,CuentaBancaria,IdCurso,IdDepartamento,IdTipoBeca,ImgCedula
						,ImgCuentaBancaria,ImgPromedioPonderado,ImgPromedioGeneral,OtraBeca,OtraBecaHoras
						,PromedioCurso,PromedioPonderadoAnterior,PromedioPonderadoGeneral,Telefono)
Values('111111111','ijtj03@gmail.com',11111111,3,3,3,'abc','abc','abc','abc','ob',12,90.1,90.1,90.1,22222222)


Insert into EstudiantexFormulario (IdCarnet,IdFormulario) values ('2015012410',1)
Insert into EstudiantexFormulario (IdCarnet,IdFormulario) values ('2015127287',2)
Insert into EstudiantexFormulario (IdCarnet,IdFormulario) values ('2015183074',3)

Insert into UsuarioxEstudiante (IdCarnet,IdUsuario,HorasAsignadas,HorasLaboradas,Observaciones,Recomienda)
Values ('2015127287',2,50,0,'',0)


insert into EstadoSolicitud (Descripcion) values ('Enviado');
insert into EstadoSolicitud (Descripcion) values ('Cancelado');
insert into EstadoSolicitud (Descripcion) values ('Corregir');
insert into EstadoSolicitud (Descripcion) values ('Aceptado');
insert into EstadoSolicitud (Descripcion) values ('Denegado');

insert into Solicitud (IdCarnet , IdFormulario, IdEstado , Observacion , FechaSolicitud ,PeriodoSolicitud) values ('2015012410' , 1 , 3 , 'Esta Solicitud se hace para el Departamento de Admision y Registro' , '9/6/2018' , 'II');
insert into Solicitud (IdCarnet , IdFormulario, IdEstado , Observacion , FechaSolicitud ,PeriodoSolicitud) values ('2015127287' , 2 , 1 , 'Solicitud para escuela de Matematicas' , '7/6/2018' , 'I');
insert into Solicitud (IdCarnet , IdFormulario, IdEstado , Observacion , FechaSolicitud ,PeriodoSolicitud) values ('2015028430' , 3 , 1 , 'Solicitud para escuela de Matematicas' , '1/6/2018' , 'I');



insert into SolicitudxFormulario (IdSolicitud, IdFormulario) values (4,1);
insert into SolicitudxFormulario (IdSolicitud, IdFormulario) values (5,2);
insert into SolicitudxFormulario (IdSolicitud, IdFormulario) values (6,3);


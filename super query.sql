select ae.costo, an.codigo, ex.id  ,ex.fecha, ex.costo , os.nombre , pa.nombre, pa.apellido,po.afiliado 
 from dbo.AnalisisExamen ae inner join Examenes ex on ae.idExamen=ex.id 
 inner join dbo.ObrasSociales os on ex.idOS = os.id
 inner join dbo.Analisis an on an.id=ae.idAnalisis
 inner join dbo.Pacientes pa on ex.idPaciente=pa.id 
 inner join dbo.PacienteOS po on (po.idOS= ex.idOS and po.IdPaciente=pa.id) ;
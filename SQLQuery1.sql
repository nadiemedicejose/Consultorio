SELECT EspecialidadID, NombreEspecialidad AS Especialidad FROM Especialidades

SELECT DentistaID AS ID, NombreDentista AS Nombre, Dirección, Teléfono, Edad, NombreEspecialidad AS Especialidad FROM Dentistas
INNER JOIN Especialidades ON Dentistas.Especialidad = Especialidades.EspecialidadID

SELECT PacienteID, NombrePaciente AS Nombre, Dirección, Teléfono FROM Pacientes

SELECT DentistaID, NombreDentista AS Nombre, Dirección, Teléfono, Edad, NombreEspecialidad AS Especialidad FROM Dentistas
INNER JOIN Especialidades ON Dentistas.Especialidad = Especialidades.EspecialidadID
WHERE DentistaID = 4

SELECT PacienteID, NombrePaciente AS Nombre, Dirección, Teléfono FROM Pacientes WHERE PacienteID = 2

SELECT EspecialidadID, NombreEspecialidad AS Especialidad FROM Especialidades WHERE EspecialidadID = 3

SELECT CitaID AS ID, NombreDentista AS Dentista, NombreEspecialidad AS Especialidad, NombrePaciente AS Paciente, DescripciónTrabajo AS Descripción FROM Citas
INNER JOIN Dentistas ON Citas.DentistaID = Dentistas.DentistaID
INNER JOIN Especialidades ON Citas.EspecialidadID = Especialidades.EspecialidadID
INNER JOIN Pacientes ON Citas.PacienteID = Pacientes.PacienteID
WHERE Citas.CitaID = 2
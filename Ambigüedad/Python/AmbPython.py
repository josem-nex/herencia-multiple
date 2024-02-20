class Estudiante():
    def __init__(self, nombre):
        self.nombre = nombre
    def RecibirClase(self):
        print("El estudiante " + self.nombre + " está recibiendo clase")
    def CobrarSalario(self):
        print("El estudiante " + self.nombre + " está cobrando salario")
class Profesor():
    def __init__(self, nombre):
        self.nombre = nombre
    def CobrarSalario(self):
        print("El Profesor " + self.nombre + " está cobrando salario")
    def ImpartirClase(self):
        print("El Profesor " + self.nombre + " está impartiendo clase")
class AlumnoAyudante(Estudiante, Profesor):
    def __init__(self, name):
        self.nombre = name
    def CobrarSalario(self):
        print("El alumno ayudante " + self.nombre + " está cobrando salario")
        # Profesor.CobrarSalario(self)
        # Estudiante.CobrarSalario(self)
        
# MRO (Method Resolution Order)       Primero en profundidad

alumno = AlumnoAyudante("Juan")
alumno.CobrarSalario()  # output: El estudiante Juan está cobrando salario
print(alumno.nombre)
Profesor.CobrarSalario(alumno)



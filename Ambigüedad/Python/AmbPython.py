class Persona:
    def __init__(self, nombre):
        self.nombre = nombre

class Estudiante(Persona):
    def RecibirClase(self):
        print("El estudiante " + self.nombre + " está recibiendo clase")

    def CobrarSalario(self):
        print("El estudiante " + self.nombre + " está cobrando salario")

class Trabajador(Persona):
    def CobrarSalario(self):
        print("El trabajador " + self.nombre + " está cobrando salario")

class AlumnoAyudante(Estudiante, Trabajador):
    
    def __init__(self, nombre):
        self.nombre = nombre
        # Estudiante.__init__(self, nombre)
        # Trabajador.__init__(self, nombre)
    def ImpartirClase(self):
        print("El alumno ayudante " + self.nombre + " está impartiendo clase")
    # def CobrarSalario(self):
        # print("El alumno ayudante " + self.nombre + " está cobrando salario")
        # Trabajador.CobrarSalario(self)
        # Estudiante.CobrarSalario(self)
        
# MRO (Method Resolution Order)       Primero en profundidad

alumno = AlumnoAyudante("Juan")
alumno.CobrarSalario()
# Trabajador.CobrarSalario(alumno)


